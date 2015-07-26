// Pass a derived class reference to a base class reference.
using System;
class TwoDShape2 {
    double pri_width;
    double pri_height;
    // Default constructor.
    public TwoDShape2() {
        Width = Height = 0.0;
    }
    // Constructor for TwoDShape.
    public TwoDShape2(double w, double h) {
        Width = w;
        Height = h;
    }
    // Construct object with equal width and height.
    public TwoDShape2(double x) {
        Width = Height = x;
    }

    // Construct a copy of a TwoDShape object.
    public TwoDShape2(TwoDShape2 ob) {
        Width = ob.Width;
        Height = ob.Height;
    }
    // Properties for Width and Height.
    public double Width {
        get { return pri_width; }
        set { pri_width = value < 0 ? -value : value; }
    }
    public double Height {
        get { return pri_height; }
        set { pri_height = value < 0 ? -value : value; }
    }
    public void ShowDim() {
        Console.WriteLine("Width and height are " +
        Width + " and " + Height);
    }
}
// A derived class of TwoDShape for triangles.
class Triangle2 : TwoDShape2 {
    string Style;
    // A default constructor.
    public Triangle2() {
        Style = "null";
    }
        // Constructor for Triangle.
    public Triangle2(string s, double w, double h) : base(w, h) {
        Style = s;
    }
    // Construct an isosceles triangle.
    public Triangle2(double x) : base(x) {
        Style = "isosceles";
    }
    // Construct a copy of a Triangle object.
    public Triangle2(Triangle2 ob) : base(ob) {
        Style = ob.Style;
    }
    // Return area of triangle.
    public double Area() {
        return Width * Height / 2;
    }

    // Display a triangle's style.
    public void ShowStyle()
    {
        Console.WriteLine("Triangle is " + Style);
    }
}
class Shapes7
{
    static void Main13()
    {
        Triangle2 t1 = new Triangle2("right", 8.0, 12.0);
        // Make a copy of t1.
        Triangle2 t2 = new Triangle2(t1);
        Console.WriteLine("Info for t1: ");
        t1.ShowStyle();
        t1.ShowDim();
        Console.WriteLine("Area is " + t1.Area());
        Console.WriteLine();
        Console.WriteLine("Info for t2: ");
        t2.ShowStyle();
        t2.ShowDim();
        Console.WriteLine("Area is " + t2.Area());
    }
}