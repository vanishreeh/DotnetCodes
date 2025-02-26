using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    class Bike : IOrder, IBike
    {
        void IBike.AddBike(Bike bike)
        {
            throw new NotImplementedException();
        }
        //Implicit Interface
        //public void AddBike(Bike bike)
        //{
        //    Console.WriteLine("Bike Added");
        //}

        //public int GetBikeById(int id)
        //{
        //    return id;
        //}

        //public bool OrderBike()
        //{
        //    return true;
        //}
        //Explicit Interfaces
        int IOrder.GetBikeById(int id)
        {
            throw new NotImplementedException();
        }

        bool IOrder.OrderBike()
        {
            throw new NotImplementedException();
        }
    }
}
