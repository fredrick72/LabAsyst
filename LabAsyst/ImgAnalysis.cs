using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;

namespace LabAsyst
{
    [Serializable]
    public class ImgAnalysis
    {
        private Point location;
        private Image<Gray, Double> results;
        private Image<Gray, Byte> cannyEdges;
        private Image<Gray, Byte> circleImage;
        private Image<Gray, Byte> triangleRectangleImage;
        private CircleF[] detectedCircle;

        public CircleF[] DetectedCircle
        {
            get { return detectedCircle; }
            set { detectedCircle = value; }
        }
        

        public Image<Gray, Byte> TriangleRectangleImage
        {
          get { return triangleRectangleImage; }
          set { triangleRectangleImage = value; }
        }
        
        public Image<Gray, Byte> CircleImage
        {
          get { return circleImage; }
          set { circleImage = value; }
        }


        public Image<Gray, Double> Results
        {
            get { return results; }
        }

        public Point Location
        {
            get { return location; }
            set { location = value; }
        }

        public bool Detect_object(Image<Gray, Byte> Area_Image, Image<Gray, Byte> image_object)
        {
            bool success = false;

            //Work out padding array size
            Point dftSize = new Point(Area_Image.Width + (image_object.Width * 2), Area_Image.Height + (image_object.Height * 2));
            //Pad the Array with zeros
            using (Image<Gray, Byte> pad_array = new Image<Gray, Byte>(dftSize.X, dftSize.Y))
            {
                //copy centre
                pad_array.ROI = new Rectangle(image_object.Width, image_object.Height, Area_Image.Width, Area_Image.Height);
                CvInvoke.cvCopy(Area_Image, pad_array, IntPtr.Zero);

                pad_array.ROI = (new Rectangle(0, 0, dftSize.X, dftSize.Y));

                //Match Template
                using (Image<Gray, float> result_Matrix = pad_array.MatchTemplate(image_object, TM_TYPE.CV_TM_CCOEFF_NORMED))
                {
                    Point[] MAX_Loc, Min_Loc;
                    double[] min, max;
                    //Limit ROI to look for Match

                    //result_Matrix.ROI = new Rectangle(image_object.Width, image_object.Height, Area_Image.Width - image_object.Width, Area_Image.Height - image_object.Height);

                    result_Matrix.MinMax(out min, out max, out Min_Loc, out MAX_Loc);

                    Location = new Point((MAX_Loc[0].X), (MAX_Loc[0].Y));
                    success = true;
                    results = result_Matrix.Convert<Gray, Double>();

                }
            }
            return success;
        }
        public bool DetectCircles(Image<Gray, Byte> gray) 
        {
            
            
            CircleF[] circles = gray.HoughCircles(
                new Gray(Properties.Settings.Default.CannyThreshold),
                new Gray(Properties.Settings.Default.AccumulatorTreshold),
                .5, //Resolution of the accumulator used to detect centers of the circles
                20.0, //min distance 
                Properties.Settings.Default.MinRadius, //min radius
                Properties.Settings.Default.MaxRadius //max radius
                )[0]; //Get the circles from the first channel

            circleImage = gray.CopyBlank();
            if (circles.Length > 0)
            {
                detectedCircle = circles;
                foreach (CircleF circle in circles)
                    gray.Draw(circle, new Gray(5), 2);
                    circleImage = gray;
                    return true;
            }
            else {
                circleImage = gray;
                return false;
            }
           
            
            
        }
        public void DetectPolygons(Image<Gray, Byte> gray)
        {
            List<Triangle2DF> triangleList = new List<Triangle2DF>();
            List<MCvBox2D> boxList = new List<MCvBox2D>(); //a box is a rotated rectangle
            DetectCannyEdge(gray); //need canny edge detect first
            using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
                for (
                   Contour<Point> contours = cannyEdges.FindContours(
                      Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                      Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST,
                      storage);
                   contours != null;
                   contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);

                    if (currentContour.Area > 250) //only consider contours with area greater than 250
                    {
                        if (currentContour.Total == 3) //The contour has 3 vertices, it is a triangle
                        {
                            Point[] pts = currentContour.ToArray();
                            triangleList.Add(new Triangle2DF(
                               pts[0],
                               pts[1],
                               pts[2]
                               ));
                        }
                        else if (currentContour.Total == 4) //The contour has 4 vertices.
                        {
                            #region determine if all the angles in the contour are within [80, 100] degree
                            bool isRectangle = true;
                            Point[] pts = currentContour.ToArray();
                            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                            for (int i = 0; i < edges.Length; i++)
                            {
                                double angle = Math.Abs(
                                   edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                if (angle < 80 || angle > 100)
                                {
                                    isRectangle = false;
                                    break;
                                }
                            }
                            #endregion

                            if (isRectangle) boxList.Add(currentContour.GetMinAreaRect());
                        }
                    }
                }

            if (triangleList.Count > 0)
            {
                triangleRectangleImage = gray.CopyBlank();
                foreach (Triangle2DF triangle in triangleList)
                    triangleRectangleImage.Draw(triangle, new Gray(2), 2);
                foreach (MCvBox2D box in boxList)
                    triangleRectangleImage.Draw(box, new Gray(2), 2);

            }
            else {
                triangleRectangleImage = gray;
            }
            
            

        }
            public void DetectCannyEdge(Image<Gray, Byte> gray)
            {
             double cannyThreshold = 180.0;
             double cannyThresholdLinking = 120.0;
                cannyEdges = gray.Canny(cannyThreshold, cannyThresholdLinking);
                LineSegment2D[] lines = cannyEdges.HoughLinesBinary(
                1, //Distance resolution in pixel-related units
                Math.PI / 45.0, //Angle resolution measured in radians.
                20, //threshold
                30, //min Line width
                10 //gap between lines
                )[0]; //Get the lines from the first channel
            }
           

        }
    }

