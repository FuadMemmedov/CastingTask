using Core._Enums;
using Core.Enums;
using Core.Models;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carLimit;
            int truckLimit;

            do
            {
                Console.Write("Car limit daxil edin: ");

            } while (!int.TryParse(Console.ReadLine(),out carLimit));

            do
            {
                Console.Write("Truck limit daxil edin: ");

            } while (!int.TryParse(Console.ReadLine(), out truckLimit));



            RentCar rentCar = new RentCar(carLimit,truckLimit);
            byte choice;

            do
            {

                Console.WriteLine("1.AddVehicle\n" +
                    "2.ShowAllVehicles\n" +
                    "0.Exit");

                do
                {
                    Console.Write("Bir secim edin: ");

                } while (!byte.TryParse(Console.ReadLine(),out choice));

                switch (choice)
                {
                    case (byte)Menu.AddVehicle:

                        Console.WriteLine("1.AddCar\n" +
                            "2.AddTruck");

                        do
                        {
                            Console.Write("Elave etmek istediyiniz secin: ");

                        } while (!byte.TryParse(Console.ReadLine(), out choice));



                        switch (choice)
                        {

                            
                            case (byte)AddMenu.AddCar:
                                Console.Write("Marka daxil edin: ");
                                string marka = Console.ReadLine();
                                Console.Write("Model daxil edin:");
                                string model = Console.ReadLine();
                                int year;
                                int passengerCapacity;
                                do
                                {
                                    Console.Write("Il daxil edin: ");

                                } while (!int.TryParse(Console.ReadLine(), out year));

                                do
                                {
                                    Console.Write("Passenger capacity daxil edin: ");

                                } while (!int.TryParse(Console.ReadLine(), out passengerCapacity));

                                Car car = new Car(marka, model, year,passengerCapacity);

                                rentCar.AddVehicle(car);


                                break;
                            case (byte)AddMenu.AddTruck:
                                Console.Write("Marka daxil edin: ");
                                string markaTruck = Console.ReadLine();
                                Console.Write("Model daxil edin:");
                                string modelTruck = Console.ReadLine();
                                int yearTruck;
                                int carryingCapacity;
                                do
                                {
                                    Console.Write("Il daxil edin: ");

                                } while (!int.TryParse(Console.ReadLine(), out yearTruck));

                                do
                                {
                                    Console.Write("Carrying capacity daxil edin: ");

                                } while (!int.TryParse(Console.ReadLine(), out carryingCapacity));

                                Truck truck = new Truck(markaTruck,modelTruck, yearTruck,carryingCapacity);
                                rentCar.AddVehicle(truck);
                            break;

                            default:
                                break;
                        }
                        break;
                        case (byte)Menu.ShowAllVehicles:

                        rentCar.ShowAllVehicles();
                        break;
                        

                        
                    default:
                        break;
                }

            } while (choice != 0);
            
        }
    }
}
