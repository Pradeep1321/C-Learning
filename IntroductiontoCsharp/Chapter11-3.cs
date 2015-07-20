// A base class reference can refer to a derived class object.
using System;

class X {
    public int a;
    public X(int i) {
        a = i;
    }
}

class Y : X {
    public int b;
    public Y(int i, int j) : base(j) {
        b = i;
    }
}

class BaseRef {
    static void Main12() {
        X x = new X(10);
        X x2;
        Y y = new Y(5, 6);
        x2 = x; // OK, both of same type
        Console.WriteLine("x2.a: " + x2.a);
        x2 = y; // OK because Y is derived from X
        Console.WriteLine("x2.a: " + x2.a);
        //Console.WriteLine("x2.a: " + x2.b);

        // X references know only about X members
        x2.a = 19; // OK
        // x2.b = 27; // Error, X doesn't have a b member
        Console.WriteLine("x2.a: " + x2.a);
    }
}
