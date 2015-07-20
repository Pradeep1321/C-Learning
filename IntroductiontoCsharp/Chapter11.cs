 /*REMEMBER A private class member will remain private to its class. It is not accessible to any code
outside its class, including derived classes.*/

// Demonstrate protected.
using System;
class BD
{
    protected int i, j; // private to B, but accessible by D
    public void Set(int a, int b)
    {
        i = a;
        j = b;
    }
    public void Show()
    {
        Console.WriteLine(i + " " + j);
    }
}

class D : BD
{
    int k; // private
    // D can access B's i and j
    public void Setk()
    {
        k = i * j;
    }
    public void Showk()
    {
        Console.WriteLine(k);
    }
}
class ProtectedDemo
{
    static void Main9()
    {
        D ob = new D();
        ob.Set(2, 3); // OK, known to D
        ob.Show(); // OK, known to D
        ob.Setk(); // OK, part of D
        ob.Showk(); // OK, part of D
    }
}