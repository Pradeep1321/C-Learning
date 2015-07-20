// Using base to overcome name hiding.
using System;

class AA
{
    public int i = 0;

    // Show() in A
    public void Show()
    {
        Console.WriteLine("i in base class: " + i);
    }

}

// Create a derived class.
class BB : AA
{
    new int i; // this i hides the i in AA
    public BB(int a, int b)
    {
        base.i = a; // this uncovers the i in AA
        i = b; // i in B
    }
    new public void Show()
    {
        base.Show(); // this calls Show() in A
        // This displays the i in A.
        //Console.WriteLine("i in base class: " + base.i);
        // This displays the i in B.
        Console.WriteLine("i in derived class: " + i);
    }
}

class UncoverName
{
    static void Main11()
    {
        BB obBB = new BB(1, 2);
        obBB.Show();
    }
}