using Demo_UseCaseException.Model;

namespace Demo_UseCaseException.Repository
{
    interface IBikeRepository
    {
       bool AddBike(Bike bike);
       List<Bike> GetAllBikes();
      Bike GetBikeByName(string name);
    }
}
