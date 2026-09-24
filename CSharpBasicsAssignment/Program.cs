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
        


    
        public struct Point
        {
            public int x;
            public int y;
        }


    



    static void RunValueVsReferenceDemo()
    {
    #region  struct copy semantics
    Point p1 = new Point{x = 1 , y = 2};
    Point p2 = p1;

    p2.x = 99 ;

    Console.WriteLine("\n==========Struct Copy Semantics\n==========");
    Console.WriteLine($"Value Of x in p1: {p1.x}");
    Console.WriteLine($"Value Of x in p2: {p2.x} ");

    // the outputs will be different because the struct is a value type so when i created p1 , it takes a space in the stack and will have x =1 , y = 2 
    // and when p2 created , it will take another space in the stack and have the same value of field in p1
    // and when we changed x in p2 it will not change in the p1 so there wll print different valus of x ,but y still the same because it did not changed



    #endregion
    
    #region class reference semantics 
        Order o1 = new Order
        {
            OrderId = 101,
            CustomerName = "Ahmed",
            Quantity = 3,
            UnitPrice = 100m,
            TotalPrice = 0m,
            IsPaid = false,
            DiscountPercent = 10,
            ShippingCity = "Cairo",
            Priority = 'H',
            ItemCode = 123456789L
        };

        o1.CalculateTotal();

        Order o2 = o1;

        o2.IsPaid = true;


        object boxedOrder = o1;
        Order o3 = (Order)boxedOrder;
        Console.WriteLine(ReferenceEquals(o1,o3));

        Console.WriteLine($"o1.IsPaid: {o1.IsPaid}");
        Console.WriteLine($"o2.IsPaid: {o2.IsPaid}");

        
        o2.PrintSummary();
    #endregion
    
    #region Finish Part C
    // order is a reference type, so o1 stores a reference to an Order object
    // when I assign o2 = o1, both variables refer to the same Order object in the heap
    // therefore, changing a field through o2 also changes the same object seen through o1
    // the object variable boxedOrder also store a reference to the same Order object
    // unboxed it back to Order gives another reference to the exact same instance
            
    #endregion
    
    }
    
    
    #region Scope
    static int fieldNumber = 10;

    static void RunScopeDemo()
    {
    for (int i = 0; i < 5; i++)
        {
        int insideLoop = i * 10;

        Console.WriteLine(insideLoop);
        }

    // Console.WriteLine(i)
    // Compile error: i is declared inside the for-loop
    // so its scope end when the loop end

    // Console.WriteLine(insideLoop)
    // Compile error: insideLoop is declared inside the loop body
    // so it can only be accessed inside that block
    }
    
    
        static void RunMethodScopeDemo()
    {   
    int localNumber = 50;

    Console.WriteLine($"Local number: {localNumber}");
    }
   
    #endregion
    
    
    #region  Composite
    static void RunCompoundOperatorsDemo()
    {
        int total = 100;

        total += 10;
        Console.WriteLine(total);

        total -= 20;
        Console.WriteLine(total);

        total *= 2;
        Console.WriteLine(total);

        total /= 5;
        Console.WriteLine(total);

        total %= 7;
        Console.WriteLine(total);

    // total += 10; is equivalent to: total = total + 10;
    }
    #endregion
    
    
    #region  Bitwise operators
    static void RunBitwiseOperatorsDemo()
    {
    int a = 12;
    int b = 10;

        Console.WriteLine($"a & b = {a & b}");
        Console.WriteLine($"a | b = {a | b}");
        Console.WriteLine($"a ^ b = {a ^ b}");

        // a = 1100
        // b = 1010
        //
        // a & b = 1000 = 8
        // a | b = 1110 = 14
        // a ^ b = 0110 = 6

        // & checks bits and && checks logical conditions; with &&, if the left
        // operand is false, the right operand is not evaluated, unlike bitwise &.
    }
    #endregion
    
    }

    



    


