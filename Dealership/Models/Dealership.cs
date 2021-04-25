using Dealership.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class Dealership
    {
        public List<IDealer> Dealers { get; set; }
        public Dealership()
        {

        }
    }
}