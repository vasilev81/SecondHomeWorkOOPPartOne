
namespace ThreeD
{
    using System;
    class Test3D
    {


        public static void Main()
        {
            Point3D point = new Point3D(3, 5, 6);

            Point3D secondpoint = new Point3D(1, 2, 3);

            Console.WriteLine("Distance: " + Calculate3DDistance.CalculateDistance(point, secondpoint));

            PathStorage.LoadPath();

            Path path = new Path();
                      
            path.AddPoint(point);
            path.AddPoint(secondpoint);

            PathStorage.SavePath(path);





        }
    }
}
