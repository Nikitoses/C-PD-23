using System;

public class Figure
{
    private Point[] points;

    public Figure(params Point[] points)
    {
        if (points.Length < 3 || points.Length > 5)
        {
            throw new ArgumentException("The number of points must be between 3 and 5.");
        }

        this.points = points;
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length; i++)
        {
            Point A = points[i];
            Point B = points[(i + 1) % points.Length];

            perimeter += LengthSide(A, B);
        }

        Console.WriteLine($"Perimeter: {perimeter}");
    }
}