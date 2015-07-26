/*
C# defines one special class called object that is an implicit base class of all other classes and
for all other types (including the value types). In other words, all other types are derived
from object. 

The object class defines the methods shown in Table 11-1, which means that they are
available in every object.
Method                                                    Purpose           
public virtual bool Equals(object obj)                  Determines whether the invoking object is the
                                                        same as the one referred to by obj.
public static bool Equals(object objA, object objB)     Determines whether objA is the same as objB.
                                                        protected virtual Finalize( ) Performs shutdown actions prior to garbage
                                                        collection. In C#, Finalize( ) is accessed through
                                                        a destructor.
public virtual int GetHashCode( )                       Returns the hash code associated with the
                                                        invoking object.
public Type GetType( )                                  Obtains the type of an object at runtime.
                                                        protected object MemberwiseClone( ) Makes a “shallow copy” of the object. This
                                                        is one in which the members are copied, but
                                                        objects referred to by members are not.
public static bool ReferenceEquals(object objA,object objB)       Determines whether objA and objB refer to the same object
public virtual string ToString( )                       Returns a string that describes the object.

 * 
 * 
 * 
*/

// Demonstrate ToString()
using System;
class MyClass1
{
    static int count = 0;
    int id;
    public MyClass1()
    {
        id = count;
        count++;
    }
    public override string ToString()
    {
        return "MyClass object #" + id;
    }
}
class Test1
{
    static void Main()
    {
        MyClass1 ob1 = new MyClass1();
        MyClass1 ob2 = new MyClass1();
        MyClass1 ob3 = new MyClass1();
        Console.WriteLine(ob1);
        Console.WriteLine(ob2);
        Console.WriteLine(ob3);
    }
}
