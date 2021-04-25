using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public interface IVehicle
    {
        Guid ID { get; }
        int Year { get; }
        string Make { get; }
        string Name { get; }
        bool IsNew { get;  }
        int Wheels { get; }
        int Doors { get; }
        List<Type> Types { get; }

    }
}