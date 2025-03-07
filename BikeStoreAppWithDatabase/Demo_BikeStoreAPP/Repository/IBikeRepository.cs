using Demo_BikeStoreAPP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_BikeStoreAPP.Repository
{
    interface IBikeRepository
    {
       List<Bike> GetAllBikes();
    }
}
