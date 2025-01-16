using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace FileIo
{
    internal class csvPractice
    {
        public class Record
        {   public string Name { get; set; }
            public long PhoneNumber { get; set; }
            public string Address { get; set; }
            public Record(string name,long num,string add) {
                this.Name = name;   
                this.PhoneNumber = num;
                this.Address = add;
            }
            // Parameterless constructor (required for CsvHelper to instantiate objects)
            public Record() { }

        }
        public void Problem()
        {
            string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/FileIo/csvFile.csv";
            //File.Create(path);
            //Console.WriteLine("Created file");
            var list = new List<Record>()
            {
                new Record("Lakshmi",9152486314,"New Panvel"),
                new Record("Kiran",9153698745,"Moorkanadu")
            };
            //Entering Data into the file
            using (var writer = new StreamWriter(path))
            {   
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(list);
                }
                Console.WriteLine("Data successfully Added");
            }
            //Reading data from the file
            using (var reader = new StreamReader(path)) 
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var DataFromCsv = csv.GetRecords<Record>();
                    foreach (var record in DataFromCsv)
                    {
                        Console.WriteLine($"Name: {record.Name} and Phone Number:{record.PhoneNumber} and Address: {record.Address}");
                    }
                }
            
            }
        }
    }
}
