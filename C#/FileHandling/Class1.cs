using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Class1 { 
        // in this video we will examine directory and directory info classes 
        // they are used to perform various action such as create, move, delete and enumerate
        public void createDirectory()
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\C#\FileHandling\newFolder");
            directory.Create(); // creates a folder
            directory.MoveTo(@"D:\C#\MovedFolder\New"); // moves the file to different directory
            //directory.Delete(true); // deletes the directory that is given in directory info
            Console.ReadKey();
        }
        
    }
}
