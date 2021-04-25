using Dealership.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class Dealer : IDealer
    {
        private int _id;
        private string _name;
        private string _openHours;
        private List<Vehicle> _vehicles;

#region Implemented Properties

        public int ID
        {
            get { return this._id; }
        }

        public string Name {
            get { return this._name; }
        }

        public string OpenHours {
            get { return this._openHours; }
        }

        public List<Vehicle> Vehicles {
            get { return this._vehicles; }
        }
        #endregion
        
        public Dealer(string name, string openHours)
        {
            this._name = Name;
            this._openHours = OpenHours;
            this._vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            this.Vehicles.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            this.Vehicles.Remove(this.Vehicles.Where(v => v.ID == vehicle.ID).FirstOrDefault());
        }
    }
}