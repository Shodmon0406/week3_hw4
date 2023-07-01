namespace Task1.Classes;

public class Point2D
{
    int _x = 0;
    int _y = 0;
    public Point2D()
    {

    }
    public Point2D(int x, int y)
    {
        _x = x;
        _y = y; 
    }
    public int X { get => _x; set => _x = value; }
    public int Y { get => _y; set => _y = value; }
    public override string ToString()
    {
        return $"({_x}, {_y})";
    }
}
