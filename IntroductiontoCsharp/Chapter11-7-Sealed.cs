/*
To prevent a class from being inherited, precede its declaration with sealed. As you
might expect, it is illegal to declare a class as both abstract and sealed because an abstract
class is incomplete by itself and relies upon its derived classes to provide complete
implementations.

*/

class B1
{
    public virtual void MyMethod() { /* ... */ }
}
class D1 : B1
{
    // This seals MyMethod() and prevents further overrides.
    sealed public override void MyMethod() { /* ... */ }
}
class X1 : D1
{
    // Error! MyMethod() is sealed!
    //public override void MyMethod() { /* ... */ }
}