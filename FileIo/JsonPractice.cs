using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileIo
{
    internal class JsonPractice
    {
        public class Record
        {
            public string Name { get; set; }
            public long PhoneNumber { get; set; }
            public string Address { get; set; }
            public Record(string name, long num, string add)
            {
                this.Name = name;
                this.PhoneNumber = num;
                this.Address = add;
            }

        }
        
        public void Problem()
        {
            string path = "C:/Users/ADMIN/source/repos/ParkingManagementSystem/FileIo/JsonFile.json";
            //File.Create(path);

            var List = new List<Record>()
            {
                new Record("Lakshmi",2457896325,"New Panvel"),
                new Record("Kiran",2589641236,"Moorkanad")
            };
            //string json = JsonConvert.SerializeObject(List, Formatting.Indented);
            //File.WriteAllText(path, json);
            //Console.WriteLine("Data successfully added to json file");

            //reading data from the file
            string readJson= File.ReadAllText(path);
            var Decentralizeddata = JsonConvert.DeserializeObject<List<Record>>(readJson);
            foreach(var  record in Decentralizeddata) {
                Console.WriteLine($"Name: {record.Name} and Phone Number:{record.PhoneNumber} and Address: {record.Address}");
            }
        }
    }
}
