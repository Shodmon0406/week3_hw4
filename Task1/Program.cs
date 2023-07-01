using Task1.Classes;

Point2D point2D = new Point2D(2, 6);
System.Console.WriteLine(point2D.X);
point2D.X = 3;
System.Console.WriteLine(point2D.ToString());
Point3D point3D = new Point3D(1, 2, 3);
System.Console.WriteLine(point3D.ToString());
point3D.Y = 5;
System.Console.WriteLine(point3D.Z);
System.Console.WriteLine(point3D.ToString());