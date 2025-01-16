using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIo
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/FileIo/Example.txt";
            //string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/FileIo/csvExample.csv";
            if (File.Exists(path))
            {
                Console.WriteLine("File Already exists");
                //File.Delete(path);
                string readedtext = File.ReadAllText(path);
                Console.WriteLine(readedtext);
            }
            else
            {
                File.Create(path).Close();
                Console.WriteLine("File does not already exist so we created the file");
            }
            using (StreamWriter write = new StreamWriter(path, append: true))
            {
                write.WriteLine("Hello,Entering data to the file");
            }
            Console.WriteLine("Data Entered in the file");
            // If u want to delete the data in the file ,only keeping the file u can overwrite with an empty string
            //File.WriteAllText(path, string.Empty);
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();
            */

            //csvPractice csvPractice = new csvPractice();
            //csvPractice.Problem();

            JsonPractice jsonPractice = new JsonPractice();
            jsonPractice.Problem();
        }
    }
}
