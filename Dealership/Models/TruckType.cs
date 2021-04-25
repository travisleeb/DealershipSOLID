using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class TruckType : Type
    {
        public enum Type
        {
            AWD,
            Electric,
            Fullsize,
            Midsize,
            OffRoad,
        }
    }
}