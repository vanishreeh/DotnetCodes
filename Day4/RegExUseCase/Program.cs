namespace RegExUseCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mobile number should be 10 digits
            //+sign may be there may not be there(91,+91)
            // a white space or hyphen symbol (91- or 91 )
            //the first digit of the number should start with 6-9
            // the rest of the digits should be between 0-9
            Console.WriteLine("Eneter number");
            string mobNum = Console.ReadLine();
            bool validationStatus=MobileNumberValidation.ValidateMobNum(mobNum);
            if (validationStatus)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("enter proper number");
            }
        }
    }
}
