using Demo_DataAdapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DataAdapter.Repository
{
    interface IBikeRepository
    {
        List<Bike> GetAllBikes();
        void AddBike(Bike bike);
        void UpdateChanges();
    }
}
