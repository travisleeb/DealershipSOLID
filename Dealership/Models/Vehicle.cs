using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dealership.Models
{
    public class Vehicle : IVehicle
    {
        protected Guid _id;
        protected int _year;
        protected string _make;
        protected string _name;
        protected int _doors;
        protected bool _isNew;

        protected List<Type> _types;
        protected int _wheels;

        #region Inherited Properties
        public Guid ID
        {
            get { return _id; }
        }

        public int Year
        {
            get { return _year; }
        }

        public string Make
        {
            get { return _make; }
        }

        public string Name
        {
            get { return _name; }
        }

        public int Doors
        {
            get { return _doors; }
        }

        public bool IsNew
        {
            get { return _isNew; }
        }

        public List<Type> Types
        {
            get { return _types; }
        }

        public int Wheels
        {
            get { return _wheels; }
        }
        #endregion

        public Vehicle(int year, string name, string make, int doors, bool isNew)
        {
            this._year = year;
            this._name = name;
            this._make = make;
            this._doors = doors;
            this._isNew = isNew;
            this._types = new List<Type>();
            _wheels = 4; //Automatically set at 4 wheels
            this._id = new Guid();
        }

        public virtual void AddType(Type type)
        {
            this.Types.Add(type);
        }

        public virtual void RemoveType(Type type)
        {
            this.Types.Remove(type);
        }

    }
}