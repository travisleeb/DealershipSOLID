using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class Truck : Vehicle, ITruck
    {
        public Truck(int year, string name, string make, int doors, bool isNew) : base(year, name, make, doors, isNew)
        {

        }

        public void AddType(TruckType type)
        {
            this.Types.Add(type);
        }

        public void RemoveType(TruckType type)
        {
            this.Types.Remove(type);
        }

    }
}