
namespace ThreeD
{
    using System;
    using System.IO;
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        private int xCoordinate;
        private int yCoordinate;
        private int zCoordinate;
        private string str;

        public Point3D(int x, int y, int z)
        {
            this.xCoordinate = x;
            this.yCoordinate = y;
            this.zCoordinate = z;
            this.str = string.Empty;
        }

        public Point3D(string str)
        {
            this.str = str;
            this.xCoordinate = (int)char.GetNumericValue(str[0]);
            this.yCoordinate = (int)char.GetNumericValue(str[1]);
            this.zCoordinate = (int)char.GetNumericValue(str[2]);
        }

        public static Point3D O
        {
            get
            {
                return o;
            }
        }
        public int XCoordinate
        {
            get
            {
                return this.xCoordinate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be non-negative");
                }
                this.xCoordinate = value;
            }
        }
        public int YCoordinate
        {
            get
            {
                return this.yCoordinate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be non-negative");
                }
                this.yCoordinate = value;
            }
        }

        public int ZCoordinate
        {
            get
            {
                return this.zCoordinate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be non-negative");
                }
                this.zCoordinate = value;
            }
        }

        public override string ToString()
        {
            return this.xCoordinate + " " + this.yCoordinate + " " + this.zCoordinate;
        }
    }
}
