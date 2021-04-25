using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class OtherVehicle : Vehicle, IOtherVehicle
    {
        public OtherVehicle(int year, string name, string make, int doors, bool isNew, int wheels) : base(year, name, make, doors, isNew)
        {
            this._wheels = wheels;  //Other vehicles may have more, less, or no wheels
        }

        public void AddType(OtherType type)
        {
            this.Types.Add(type);
        }

        public void RemoveType(OtherType type)
        {
            this.Types.Remove(type);
        }

    }
}