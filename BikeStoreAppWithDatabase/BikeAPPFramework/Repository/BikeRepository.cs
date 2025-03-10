using BikeAPPFramework.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeAPPFramework.Repository
{
    class BikeRepository
    {
        string constring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlCommand sqlCommand = null;

        //constructor
        public BikeRepository()
        {
            sqlCommand = new SqlCommand();
        }

        public List<Bike> GetAllBikes()
        {
            List<Bike> bikes = new List<Bike>();
            using (SqlConnection sqlCon=new SqlConnection(constring))
            {
                sqlCommand.CommandText = "select * from Bikes";
                sqlCommand.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Bike bike = new Bike();
                    bike.BikeId = reader.GetInt32(0);
                    bike.BikeName = reader.GetString(1);
                    bike.Price = reader.GetDecimal(2);
                    bike.CategoryId = reader.GetInt32(3);
                    bike.Quantity = reader.IsDBNull(4) ? bike.Quantity=null : reader.GetInt32(4); ;
                    bikes.Add(bike);
                }
                return bikes;
            }
        }
    }
}
