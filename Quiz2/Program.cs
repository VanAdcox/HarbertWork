public class Program
{
    public static void Main(string[] args)
    {
        Point p1 = new Point(10, 20, "blue");
        Point p2 = new Point();

        Console.WriteLine(p1);
        Console.WriteLine(p2);

        p1.move(5, 10);
        Console.WriteLine(p1);
        //Console.WriteLine($"Is p1 in Q2? : {p1.isInQuadrant(2)}");
        if (p1.isInQuadrant(2)) { Console.WriteLine("yes"); }
        else { Console.WriteLine("no"); }
        double dist = p1.distance(p2);
        Console.WriteLine(dist);
        Console.WriteLine(p1.getColor());
        Point[] points = new Point[4];
        points[0] = p1;
        points[3] = p2;
        foreach (Point p in points)
        {
            if (p != null) { Console.WriteLine(p); }
        }
    }
}
public class Point
{
    int x, y;
    string color;

    public Point()
    {
        x = 0;
        y = 0;
        color = "black";
    }
    public Point(int x, int y, string color)
    {
        this.x = x;
        this.y = y;
        this.color = color;
    }
    public override string ToString()
    {
        return $"({x},{y}) {color}";
    }
    public void move(int xOff, int yOff)
    {
        this.x += xOff;
        this.y += yOff;
    }
    public bool isInQuadrant(int quadNum)
    {
        // Q1 Pos X & Y
        if (quadNum == 1)
        {
            if (x > 0 && y > 0) { return true; }
            return false;
        }
        // Q2 Neg X & Pos Y
        else if (quadNum == 2)
        {
            if (x < 0 && y > 0) { return true; }
            return false;
        }
        // Q3 Neg X & Y
        else if (quadNum == 3)
        {
            if (x < 0 && y < 0) { return true; }
            return false;
        }
        // Q4 Pos X & Neg Y
        else if (x > 0 && y < 0) { return true; }
        return false;
    }
    public string getColor() { return this.color; }
    public double distance(Point other)
    {
        return Math.Sqrt(Math.Pow((other.x - this.x), 2) + Math.Pow((other.y - this.y), 2));
    }
}
