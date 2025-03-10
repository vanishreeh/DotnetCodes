using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeAPPFramework.Model
{
    class Bike
    {
        public int BikeId { get; set; }
        public string BikeName { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int? Quantity { get; set; }

        public override string ToString()
        {
            return $"Id::{BikeId}\tName::{BikeName}\tPrice::{Price}\tCategory::{CategoryId}\tQuantity::{Quantity}";
        }
    }
}
