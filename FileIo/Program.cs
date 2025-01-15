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
        {
            string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/FileIo/Example.txt";
            //string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/FileIo/csvExample.csv";
            if (File.Exists(path))
            {
                Console.WriteLine("File Already exists so deleting the file");
                File.Delete(path);
            }
            else
            {
                File.Create(path).Close();
                Console.WriteLine("File does not already exist so we created the file");
            }
            Console.WriteLine("Press any key to close the window");
            Console.ReadKey();
        }
    }
}
