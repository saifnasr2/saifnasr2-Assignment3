//.csproj -> File which contains the config and settings of the project(ProjectFile)
//Program.cs -> File where you write the code
// /bin & /obj -> Folders Created When the solution build 
// This project uses .slnx format
// Advantage Of .sln foramt -> Performance -> .sln is optimized for fast loading of large solutions


using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBasicsAssignment; // It removes the level of indentation to reduce nesting and improve readability(make the file easier to scan)
internal class Program
{
    
    static void Main(string[] args)
    {
        
        RunTypesDemo();
    }

    static void RunTypesDemo()
    {
    
        #region Declare a variable of every type
            // Declare The Variables
            int intNum = 10;
            long longNum = 109203984759230284;
            double doubleNum = 10.5;
            decimal decimalNum = 10.2M;
            bool boolVar = false;
            char charVar = 's';
            string stringVar = "Saif";
            var anyThing = 66;
            
            // Print Their Values and RunTimeType
            Console.WriteLine("=====integer type=====");
            Console.WriteLine(intNum);
            Console.WriteLine(intNum.GetType());
            
            Console.WriteLine("\n=====long type=====");
            Console.WriteLine(longNum);
            Console.WriteLine(longNum.GetType());

            Console.WriteLine("\n=====double type=====");
            Console.WriteLine(doubleNum);
            Console.WriteLine(doubleNum.GetType());

            Console.WriteLine("\n=====decimal type=====");
            Console.WriteLine(decimalNum);
            Console.WriteLine(decimalNum.GetType());
            
            Console.WriteLine("\n=====bool type=====");
            Console.WriteLine(boolVar);
            Console.WriteLine(boolVar.GetType());
            
            Console.WriteLine("\n=====char type=====");
            Console.WriteLine(charVar);
            Console.WriteLine(charVar.GetType());
            
            Console.WriteLine("\n=====string type=====");
            Console.WriteLine(stringVar);
            Console.WriteLine(stringVar.GetType());
            
            Console.WriteLine("\n=====var type=====");
            Console.WriteLine(anyThing);
            Console.WriteLine(anyThing.GetType());
        #endregion

        #region Implicit and Explicit Conversion
        // Implicit Conversion
        long longNum2 = intNum; //long can represent integer number so cast here is not required
        int charToInt = charVar; // int can represent the chars in ASCII Style
        
        Console.WriteLine("\n==========Implicit Conversion==========");
        Console.WriteLine(longNum2);
        Console.WriteLine(charToInt);


        // Explicit Conversion
        int intNum2 = (int) doubleNum; // Truncation -> it just remove the decimal part from the number and do not rounded it to the nearly number
        int intNum3 = Convert.ToInt32(doubleNum); // Rounded -> it rounded the number of the nearly number of it

        Console.WriteLine("\n==========Explicit Conversion==========");
        Console.WriteLine(intNum2);
        Console.WriteLine(intNum3);



        // The Integer Division Trap
        int divisionIntNum = 5/2;
        double divisionDoubleNum =5.0/2;
        //The Differnce -> The int removes the decimal part so the output must be 2 ,but the double will not remove it so the output must be 2.5

        Console.WriteLine("\n==========The Integer Division Trap==========");
        Console.WriteLine(divisionIntNum);
        Console.WriteLine(divisionDoubleNum);



        // Boxing & Unboxing
        Console.WriteLine("\n==========Boxing And Unboxing==========");

        int n = 5;
        object boxed = n; // Now boxed is a reference in the stack and have the address of the value of n in the heap
        Console.WriteLine($"\nBoxed Value is:{boxed}");

        int unboxed = (int) boxed; // Now unboxed take the value which boxed ref to and store it in the stack
        Console.WriteLine($"Unboxed Value is:{unboxed}\n"); 


        // Parse And TryParse
        int parsedGoodString = int.Parse("42");
        Console.WriteLine($"Good Parsing and the value is: {parsedGoodString}\n");    


        int succeededParsing;
        bool parseSucceeded = int.TryParse("abc" ,out succeededParsing); // TryParse checks the value if it can convert or no , if it can it will return true and store the value in the out , else: it will return false without throwing an exception
        

        if (parseSucceeded)
        {
            Console.WriteLine($"Parsed value: {succeededParsing}");
        }
        else
        {
            Console.WriteLine("Parsing failed. The input is not a valid integer.");
        }
        // Float To Decimal
        float floatNum = 2.384f;
        //decimal decimalNum2 = floatNum; -> it refuses the implicit conversion because float uses the base2 representation ,but decimal uses base10 representation
        decimal decimalNum2 = (decimal) floatNum;

        
        #endregion
    
    


        
    }   


}

    


