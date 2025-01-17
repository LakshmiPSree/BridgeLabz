using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemsOnFileHandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a text file (input.txt) and prints its content to the console.
            Input input = new Input();
            //input.read();

            //Write a program that takes user input and writes it to a text file(output.txt).
            //input.write();

            //Write a program that appends text to an existing file(output.txt).
            //input.Append();
            //Write a program that counts the number of words in a text file(output.txt).
            //input.Count();
            //Write a program that searches for a specific word or phrase in a text file(output.txt) and prints the line numbers where the word or phrase appears.
            //    input.Search();
            //    //Write a program that removes duplic
               input.RemoveDuplicate();
        }
    }
}
