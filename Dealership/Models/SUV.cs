using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class SUV : Vehicle, ISUV
    {
        public SUV(int year, string name, string make, int doors, bool isNew) : base(year, name, make, doors, isNew)
        {

        }

        public void AddType(SUVType type)
        {
            this.Types.Add(type);
        }

        public void RemoveType(SUVType type)
        {
            this.Types.Remove(type);
        }

    }
}