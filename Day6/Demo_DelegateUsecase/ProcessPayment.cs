using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DelegateUsecase
{
    //public delegate void Notify();
    public delegate void Notify(string message);
    class ProcessPayment
    {

        public void PaymentProcess(decimal amount, Notify callback)
        {
            Console.WriteLine("Payment processing");
            Console.WriteLine($"Amount::{amount}");
            //delay
            Thread.Sleep(4000);
            callback("Payment Completed");

        }
        //public event Notify OnStart;//event based on delegate
        //public void BeginTransaction()
        //{
        //    Console.WriteLine("transaction initiated");
        //    OnStart.Invoke();//Invoke the methods which Delegate is pointing to
        
     
        


    }
}

