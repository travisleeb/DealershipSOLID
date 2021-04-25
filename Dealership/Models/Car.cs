using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Dealership.Models.Type;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        public Car(int year, string name, string make, int doors, bool isNew) : base (year, name, make, doors, isNew)
        {

        }

        public void AddType(CarType type)
        {
            this.Types.Add(type);
        }

        public void RemoveType(CarType type)
        {
            this.Types.Remove(type);
        }
        
    }
}