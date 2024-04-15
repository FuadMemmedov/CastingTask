using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Truck:Vehicle
    {
        public int CarryingCapacity { get; set; }

        public Truck(string marka, string model, int year,int carryingCapacity) : base(marka, model, year)
        {
            CarryingCapacity = carryingCapacity;
        }
    }
}
