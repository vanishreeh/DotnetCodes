namespace Demo_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* write a c# program 
             * take cart amount as input
             apply discounts based on amount
                if total is greater =than 5000 give 20% discount
                if total is >= 3000 and <5000 give10% discount
            if total is <3000 no discount
             if total is more than 3000 free shipping is available*/
            Console.WriteLine("Enter the Total cart amount::");
            double totalAmount =Convert.ToDouble( Console.ReadLine());
            double discount=0;
            if (totalAmount >= 5000)
            {
                discount = totalAmount * 0.20;
            }
            else if(totalAmount>=3000 )
            {
                discount = totalAmount * 0.10;
            }
            double amountToPay = totalAmount - discount;
            Console.WriteLine($"Total Cart Amount::{totalAmount}");
            Console.WriteLine($"Discount Applied::{discount}");
            Console.WriteLine($"Amount To pay::{amountToPay}");
            //if (totalAmount >= 3000)
            //{
            //    Console.WriteLine("free shipping on your order");
            //}
            //else
            //{
            //    Console.WriteLine("pay  Rs 50 for shipping");
            //}
            Console.WriteLine($"shipping charge::{(totalAmount>=3000?"free":"Rs50")}");

           
        }
    }
}
