using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class ChkNum
{
    // Return true if x is prime.
    public bool IsPrime(int x)
    {
        if (x <= 1) return false;
        for (int i = 2; i <= x / i; i++)
            if ((x % i) == 0) return false;
        return true;
    }


    // Return the least common factor.
    public int LeastComFactor(int a, int b)
    {
        int max;
        
        if (IsPrime(a) || IsPrime(b)) return 1;

        max = a < b ? a : b;
        for (int i = 2; i <= max / 2; i++)
            if (((a % i) == 0) && ((b % i) == 0)) return i;

        return 1;
    }
}


class AssignARef {
    
    int i;
    int[] nums1 = new int[10];
    int[] nums2 = new int[10];

    public void checkarraysreference()
    {
        for(i=0; i < 10; i++) nums1[i] = i;
        for(i=0; i < 10; i++) nums2[i] = -i;

        Console.Write("Here is nums1: ");
        for(i=0; i < 10; i++)
            Console.Write(nums1[i] + " ");
        Console.WriteLine();
        
        Console.Write("Here is nums2: ");
        for(i=0; i < 10; i++)
            Console.Write(nums2[i] + " ");
        Console.WriteLine();

        nums2 = nums1; // now nums2 refers to nums1

        Console.Write("Here is nums2 after assignment: ");

        for(i=0; i < 10; i++)
            Console.Write(nums2[i] + " ");
        Console.WriteLine();

        // Next, operate on nums1 array through nums2.
        nums2[3] = 99;

        Console.Write("Here is nums1 after change through nums2: ");
        for(i=0; i < 10; i++)
            Console.Write(nums1[i] + " ");
        Console.WriteLine();
    }

}


class StrOps {
    public void strmethods() {
        string str1 = "When it comes to .NET programming, C# is #1.";
        string str2 = "When it comes to .NET programming, C# is #1.";
        string str3 = "C# strings are powerful.";
        string strUp, strLow;
        int result, idx;

        Console.WriteLine("str1: " + str1);
        Console.WriteLine("Length of str1: " + str1.Length);
        
        // Create upper- and lowercase versions of str1.
        strLow = str1.ToLower(CultureInfo.CurrentCulture);
        strUp = str1.ToUpper(CultureInfo.CurrentCulture);

        Console.WriteLine("Lowercase version of str1:\n " + strLow);
        Console.WriteLine("Uppercase version of str1:\n " + strUp);
        Console.WriteLine();
        
        // Display str1, one char at a time.
        Console.WriteLine("Display str1, one char at a time.");
        for(int i=0; i < str1.Length; i++)
            Console.Write(str1[i]);
        Console.WriteLine("\n");

        // Compare strings using == and !=. These comparisons are ordinal.
        if (str1 == str2)
            Console.WriteLine("str1 == str2");
        else
            Console.WriteLine("str1 != str2");
        if (str1 == str3)
            Console.WriteLine("str1 == str3");
        else
            Console.WriteLine("str1 != str3");
        
        // This comparison is culture-sensitive.
        result = string.Compare(str1, str3, StringComparison.CurrentCulture);
        if (result == 0)
            Console.WriteLine("str1 and str3 are equal");
        else if (result < 0)
            Console.WriteLine("str1 is less than str3");
        else
            Console.WriteLine("str1 is greater than str3");
        Console.WriteLine();
        
        // Assign a new string to str2.
        str2 = "One Two Three One";
        
        // Search a string.
        idx = str2.IndexOf("One", StringComparison.Ordinal);
        Console.WriteLine("Index of first occurrence of One: " + idx);
        idx = str2.LastIndexOf("One", StringComparison.Ordinal);
        Console.WriteLine("Index of last occurrence of One: " + idx);
    }
}


class Program
    {
        static void Main1(string[] args)
        {
			Console.WriteLine("A sample C# program");
			
            // Demonstrate an @ identifier. @ can be used for regular identifiers also, if we want to use reserved words as identifiers then we can @
            int @if; // use if as an identifier
            for(@if = 0; @if < 10; @if++)
                Console.WriteLine("@if is " + @if);


            // Demonstrate Math.Sin(), Math.Cos(), and Math.Tan().
            Double theta; // angle in radians
            for (theta = 0.1; theta <= 1.0; theta = theta + 0.1)
            {
                Console.WriteLine("Sine of " + theta + " is " +
                                        Math.Sin(theta));
                Console.WriteLine("Cosine of " + theta + " is " +
                                        Math.Cos(theta));
                Console.WriteLine("Tangent of " + theta + " is " +
                                        Math.Tan(theta));
                Console.WriteLine();
            }

            // Use the decimal type to compute a discount.
            //decimal constants are followed by the m suffix

            decimal price;
            decimal discount;
            decimal discounted_price;
            // Compute discounted price.
            price = 19.95m;
            discount = 0.15m; // discount rate is 15%
            discounted_price = price - (price * discount);
            Console.WriteLine("Discounted price: $" + discounted_price);


            //there is no conversion defined between bool and integer values. For example, 1 does not convert to true, and 0 does not convert to false

            //the value 28 is substituted for {0}, and 29 is substituted for {1}.
            //Format specifier.
            Console.WriteLine("February has {0,10} or {1,5} days.", 28, 29);

            int i;
            Console.WriteLine("Value\tSquared\tCubed");
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);

            Console.WriteLine("Here is 10/3: {0:#.##}", 10.0 / 3.0);
            Console.WriteLine("{0:###,###.##}", 123456.56);

            // Literals are used to specify explicitly like 12323.09m where literal m is for decimal 
            decimal balance;
            balance = 12323.09m;
            Console.WriteLine("Current balance is {0:C}", balance);

            //hexadecimal literal must begin with 0x (a 0 followed by an x).

            //A verbatim string literal begins with an @, which is followed by a quoted string
            //only exception is that to obtain a double quote (“), you must use two double quotes in a row (“”).
            // Demonstrate verbatim string literals
            Console.WriteLine(@"This is a verbatim
     string literal
         that spans several lines.");
            Console.WriteLine(@"Programmers say, ""I like C#.""");

            //A character literal, such as 'X', represents a single letter of type char. A string containing only one letter, such as "X"

            //implicitly typed variable is declared using the keyword var, and it must be initialized
            //Implicitly Typed Arrays

            var s1 = 4.0;
            var vals = new[] { 1, 2, 3, 4, 5 };
            var multidim = new[,] { { 1.1, 2.2 }, { 3.3, 4.4 }, { 5.5, 6.6 } };

            //Once the type has been determined, the variable has a type, and this type is fixed throughout the lifetime of the variable
            // Only one implicitly typed variable can be declared at any one time like "count"
            // var s1 = 4.0, s2 = 5.0; // Error!

            int count;
            for (count = 0; count < 10; count = count + 1)
            {
                Console.WriteLine("This is count: " + count);
               /* int count; // illegal!!!
                for (count = 0; count < 2; count++)
                    Console.WriteLine("This program is in error!");*/

            }


            ChkNum prm = new ChkNum();
            Console.WriteLine(prm.IsPrime(1000));

            int a, b;
            a = 100;
            b = 10;
            Console.WriteLine("Least common factor for " +
            a + " and " + b + " is " +
            prm.LeastComFactor(a, b));

            // Arrays
            int[] sample = new int[10];

            int[] nums = { 99, 10, 100, 18, 78, 23,63, 9, 87, 49 };

            int[] numsnew = new int[] { 99, 10, 100, 18, 78, 23,63, 9, 87, 49 };

            int[] numsnew1 = new int[10] { 99, 10, 100, 18, 78, 23,63, 9, 87, 49 };

            int[,] table = new int[10, 20];
            int[, ,] multidim1 = new int[4, 10, 3];

            //Jagged Arrays : A jagged array is an array of arrays in which the length of each array can differ

            int[][] jagged = new int[3][];
            jagged[0] = new int[4];
            jagged[1] = new int[3];
            jagged[2] = new int[5];

            int[][,] jagged1 = new int[3][,];
            jagged1[0] = new int[4, 2];
            jagged1[0][1, 0] = i;

            Console.WriteLine();

            //Assigning Array References
            /*As with other objects, when you assign one array reference variable to another, you are simply making both variables refer to the same array. You are neither causing a copy of the
             * array to be created, nor are you causing the contents of one array to be copied to the other*/
            
            AssignARef Arry = new AssignARef();
            Arry.checkarraysreference();

            //Implicitly Typed Arrays for Jagged Arrays
            var jaggedarr = new[] {
                    new[] { 1, 2, 3, 4 },
                    new[] { 9, 8, 7 },
                    new[] { 11, 12, 13, 14, 15 }
            };


            //The foreach Loop
            // The foreach loop is used to cycle through the elements of a collection. A collection is a group of objects. C# defines several types of collections, of which one is an array

            foreach(int x in numsnew1)
                Console.WriteLine("Value is: " + x);

            foreach(var x in jaggedarr)
                foreach (var jj in x) 
                    Console.WriteLine("Value is: " + jj);
            
            // Strings
            
            char[] charray = { 'A', ' ', 's', 't', 'r', 'i', 'n', 'g', '.' };
            string str1 = new string(charray);
            string str2 = "Another string.";
            // the below statement is not valid
            //string str3 = new string("Names in string object");
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            //ordinal comparison = Strings can be compared based on the binary values of the characters that comprise them 
            //culture-sensitive = Strings can also be compared in a way that takes into account various cultural metrics, such as dictionary order (Culture sensitivity is especially important in applications that are being internationalized.)

            StrOps strmt = new StrOps();
            strmt.strmethods();

            // Demonstrate string arrays
            string[] str = { "This", "is", "a", "test." };


        }
    }
