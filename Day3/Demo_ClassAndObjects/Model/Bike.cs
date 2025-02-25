using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ClassAndObjects.Model
{
    class Bike
    {
        public static string name;
        #region Properties
        //fields
        //exposing fileds with public keyword
        //int bikeId;
        //public string bikeName;
        //public double bikePrice;
        //int bikeId;
        // string bikeName;
        // double bikePrice;
        //int bikeNumber;
        #region Traditional Methods
        //public int GetId()
        //{
        //    return bikeId;
        //}
        //public void SetId(int idValue)
        //{
        //    bikeId = idValue;
        //}
        #endregion
        #region Getter and Setter Properties
        //public int MyId
        //{
        //    get { return bikeId; }
        //    set
        //    {
        //        if(value>0)//to check the condition before assigning values 

        //        bikeId = value;
        //    }
        //}
        #endregion
        //Auto -implemented properties in C#
        //public int BikeId { get; set; }//read and write Property
        //public int BikeId { get; }//readonly properties
        //public int BikeId { set; }//this is not allowed should have get
        //public int BikeNumber { get; set; }
        #endregion
        //prop+tab key
        public int BikeId { get; set; }
        public string BikeName { get; set; }
        public double BikePrice{ get; set; }
        //public DateTime Year { get; set; } 

        //constructor
        //constructor is special kind of method ,invoked when object creation happens
        //default constructor
        //ctor+tab
        //public Bike()
        //{

        //}
        //public Bike(int id,string name,double price)
        //{
        //    BikeId = id;
        //    BikeName = name;
        //    BikePrice = price;

        //}
        //Static constructor
        static Bike()
        {
            name = "RoyalEnfield";
            Console.WriteLine("Static constructor is called");
        }
        public override string ToString()
        {
            return $"Id::{BikeId}\tName::{BikeName}\tPrice::{BikePrice}";
        }


        
    }
}
