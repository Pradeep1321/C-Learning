//Virtual Methods and Overriding
/* A virtual method is a method that is declared as virtual in a base class . if a base class
contains a virtual method and classes are derived from that base class, then when different
types of objects are referred to through a base class reference, different versions of the
virtual method can be executed. When a virtual method is redefined by a derived class, the override modifier
is used. When overriding a method, the name, return type, and signature of the overriding
method must be the same as the virtual method that is being overridden. Also, a virtual
method cannot be specified as static or abstract .Dynamic method dispatch is the mechanism by which a call to an overridden
method is resolved at runtime, rather than compile time.
 */
// One other point: Properties can also be modified by the virtual keyword and overridden using override. The same is true for indexers.

 // Demonstrate a virtual method.
using System;
class Base {
    // Create virtual method in the base class.
    public virtual void Who() {
        Console.WriteLine("Who() in Base");
    }
}

class Derived1 : Base
{
    // Override Who() in a derived class.
    public override void Who()
    {
        Console.WriteLine("Who() in Derived1");
    }
}

class Derived2 : Base
{
    // Override Who() again in another derived class.
    public override void Who()
    {
        Console.WriteLine("Who() in Derived2");
    }
}

class Derived3 : Base
{
    // This class does not override Who().
}

class Derived4 : Derived1
{
    // This class also does not override Who().
}
class Derived5 : Derived4
{
    // This class does not override Who().
}

class OverrideDemo
{
    static void Main14()
    {
        Base baseOb = new Base();
        Derived1 dOb1 = new Derived1();
        Derived2 dOb2 = new Derived2();
        Derived3 dOb3 = new Derived3();

        Base baseRef; // a base class reference
        baseRef = baseOb;
        baseRef.Who();
        baseRef = dOb1;
        baseRef.Who();
        baseRef = dOb2;
        baseRef.Who();
        baseRef = dOb3;
        baseRef.Who();

        Derived5 dOb = new Derived5();
        
        baseRef = dOb;
        baseRef.Who(); // calls Derived1's Who()

    }
}
