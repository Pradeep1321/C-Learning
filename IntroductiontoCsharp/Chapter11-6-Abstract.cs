
// Create an abstract class.
using System;
abstract class TwoDShape21 {
    double pri_width;
    double pri_height;
    // A default constructor.
    public TwoDShape21() {
        Width = Height = 0.0;
        name = "null";
    }

    // Parameterized constructor.
    public TwoDShape21(double w, double h, string n) {
        Width = w;
        Height = h;
        name = n;
    }
    // Construct object with equal width and height.
    public TwoDShape21(double x, string n) {
        Width = Height = x;
        name = n;
    }
    // Construct a copy of a TwoDShape object.
    public TwoDShape21(TwoDShape21 ob) {
        Width = ob.Width;
        Height = ob.Height;
        name = ob.name;
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
    public string name { get; set; }
    public void ShowDim() {
        Console.WriteLine("Width and height are " +
        Width + " and " + Height);
    }
    // Now, Area() is abstract.
    public abstract double Area();
}

// A derived class of TwoDShape for triangles.
class Triangle21 : TwoDShape21 {
    string Style;
    // A default constructor.
    public Triangle21() {
        Style = "null";
    }
    // Constructor for Triangle.
    public Triangle21(string s, double w, double h) :
        base(w, h, "triangle") {
        Style = s;
    }

        // Construct an isosceles triangle.
    public Triangle21(double x) : base(x, "triangle") {
        Style = "isosceles";
    }
    // Construct a copy of a Triangle object.
    public Triangle21(Triangle21 ob) : base(ob) {
        Style = ob.Style;
    }
    // Override Area() for Triangle.
    public override double Area() {
        return Width * Height / 2;
    }
    // Display a triangle's style.
    public void ShowStyle() {
        Console.WriteLine("Triangle is " + Style);
    }
}
// A derived class of TwoDShape for rectangles.
class Rectangle21 : TwoDShape21 {
    // Constructor for Rectangle.
    public Rectangle21(double w, double h) :
        base(w, h, "rectangle") { }
    // Construct a square.
    public Rectangle21(double x) :
        base(x, "rectangle") { }
    // Construct a copy of a Rectangle object.
    public Rectangle21(Rectangle21 ob) : base(ob) { }
    // Return true if the rectangle is square.
    public bool IsSquare()
    {
        if (Width == Height) return true;
        return false;
    }
    // Override Area() for Rectangle.
    public override double Area()
    {
        return Width * Height;
    }
}

class AbsShape
{
    static void Main15()
    {
        TwoDShape21[] shapes = new TwoDShape21[4];
        shapes[0] = new Triangle21("right", 8.0, 12.0);
        shapes[1] = new Rectangle21(10);
        shapes[2] = new Rectangle21(10, 4);
        shapes[3] = new Triangle21(7.0);
        for (int i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine("object is " + shapes[i].name);
            Console.WriteLine("Area is " + shapes[i].Area());
            Console.WriteLine();
        }
    }
}