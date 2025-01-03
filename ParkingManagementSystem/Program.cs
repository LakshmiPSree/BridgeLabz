using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    internal class Program
    {
        public class Vehicle
        {
            private int numberPlate;
            private string make;
            private string color;
            private string owner;

            public int NumberPlate
            {
                get { return numberPlate; }
                set { numberPlate = value; }
            }
            public string Make
            {
                get { return make; }
                set { make = value; }
            }
            public string Color
            {
                get { return color; }
                set { color = value; }
            }
            public string Owner
            {
                get { return owner; }
                set { owner = value; }
            }

            public Vehicle(int numberPlate, string make, string color, string owner)
            {
                this.numberPlate = numberPlate;
                this.make = make;
                this.color = color;
                this.owner = owner;
            }
            public virtual void Display()
            {
                Console.WriteLine($"The owner of the vehicle is {owner} and the number plate is {numberPlate} ,make is {make},color is {color}");
            }
        }

        class Car : Vehicle
        {
            public string Carmodel {  get; set; }

            public Car(int numberPlate, string make, string color, string owner,string Carmodel):base(numberPlate, make, color, owner)
            {
                this.Carmodel = Carmodel;
            }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"the model is {Carmodel}");
            }
        }

        public class ParkingLot
        {
            public int Id { get; set; }
            public string location { get; set; }
            public bool IsOccupied { get; set; }
            public Vehicle OccupyingVehicle { get; set; }

            public ParkingLot(int id, string location)
            {
                this.Id = id;
                this.location = location;
                IsOccupied = false;
                OccupyingVehicle = null;

            }

            public void Parking(Vehicle vehicle)
            {
                if (IsOccupied == false)
                {
                    IsOccupied = true;
                    OccupyingVehicle = vehicle;
                    Console.WriteLine($"Vehicle with id {Id} is parked in this {location} location");
                }
                else
                {
                    Console.WriteLine($"You cant park the vehicle as it is occupied");
                }
            }

            public void VacateSlot(Vehicle vehicle)
            {
                if (IsOccupied)
                {
                    IsOccupied = false;
                    OccupyingVehicle = null;
                    Console.WriteLine($"Vehicle with id {Id} is leaving {location} location");
                }
                else
                {
                    Console.WriteLine($"{Id} spot is already empty");
                }
            }
        }

            public class Payment{   
                public DateTime EntryTime { get; set; }
                public DateTime ExitTime { get; set; }
                public Vehicle Vehicle { get; set; }
                public ParkingLot Parking { get; set; }
                 
                public Payment(Vehicle vehicle,ParkingLot parking)
                {
                    this.Vehicle = vehicle;
                    this.Parking = parking;
                    EntryTime =DateTime.Now;
                }  
                
                public double  CalculateCharges()
                {
                    double ParkingDuration = (ExitTime - EntryTime).TotalHours;
                    return ParkingDuration*500;// assuming 500 rs per hour
                }
            }
        

        static void Main(string[] args) {
            ParkingLot spot1 = new ParkingLot(1, "A1");
            ParkingLot spot2 = new ParkingLot(2, "b1");
            Car car1 = new Car(101, "london", "white", "varun", "Tata");
            Car car2 = new Car(102, "India", "grey", "piyush", "suzuki");
            Car car3 = new Car(103, "germany", "black", "Aditya", "Nano");

            spot1.Parking(car1);
            spot2.Parking(car2);
            spot2.Parking(car3);

            car1.Display();
            car2.Display();
            car3.Display();

            Payment transaction = new Payment(car1, spot1);
            System.Threading.Thread.Sleep(1000);
            transaction.ExitTime = DateTime.Now;
            Console.WriteLine($"Parking charges for {car1.NumberPlate} is Rs{transaction.CalculateCharges()}");

            spot1.VacateSlot(car2);







        }

    }
}
