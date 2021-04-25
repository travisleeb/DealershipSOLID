using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models.Interfaces
{
    public interface IDealer
    {
        int ID { get;}

        string Name { get; }

        string OpenHours { get; }

        List<Vehicle> Vehicles { get; }
    }
}
