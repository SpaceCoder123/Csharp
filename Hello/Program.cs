using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program // this is the class in the program
    {
        static void Main(string[] args) // this is a static method which cannot be made into an object
        {
            int mohan = 34; // Integer variable

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
            Console.ReadLine();

        }
    }
}
