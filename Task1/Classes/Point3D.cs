namespace Task1.Classes;

public class Point3D : Point2D
{
    int _z = 0;
    public Point3D()
    {
        
    }
    public Point3D(int x, int y, int z) : base(x, y)
    {
        _z = z;
    }
    public int Z { get => _z; set => _z = value; }
    public override string ToString()
    {
        return $"({X}, {Y}, {_z})";
    }
}
