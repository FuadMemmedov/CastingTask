using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RentCar
    {
        Vehicle[] _vehicles = new Vehicle[] {};
        Truck[] _trucks = new Truck[] {};
        Car[] _cars = new Car[] {};
        public int CarLimit { get; set; }
        public int TruckLimit { get; set; }

        public RentCar(int carLimit,int truckLimit)
        {
            CarLimit = carLimit;
            TruckLimit = truckLimit;
                
        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle is Car car)
            {
                if (_cars.Length < CarLimit)
                {
                    Array.Resize(ref _cars, _cars.Length + 1);
                    _cars[_cars.Length - 1] = car;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Car limit kecilib");
                }
            }
            if (vehicle is Truck truck)
            {
                if (_trucks.Length < TruckLimit)
                {
                    Array.Resize(ref _trucks, _trucks.Length + 1);
                    _trucks[_trucks.Length - 1] = truck;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;

                }
                else
                {
                    Console.WriteLine("Truck limit kecilib");
                }
            }
        }

        public void ShowAllVehicles()
        {
            foreach(var vehicle in _vehicles)
            {
                if(vehicle is Car)
                {
                    var car = vehicle as Car;
                    Console.WriteLine($"PassengerCapacity: {car.PassengerCapacity}");
                }
                else if(vehicle is Truck)
                {
                    var truck = vehicle as Truck;
                    Console.WriteLine($" CarryingCapacity: {truck.CarryingCapacity}");
                }
            }

        }


    }
}
