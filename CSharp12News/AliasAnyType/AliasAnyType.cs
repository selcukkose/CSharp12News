namespace CSharp12News.AliasAnyType;

// Instead of declaring a new type, we can use alias for any type
using Point = (int x, int y);

public class AliasAnyType
{
    public Point Add(Point p1, Point p2) => (p1.x + p2.x, p1.y + p2.y);
}