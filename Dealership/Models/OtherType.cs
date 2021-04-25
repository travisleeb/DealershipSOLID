using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class OtherType : Type
    {
        public enum Type
        {
            MotorCycle,
            Moped,
            Trike,
            Hoverboard,
            Bike,
            Skateboard,
            Segway,
        }
    }
}