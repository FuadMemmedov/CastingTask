using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Vehicle
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Year {  get; set; }



        public Vehicle(string marka,string model,int year)
        {
            Marka = marka;
            Model = model;
            Year = year;
                
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Marka: {Marka} Model: {Model} Year: {Year}");
        }


    }
}
