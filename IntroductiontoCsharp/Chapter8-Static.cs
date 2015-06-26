using System;

/*Normally, a class member must be accessed
through an object of its class, but it is possible to create a member that can be used by itself,
without reference to a specific instance. To create such a member, precede its declaration
with the keyword static. When a member is declared static, it can be accessed before any
objects of its class are created and without reference to any object. You can declare both
methods and variables to be static. In fact, a static member cannot be accessed
through an object reference. It must be accessed through its class name. Variables declared as static are, essentially, global variables.
 If no explicit initializer is specified, it is initialized to zero for numeric types, null in the case of reference types, or
false for variables of type bool. Thus, a static variable always has a value*/

/*
There are several restrictions that apply to static methods:
• A static method does not have a this reference. This is because a static method does
not execute relative to any object.
• A static method can directly call only other static methods of its class. It cannot
directly call an instance method of its class. The reason is that instance methods
operate on specific objects, but a static method is not called on an object. Thus, on
what object would the instance method operate?
• A similar restriction applies to static data. A static metho
 * 
 * d can directly access only
other static data defined by its class. It cannot operate on an instance variable of its
class because there is no object to operate on.
 * static constructors cannot have access modifiers
*/


class Nstatic
{
    // A non-static method.
    void NonStaticMeth()
    {
        Console.WriteLine("Inside NonStaticMeth().");
    }

    /* Can call a non-static method through an
        object reference from within a static method. */

    public static void staticMeth(Nstatic ob)
    {
        ob.NonStaticMeth(); // this is OK
    }

}

class CountInst
{
    static int count = 0;
    // Increment count when object is created.
    public CountInst()
    {
        count++;
    }

    // Decrement count when object is destroyed.
    ~CountInst()
    {
        count--;
    }
    public static int GetCount()
    {
        return count;
    }
}

// Use a static constructor.
/*
 * A static constructor is typically used to
initialize features that apply to a class rather than an instance. Thus, it is used to initialize
aspects of a class before any objects of the class are created
 * */

class Cons
{
    public static int alpha;
    public int beta;
    // A static constructor.
    static Cons()
    {
        alpha = 99;
        Console.WriteLine("Inside static constructor.");
    }
    // An instance constructor.
    public Cons()
    {
        beta = 100;
        Console.WriteLine("Inside instance constructor.");
    }
}

/*
 * Static Classes
 * First, no object of
a static class can be created. Second, a static class must contain only static members
 * a static class is required when creating an extension method.
 * a static class is used to contain a collection of related static methods
 * Although a static class cannot have an instance constructor, it can have a static constructor.
*/

class CountDemo
{
    static void Main4()
    {
        CountInst ob;
        for (int i = 0; i < 10; i++)
        {
            ob = new CountInst();
            Console.WriteLine("Current count: " + CountInst.GetCount());
        }

        
        Cons con = new Cons();
        Console.WriteLine("Cons.alpha: " + Cons.alpha);
        Console.WriteLine(" con.beta: " + con.beta);


    }
}
