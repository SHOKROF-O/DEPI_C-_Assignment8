using System;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project - Point3D

            Point3D p = new Point3D(10, 10, 10);
            Console.WriteLine(p.ToString());
            // Output: Point Coordinates: (10, 10, 10)

            Console.WriteLine("----------------------------------");

            // reading P1 using Parse
            Console.Write("Enter X for P1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Y for P1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter Z for P1: ");
            double z1 = double.Parse(Console.ReadLine());
            Point3D p1 = new Point3D(x1, y1, z1);

            // reading P2 using TryParse and Convert
            Console.Write("Enter X for P2: ");
            double x2;
            if (!double.TryParse(Console.ReadLine(), out x2))
                x2 = 0;

            Console.Write("Enter Y for P2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Z for P2: ");
            double z2 = Convert.ToDouble(Console.ReadLine());
            Point3D p2 = new Point3D(x2, y2, z2);

            Console.WriteLine(p1 == p2);
            // this always prints False even if the coordinates are equal,
            // because == is not overloaded for Point3D, so it compares
            // references (are P1 and P2 the same object in memory), not
            // the actual X/Y/Z values. to make it compare values we would
            // need to overload the == operator (next session).

            Console.WriteLine("----------------------------------");

            Point3D[] points = new Point3D[]
            {
                new Point3D(5, 2, 1),
                new Point3D(1, 9, 3),
                new Point3D(3, 4, 2)
            };

            Array.Sort(points);

            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("----------------------------------");

            Point3D original = new Point3D(1, 2, 3);
            Point3D cloned = (Point3D)original.Clone();
            Console.WriteLine(original);
            Console.WriteLine(cloned);

            #endregion

            Console.WriteLine("----------------------------------");

            #region Second Project - Maths

            Console.WriteLine(Maths.Add(5, 3));
            Console.WriteLine(Maths.Subtract(5, 3));
            Console.WriteLine(Maths.Multiply(5, 3));
            Console.WriteLine(Maths.Divide(6, 3));
            // Maths is a static class, so its methods are called directly
            // through the class name (no "new Maths()" needed)

            #endregion

            Console.WriteLine("----------------------------------");

            #region Third Project - Duration

            Duration d1 = new Duration(1, 10, 15);
            Console.WriteLine(d1);
            // Output: Hours: 1, Minutes :10, Seconds :15

            Duration d2 = new Duration(3600);
            Console.WriteLine(d2);
            // Output: Hours: 1, Minutes :0, Seconds :0

            Duration d3 = new Duration(7800);
            Console.WriteLine(d3);
            // Output: Hours: 2, Minutes :10, Seconds :0

            Duration d4 = new Duration(666);
            Console.WriteLine(d4);
            // Output: Minutes :11, Seconds :6

            #endregion
        }
    }
}
