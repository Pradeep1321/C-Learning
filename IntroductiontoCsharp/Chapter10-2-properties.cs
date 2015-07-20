/*Properties are similar to indexers. A property consists of a name along with get and set
accessors.The key benefit of a
property is that its name can be used in expressions and assignments like a normal variable,
but in actuality the get and set accessors are automatically invoked. */

//property does not define a storage location, it cannot be passed as a ref or out parameter to a method
//you cannot overload a property.
//a property should not alter the state of the underlying variable when the get accessor is called.
using System;

class proprty
{
    int prop;
    public proprty() { prop = 0; }
    /* This is the property that supports access to
the private instance variable prop. It
allows only positive values. */
    public int Myprop
    {
        get {
            return prop;
        }

        set
        {
            if (value >= 0) prop = value;
        }
    }

    //The accessors for an auto-implemented property have no bodies.
    //This syntax tells the compiler to automatically create a storage location (sometimes referred to as a backing field) that holds the value
    //auto-implemented properties simply let the name of the property act as a proxy for the field, itself
    public int UserCount { get; set; }
}

// Use object initializers with properties.
class objintprop
{
    // These are now properties.
    public int Count { get; set; }
    public string Str { get; set; }
}

class propdemo
{
    static void Main7()
    {
        proprty prob = new proprty();
        int value;
        prob.Myprop = 100;

        Console.WriteLine("Value of ob.MyProp: " + prob.Myprop);

        // Can't assign negative value to prop.
        Console.WriteLine("Attempting to assign -10 to prob.Myprop");
        prob.Myprop = -10;
        Console.WriteLine("Value of ob.MyProp: " + prob.Myprop);

        // Construct a MyClass object by using object initializers.
        objintprop objintprp = new objintprop { Count = 100, Str = "Testing" };
        Console.WriteLine(objintprp.Count + " " + objintprp.Str);
    }
}