
namespace ThreeD
{
    using System.IO;
    public static class PathStorage
    {

        public static void LoadPath()
        {
            StreamReader reader = new StreamReader(@".../.../text/Input.txt");

            Path path = new Path();

            string line = reader.ReadLine();
            path.AddPoint(new Point3D(line));

            while (line != null)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                path.AddPoint(new Point3D(line));
            }
            reader.Close();

            path.PrintPath(path);
        }

        public static void SavePath(Path path)
        {
            StreamWriter writer = new StreamWriter(@".../.../text/Output.txt");

            foreach (var item in path.ListOfPoints)
            {
                writer.WriteLine(item);
            }

            writer.Close();
        }
    }
}
