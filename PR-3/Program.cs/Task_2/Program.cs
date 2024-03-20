using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Point A = new Point(0, 0, "A");
        Point B = new Point(0, 1, "B");
        Point C = new Point(1, 1, "C");
        Point D = new Point(1, 0, "D");

        Figure figure = new Figure(A, B, C, D);
        figure.PerimeterCalculator();
    }
}