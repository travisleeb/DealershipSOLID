using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class SUVType : Type
    {
        public enum Type
        {
            AWD,
            Crossover,
            Electric,
            Family,
            OffRoad,
            Sedan,
            Sport,
        }
    }
}