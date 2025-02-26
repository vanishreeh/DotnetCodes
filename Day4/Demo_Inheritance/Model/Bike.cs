using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance.Model
{
    class Bike
    {
        public int BikeId { get; set; }
        public string BikeName { get; set; }
       public  decimal Price { get; set; }

        //protected internal decimal Price { get; set; }

        //constructor
        public Bike(int id,string name,decimal price)
        {
            BikeId = id;
            BikeName = name;
            Price = price;
        }
        //public string GetAllBikeDetails()
        //{
        //    return $"BikeId::{BikeId}\t name::{BikeName}\t Price::{Price}";
        //}
        public virtual string GetAllBikeDetails()
        {
            return $"BikeId::{BikeId}\t name::{BikeName}\t Price::{Price}";
        }
    }
}
