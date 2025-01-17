using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;

namespace ProblemsOnFileHandling
{
    internal class Input
    {  
        public void read()
        {
            //Write a program that reads a text file (input.txt) and prints its content to the console.
            string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/ProblemsOnFileHandling/input.txt";
            //File.Create(path);
            File.WriteAllText(path ,"Hello Welcome to my world \n Here you can write all ur imaginations");
            Console.WriteLine("this is the data from the input.txt file");
            string readtext = File.ReadAllText(path);
            Console.WriteLine(readtext);
        }

        public void write() 
        {
            //Write a program that takes user input and writes it to a text file(output.txt).
            string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/ProblemsOnFileHandling/output.txt";
            //File.Create(path);
            using (StreamWriter write = new StreamWriter(path))
            {
                Console.WriteLine("Enter the data you want to store in the file");
                write.WriteLine(Console.ReadLine());
            }
            Console.WriteLine("Data successfully added in the file");

        }

        public void Append()
        {
            //Write a program that appends text to an existing file(log.txt)
            string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/ProblemsOnFileHandling/output.txt";
            using (StreamWriter write = new StreamWriter(path,append:true))
            {
                Console.WriteLine("Enter the data you want to store in the file");
                write.WriteLine(Console.ReadLine());
            }
            Console.WriteLine("Data successfully added in the file");

        }

        public void Count()
        {
            string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/ProblemsOnFileHandling/output.txt";
            string text = File.ReadAllText(path);
            string[] word = text.Split(new char[] {' ','\n','\t','\r'},StringSplitOptions.RemoveEmptyEntries);
            int count = word.Length;
            Console.WriteLine($"The file contains {count} word");
        }

        public void Search()
        {   //Write a program that searches for a specific word or phrase in a text file(search.txt) and prints the line numbers where the word or phrase appears.
            string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/ProblemsOnFileHandling/output.txt";
            Console.WriteLine("Enter the word or phrase you want to find in the file");
            string WordToSearch = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(WordToSearch))
            {
                Console.WriteLine("Error: You must enter a valid word or phrase to search.");
                return;
            }
            string[] text = File.ReadAllLines(path);
            bool found = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].IndexOf(WordToSearch, StringComparison.OrdinalIgnoreCase)>=0)
                {
                    Console.WriteLine($"Found on line {i + 1}: {text[i]}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine($"The word or phrase '{WordToSearch}' was not found in the file.");
            }

        }

        public void RemoveDuplicate()
        {
            //Write a program that removes duplic
            string inputPath = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/ProblemsOnFileHandling/output.txt";
            string outputPath = "C:/Users/ADMIN/source/repos/ParkingmanagementSystem/ProblemsOnFileHandling/WthoutDuplicate.txt";
            //File.Create(outputPath);
            string[] lines = File.ReadAllLines(inputPath);
            Console.WriteLine("The data in the file before removing duplicate values");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            //HashSet can move duplicate within the lines but can not remove the duplicate words that appear within he same line
            //HashSet<string> found = new HashSet<string>(lines);
            HashSet<string> uniquevalue = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            List<string> processedLine = new List<string>();
            foreach(string line in lines)
            {
                string[] words = line.Split(' ',(char) StringSplitOptions.RemoveEmptyEntries);
                List<string> FilteredWords = new List<string>();
                foreach(string word in words)
                {
                    if (uniquevalue.Add(word))
                    {
                        FilteredWords.Add(word);
                    }
                }
                
                processedLine.Add(String.Join(" ", FilteredWords));
            }
            Console.WriteLine("Removed all duplicate values");
            File.WriteAllLines(outputPath, processedLine);
            foreach (string line in processedLine)
            {
                Console.WriteLine(line);
            }

        }
    }
}
