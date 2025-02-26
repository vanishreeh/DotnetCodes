using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Inheritance.Model
{
    class ElectricBike:Bike
    {
        public int Capacity { get; set; }
        public int Range { get; set; }
    
        //constructor
        public ElectricBike(int id,string name,decimal price,int capacity,int range):base(id,name,price)
        {
            Capacity = capacity;
            Range = range;
            
        }
        //Method Hiding
        //public new string GetAllBikeDetails()
        //{
        //    return $"BikeId::{BikeId}\t name::{BikeName}\t Price::{Price}\tRange::{Range}\tCapacity::{Capacity}";
        //}
        //Compile time polymorphism or early Binding
        public void GetInfo()
        {
            Console.WriteLine($"Id::{BikeId}\tname::{BikeName}\trange::{Range}");
        }
        public void GetInfo(int bikeId)
        {
            Console.WriteLine($"Id::{BikeId}name::{BikeName}");
        }
        //Runtime Polymorphism,LateBinding
        //public override string GetAllBikeDetails()
        //{
        //    return $"BikeId::{BikeId}\t name::{BikeName}\t Price::{Price}\tRange::{Range}\tCapacity::{Capacity}";
        //}
    }
}
