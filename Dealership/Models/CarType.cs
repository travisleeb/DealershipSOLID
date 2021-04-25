using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class CarType : Type
    {
        public enum Type
        {
            AWD,
            Coupe,
            Electric,
            Family,
            Sedan,
            Sport,
        }
    }
}