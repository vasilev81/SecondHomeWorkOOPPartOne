
namespace ThreeD
{
    using System;
    public static class Calculate3DDistance
    {
        public static double CalculateDistance(Point3D a, Point3D b)
        {
            double distance = 0;

            distance = Math.Sqrt(Math.Pow((a.XCoordinate - b.XCoordinate), 2) +
                Math.Pow((a.YCoordinate - b.YCoordinate), 2) + Math.Pow((a.ZCoordinate - b.ZCoordinate), 2));

            return distance;
        }
    }
}
