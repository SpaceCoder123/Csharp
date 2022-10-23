using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program // this is the class in the program
    {
        static void greet() // this is a static method which means objects cannot be created using static method
        {
            Console.WriteLine("Good morning! ");
            // void doesn't return anything 
        }

        static void GreetWithName(String name)
        {
            Console.WriteLine("Good morning " + name);
        }


        static double Average(double a, double b, double c) // now this will return Average of three numbers
        {
            return (a + b + c) / 3;
        }

        static double Average(double a, double b)
        {
            Console.WriteLine("This is an overloaded function of average");
            return (a + b) / 2;
        }


        static void Main(string[] args) // this is a static method which cannot be made into an object
        {
            // int mohan = 34; // Integer variable

            /* Data types in C#;
             * Int --> 4 bytes
             * Long --> 8 bytes, it will take a big integer
             * Floating point number --> 4 bytes
             * Double --> 8 bytes and gives 15 digit precision
       
             * Character - Char a = 'a'; - 2 bits
             * Boolean - bool isGreat = true; it will consume 1 bit // negligible memory
             * string inp = "Mohan"; -- 2 bytes per character
             */
            // This is a comment
            //Console.WriteLine("Hello world"); // ; indicates the line has been terminated
            //Console.Write("Hello C# "); // Write will execute the command in the next line
            //Console.WriteLine("Hello world"); // this will write the string inside the terminal 
            //Console.WriteLine("I like C# and this is the number " + mohan);

            //string inp = Console.ReadLine();
            //Console.WriteLine(inp);


            // Console.ReadLine(); // this will wait for the terminal for another command and also will be 
            // helpful in reading the output of the current program 


            // comments are ignored while running

            //int a = 34;
            //float b = 34.4f; //  this is called error,you need to declare f after declaring type casting 
            //double c =  34.4;
            //char d = 'a';
            //Console.WriteLine(a + b + c);
            //Console.WriteLine("Note character is always incoded in single qoutes '"+d+"'");

            // type casting, the process of conversion of one datatype to another datatype 



            // there are two types of type casting 
            // 1 Implicit typecasting
            // char to int to long to float to double
            // this method has been declared by C# itself not by the user

            // int x = 3;
            // double y = x;
            // int z = 'y';
            // Console.WriteLine(y);
            // Console.WriteLine(z); // this will return the ascii value of the code
            // Console.WriteLine(y.GetType());
            // Console.ReadLine();

            // 2. Explicit typecasting 
            // this is method to convert double into an integer
            // this means the user will try to change the character type by giving the name of the integer
            //int x = (int)3.23; 
            //Console.WriteLine(x);
            //Console.WriteLine(x.GetType());
            //Console.ReadLine();

            //Console.WriteLine("How many candies do you want! ");
            //String can = Console.ReadLine(); // since the value entered is a string then it will concatenate with 3 return
            //                                 // (if 8 is an input)
            //                                 // 83 in line-77
            //// Console.WriteLine("Ok, you get a total of 8 candies " + (can+ 3) + " !"); // this will convert to a string



            //Console.WriteLine("Ok, you get a total of 8 candies "+(Convert.ToInt64(can)+3)+" !"); // this will add the input and 3 and 
            // will return 11 ( if 8 is an input ) in line 81
            // 
            // whatever character you give, will be stored in the memory in 0s and 1s


            // String methods in C#
            //string hello = "Hello World, this is a course given by code with harry";
            //Console.WriteLine(hello.Length); // this returns the length of the array
            //Console.WriteLine(hello.ToUpper()); // this will convert all the items or characters in the string into upper case
            //Console.WriteLine(hello.ToLower()); // this will convert all the items or characters in the string into lower case
            //Console.WriteLine(string.Concat(hello, ", this is concatenation as per code base"));


            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Hello, your name is {name}, and  you will get {candies} candies"); // this is clear example of a placeholder
            //Console.WriteLine(name[0]); // returns the first character of a string 
            //Console.WriteLine(hello.IndexOf("World")); // this will return the index of starting character in the substring 
            //Console.WriteLine(hello.Substring(5)); // this returns a substring of the hello string 

            // \n will leave an extra line in the string 
            // \t will return a tab space betweent the strings

            //int age = 34;


            //Console.WriteLine("Enter your age");
            //string age1 = Console.ReadLine();
            //int age2 = Convert.ToInt32(age1);
            //bool isBanned = false;


            //if (age2< 30)
            //{
            //    Console.WriteLine("Your age is less than 34 ");
            //    isBanned = true;
            //}
            //else if (age2 == 34 || isBanned)
            //{
            //    Console.WriteLine("The age is equal to 34, but you are banned");
            //}
            //else
            //{
            //    Console.WriteLine("Your age is greater than 34 you are not banned ");
            //}

            //int age = 22;
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for one more year");
            //        break;
            //    case 22:
            //        Console.WriteLine("You have cleared the age criteria");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy!");
            //        break;
            //}
            //int i = 5;
            ////while(i > 0)
            ////{
            ////    Console.WriteLine(i);
            ////    i--;
            ////}

            //for (int j = 0; j < i; j++)
            //{
            //    Console.WriteLine(j);
            //}
            greet();
            GreetWithName("Mohan");
            double AverageNumber = Average(1, 2, 4);
            double AverageNumber2 = Average(1, 2);


            Console.WriteLine(AverageNumber);
            Console.WriteLine(AverageNumber2);
            // note the name of the methods are same and therefore it is called method-overloading 

            // the inputs are different and therefore the functions chosen are different 

            Console.ReadLine();



             


        }
    }
}
