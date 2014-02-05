
namespace ThreeD
{
    using System.Collections.Generic;
    public class Path
    {
        private static List<Point3D> listOfPoints;

        public Path()
        {
            listOfPoints = new List<Point3D>();
        }

        public List<Point3D> ListOfPoints
        {
            get
            {
                return listOfPoints;
            }
        }

        public static void ClearPath()
        {
            Path path = new Path();
            listOfPoints.Clear();
        }

        public void AddPoint(Point3D a)
        {
            listOfPoints.Add(a);
        }

       

        public void PrintPath(Path a)
        {
            foreach (var point in listOfPoints)
            {
                System.Console.WriteLine("Step: " + point);
            }
        }
    }
}
