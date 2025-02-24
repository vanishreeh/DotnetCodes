

namespace Demo_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region method basics
            //    Console.WriteLine(GetId(20));
            //    Console.WriteLine(Getdetails("vani","Bangalore"));//vaniBangalore
            //    //passing named parameters
            //    Console.WriteLine(Getdetails(state:"Bangalore",name:"Vani"));//vaniBangalore
            ////Invoking method overloading
            //    Console.WriteLine(Getdetails("vani","Karnataka","Banaglore"));//
            //}
            //  static int GetId(int id)
            //{
            //    return id;
            //}
            //static string  Getdetails(string name,string city="Pune")
            //{
            //    return name + city;
            //}
            ////method Overloading
            //static string Getdetails(string name,string state, string city = "Pune")
            //{
            //    return name + city+state;
            #endregion
            //calculate circumference and area of a circle 
            double radius = 3.567;//field
            //double circumferencevalue=100;
            //double areaValue=100;
            CalculateAreaAndCircumference(radius, out double circumferencevalue, out double areaValue);
            //CalculateAreaAndCircumference(radius, out circumferencevalue, out  areaValue);
            //double circumferencevalue = 0;
            //double areaValue = 0;


            //CalculateAreaAndCircumference( radius,ref  circumferencevalue,ref  areaValue);
            Console.WriteLine($"Area::{areaValue}\tCircumference::{circumferencevalue}");
        }

        public static void CalculateAreaAndCircumference(double radius, out double circumfrerence, out double area)
        {
            circumfrerence = 2 * Math.PI * radius;
            area = Math.PI * (radius * radius);
        }
        //public static void CalculateAreaAndCircumference(double radius, ref double circumfrerence, ref double area)
        //{
        //    circumfrerence = 2 * Math.PI * radius;
        //    area = Math.PI * (radius * radius);
        //}

    }

}
