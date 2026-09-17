using System;

namespace Assignment_04
{
    public class Point3D : IComparable<Point3D>, ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D() : this(0, 0, 0)
        {
        }

        public Point3D(double x, double y) : this(x, y, 0)
        {
        }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(Point3D other)
        {
            if (other is null)
                return 1;

            if (X != other.X)
                return X.CompareTo(other.X);

            return Y.CompareTo(other.Y);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}
