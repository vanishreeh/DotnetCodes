using Demo_BikeStoreAPP.Model;
using Demo_BikeStoreAPP.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_BikeStoreAPP.Repository
{
    class BikeRepository : IBikeRepository
    {
        // SqlConnection sqlConnection = null;
        SqlCommand cmd = null;
        string connstring;

        //constructor
        public BikeRepository()
        {
            //sqlConnection = new SqlConnection("Server=DESKTOP-0TE71RT;Database=BikeStore;Trusted_Connection=True");
            cmd = new SqlCommand();
            connstring = DbConnUtil.GetConnectionString();
        }



        #region code without using block
        //public List<Bike> GetAllBikes()
        //{
        //    List<Bike> bikes = new List<Bike>();
        //    cmd.CommandText = "select * from Bikes";
        //    cmd.Connection = sqlConnection;
        //    sqlConnection.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        //create an object of BikeClass
        //        Bike bike = new Bike();
        //        bike.BikeId = (int)reader["BikeId"];
        //        bike.BikeName = (string)reader["BikeName"];
        //        bike.Price = (decimal) reader["Price"];
        //        bike.CategoryId = (int)reader["CategoryId"];
        //        bike.Quantity = Convert.IsDBNull(reader["Quantity"])? null:(int)reader["Quantity"];
        //        bikes.Add(bike);

        //    }
        //    sqlConnection.Close();
        //    return bikes;
        //}
        #endregion
        public List<Bike> GetAllBikes()
        {
            List<Bike> bikes = new List<Bike>();
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                cmd.CommandText = "select * from Bikes";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //create an object of BikeClass
                    Bike bike = new Bike();
                    bike.BikeId = (int)reader["BikeId"];
                    bike.BikeName = (string)reader["BikeName"];
                    bike.Price = (decimal)reader["Price"];
                    bike.CategoryId = (int)reader["CategoryId"];
                    bike.Quantity = Convert.IsDBNull(reader["Quantity"]) ? null : (int)reader["Quantity"];
                    bikes.Add(bike);


                }
            }
            return bikes;

        }

    }
}

