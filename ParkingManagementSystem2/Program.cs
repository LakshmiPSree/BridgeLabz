using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ParkingManagementSystem.Program;

namespace ParkingManagementSystem
{
    internal class Program
    {
        public class Car
        {
            private int numberPlate;
            private string make;
            private string color;
            private string owner;
            private string model;
            private DateTime parkingtime;

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
            public DateTime Parkingtime
            {
                get { return parkingtime; }
                set { parkingtime = value; }
            }
            public string CarModel
            {
                get { return model; }
                set { model = value; }
            }
            public Car(int numberPlate, string make, string color, string owner,DateTime parking, string carmodel)
            {
                this.numberPlate = numberPlate;
                this.make = make;
                this.color = color;
                this.owner = owner;
                this.parkingtime = parking;
                this.model = carmodel;
            }
            public virtual void Display()
            {
                Console.WriteLine($"The owner of the vehicle is {owner} and the number plate is {numberPlate} ,make is {make},color is {color},model is {model}");
            }
        }
        public class ParkingLot
        {
             public List<Car> parkingLots = new List<Car>();
            public int Id = 1;

            const int TotalCapacity = 100;
            public int AvailableSlot()
            {
                return (TotalCapacity - parkingLots.Count);
            }
            public bool IsFull()
            {
                return TotalCapacity <= parkingLots.Count;
            }
            public bool IsEmpty()
            {
                return parkingLots.Count == 0;
            }
            public void Parking(Car car)
            {
                if (!IsFull())
                {
                    parkingLots.Add(car);
                    Console.WriteLine($"Car with numberplate {car.NumberPlate} is parked in this A{Id} location");

                    Id++;
                }
                else
                {
                    Console.WriteLine($"You cant park the vehicle as it is occupied");
                }
            }

            public void VacateSlot(Car car)
            {   
                if (IsEmpty())
                {
                    Console.WriteLine("Already the slot is empty");
                }
                else
                {
                    parkingLots.Remove(car);
                    Console.WriteLine($"car with numberplate {car.NumberPlate} is leaving  location");
                }
            }
            public double CalculateCharges(Car car)
            {
                double ParkingDuration = (DateTime.Now - car.Parkingtime).TotalHours;
                return ParkingDuration * 500;// assuming 500 rs per hour
            }
        }

        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot();
            Console.WriteLine("Welcome to the parking system");
            while (true)
            {

                Console.WriteLine("*******************Menu***************************");
                Console.WriteLine("1.Check whether the slot is empty");
                Console.WriteLine("2.Park the car");
                Console.WriteLine("3.Calculate the parking charges");
                Console.WriteLine("4.Unpark the car");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Checking whether the slot is empty or not ");
                        if (parkingLot.IsFull())
                        {
                            Console.WriteLine("no slot available");
                        }
                        else
                        {
                            Console.WriteLine($"Available slot are {parkingLot.AvailableSlot()}");
                        }
                        break;

                    case 2:
                        if (parkingLot.IsFull())
                        {
                            Console.WriteLine("you cant park the vehicle");
                            return;
                        }
                        Console.WriteLine("Enter the numberPlate number");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the make ");
                        string make = Console.ReadLine();
                        Console.WriteLine("Enter the color");
                        string color = Console.ReadLine();
                        Console.WriteLine("Ener the owner name ");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter the model");
                        string model = Console.ReadLine();
                        DateTime entrytime = DateTime.Now;
                        Car car = new Car(number, make, color, name,entrytime, model);
                        parkingLot.Parking(car);
                        break;

                    case 3:Console.WriteLine("Calculating the parking charges");
                        Console.WriteLine("Enter the numberPlate number whoes parking charges is to be calculated");
                        int numberPlate = int.Parse(Console.ReadLine());
                        Car cartoMakePayment = null;
                        foreach (Car n in parkingLot.parkingLots)
                        {
                            if (n.NumberPlate == numberPlate)
                            {
                                cartoMakePayment= n;
                                break;
                            }
                        }
                        if (cartoMakePayment == null)
                        {
                            Console.WriteLine("There is no car present with the given Number Plate");
                        }
                        else
                        {
                            double cash = parkingLot.CalculateCharges(cartoMakePayment);
                            Console.WriteLine($"Parking charges is : Rs:{cash:F2} ");
                        }
                        break;

                    case 4:
                        Console.WriteLine("unparking the car");
                        Console.WriteLine("Enter the numberPlate number of the car that is to be vacated");
                        int num = int.Parse(Console.ReadLine());
                        Car cartoVacate = null;
                        foreach (Car n in parkingLot.parkingLots)
                        {
                            if(n.NumberPlate == num)
                            {
                                cartoVacate = n;
                                break;
                            }
                        }
                        if(cartoVacate == null)
                        {
                            Console.WriteLine("There is no car present with the given Number Plate");
                        }
                        parkingLot.VacateSlot(cartoVacate);

                        break;

                    case 5:
                        Console.WriteLine("Thankyou for using our Software....");
                        return;

                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }
            }

        }
    }
}
