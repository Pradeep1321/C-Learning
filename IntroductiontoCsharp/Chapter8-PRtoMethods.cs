// Value types are passed by value.
using System;

class Test {
    /* This method causes no change to the arguments
    used in the call. */
    /* IMPORTANT: If you are using the same variable name in the methods referance values and local values, 
    then you have to use this keyword to make the differnece otherwise, the system cannot make it as object reference and considers it as lcoal values and assigns 0    */

    public int i,j;

    public void NoChange(int i, int j) {  
        this.i= i + j;
        this.j = -j;
    }

    // Use ref to pass a value type by reference.
    public void Sqr(ref int i)
    {
        i = i * i;
    }

    // Use out.
    public int GetParts(double n, out double frac)
    {
        int whole;
        whole = (int)n;
        frac = n - whole; // pass fractional part back through frac
        return whole; // return integer portion
    }

    // This method changes its arguments.
    public void Swap(ref Test ob1,ref Test ob2)
    {
        Test t;
        t = ob1;
        ob1 = ob2;
        ob2 = t;
    }

    public void Show()
    {
        Console.WriteLine("i: {0}, j: {1}", i, j);
    }

    // Demonstrate params.
    public int MinVal(string msg, params int[] nums) {
        Console.Write(msg + ": ");
        int m;
        if(nums.Length == 0) {
            Console.WriteLine("Error: no arguments.");
            return 0;
        }
        m = nums[0];
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] < m) m = nums[i];
        return m;
    }
   
}


// Return an object.

class Rect {
    int width;
    int height;
    public Rect(int w, int h) {
        width = w;
        height = h;
    }
    public int Area() {
        return width * height;
    }
    public void Show() {
        Console.WriteLine(width + " " + height);        
    }
    /* Return a rectangle that is a specified
    factor larger than the invoking rectangle. */
      
    public Rect Enlarge(int factor) {
        return new Rect(width * factor, height * factor);
    }


}
class ClassFactory{

     /* A class factory is a method that
    is used to construct objects of its class. */

    // Use a class factory.
    // Create a class factory for Rect.
    int a, b; // private
    public ClassFactory Factory(int i, int j)
    {
        ClassFactory t = new ClassFactory();
        t.a = i;
        t.b = j;
        Console.WriteLine("t.a and t.b: " + t.a + " " + t.b);
        return t; // return an object
    }

    public void Show()
    {
        Console.WriteLine("a and b: " + a + " " + b);
    }

    // Display a string backward.
    //Recursion
    public void DisplayRev(string str)
    {
        if (str.Length > 0)
            DisplayRev(str.Substring(1, str.Length - 1));
        else
            return;
        Console.Write(str[0]);
    }
 
}
    
// A simple demonstration that uses object initializers.
class ObjInit
{
    public int Count;
    public string Str;
}

class CallByValue {

    // Demonstrate optional arguments.
    // Once the first argument defaults, all remaining arguments must also default.
    //It is important to understand that all optional parameters must appear to the right of those that are required
    //int Sample(string name = "user", int userId) { // Error!
    static void OptArgMeth(int alpha, int beta = 10, int gamma = 20)
    {
        Console.WriteLine("Here is alpha, beta, and gamma: " + alpha + " " + beta + " " + gamma);
    }


    // Use named arguments.
    static bool IsFactor(int val, int divisor)
    {
        if ((val % divisor) == 0) return true;
        return false;
    }

    static void Main3() {
        // Let both beta and gamma default.
        OptArgMeth(1);


        Test ob = new Test();
        Test ob1 = new Test();

        int a = 15, b = 20;

        Console.WriteLine("a and b before call: " + a + " " + b);

        ob.NoChange(a, b);
        ob.Show();

        ob1.NoChange(10, 5);

        Console.WriteLine("a and b after call: " + ob.i+ " " + ob.j);

        int c = 10;

        Console.WriteLine("c before call: " + c);

        // Use ref to pass a value type by reference
        ob.Sqr(ref c); // notice the use of ref
        Console.WriteLine("c after call: " + c);

        // Use out.
       /* Of course, you are not limited to only one out parameter. A method can return as many pieces of information as necessary through out parameters. Here is an example that uses
           two out parameters. */
        // NOTE: Without Ref just objects doesnt get swapped

        int i;
        double f;
        
        i = ob.GetParts(10.125, out f);

        Console.WriteLine("i and f out return : " + i + " and" + f);

        ob.Show();

        ob1.Show();

        ob.Swap(ref ob, ref ob1);

        Console.WriteLine("a and b after swap: " + ob1.i + " " + ob1.j);

        ob.Show();

        ob1.Show();

        //Use a Variable Number of Arguments
        // The params modifier is used to declare an array parameter that will be able to receive zero or more arguments.
        int min;
        min = ob.MinVal("Here are some integers",a, b);
        Console.WriteLine("Minimum is " + min);
        // Call with 5 values.
        min = ob.MinVal("Here are some integers", 18, 23, 3, 14, 25);
        Console.WriteLine("Minimum is " + min);
        // Can call with an int array, too.
        int[] args = { 45, 67, 34, 9, 112, 8 };
        min = ob.MinVal("Here are some integers", args);
        Console.WriteLine("Minimum is " + min);
        min = ob.MinVal("Here are some integers"); // no arguments


        Rect r1 = new Rect(4, 5);
        Console.Write("Dimensions of r1: ");
        r1.Show();
        Console.WriteLine("Area of r1: " + r1.Area());

        // Create a rectangle that is twice as big as r1.
        Rect r2 = r1.Enlarge(2);

        Console.Write("Dimensions of r2: ");
        r2.Show();
        Console.WriteLine("Area of r2: " + r2.Area());

        ClassFactory obr = new ClassFactory();
        obr.Show();
        ClassFactory anotherOb = obr.Factory(100, 150);
        obr.Show();
        anotherOb.Show();


        // Construct a MyClass object by using object initializers.
        ObjInit obj = new ObjInit { Count = 100, Str = "Testing" };
        Console.WriteLine(obj.Count + " " + obj.Str);


        // Use named arguments. 
        // Call by use of named arguments.
        /*Be aware, however, that when mixing both named and positional arguments, all positional
            arguments must come before any named arguments.
         IsFactor(10, divisor: 2)*/
        if (IsFactor(val: 10, divisor: 2))
            Console.WriteLine("2 is factor of 10.");
        //Return Values from Main( )
        /*Usually, the return value from Main( ) indicates whether the program ended normally
        or due to some abnormal condition. By convention, a return value of zero usually indicates
        normal termination. All other values indicate some type of error occurred. */


        //Pass Arguments to Main( )
        //static void Main(string[ ] args)
        //static int Main(string[ ] args)
        string str = "this is string";
        obr.DisplayRev(str);
        Console.WriteLine();

    }

}

