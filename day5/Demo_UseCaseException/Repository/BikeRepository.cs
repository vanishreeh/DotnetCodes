using Demo_UseCaseException.Model;
using Demo_UseCaseException.Exceptions;
namespace Demo_UseCaseException.Repository
{
    class BikeRepository:IBikeRepository
    {
        //create a List
        List<Bike> bikes;
        //constructor
        public BikeRepository()
        {
            //Initialising the list
            bikes = new List<Bike>
            {
                new Bike(){Id=1,Name="Ola",Price=20000M},
                new Bike(){Id=2,Name="Duke",Price=40000M}

            };
        }

        public bool AddBike(Bike bike)
        {
            try
            {
                Bike searchResult = GetBikeByName(bike.Name);
                if (searchResult == null)
                {
                    bikes.Add(bike);
                    return true;
                }

                else
                {
                    //throw exception BikeAlreadyExistsException
                    throw new BikeAlreadyExistException($"{bike.Name} name already Exists");
                    
                }
               
            }
            catch(BikeAlreadyExistException baex)
            {
                Console.WriteLine(baex.Message);
            }
            return false;
        }

        public List<Bike> GetAllBikes()
        {
            return bikes;
        }

        public Bike GetBikeByName(string name)
        {
           return bikes.Find(p => p.Name == name);
        }
    }
}
