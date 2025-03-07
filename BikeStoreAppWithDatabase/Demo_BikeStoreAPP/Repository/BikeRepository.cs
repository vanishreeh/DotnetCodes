using Demo_BikeStoreAPP.Model;
using Demo_BikeStoreAPP.Utility;
using System;
using System.Collections.Generic;
using System.Data;
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
            //comment the below line to execute stored procedures
            cmd = new SqlCommand();
            connstring = DbConnUtil.GetConnectionString();
        }

        public int AddBike(Bike bike)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                // cmd.Parameters.Clear();
                cmd.CommandText = "Insert into Bikes values(@BikeId,@BikeName,@Price,@CategoryId,@Quantity)";
                cmd.Parameters.AddWithValue("@BikeId", bike.BikeId);
                cmd.Parameters.AddWithValue("@BikeName", bike.BikeName);
                cmd.Parameters.AddWithValue("@Price", bike.Price);
                cmd.Parameters.AddWithValue("@CategoryId", bike.CategoryId);
                cmd.Parameters.AddWithValue("@Quantity", bike.Quantity);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                return cmd.ExecuteNonQuery();
                // return cmd.ExecuteScalar();//check this method

            }
        }

        public int DeleteBike(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                cmd.CommandText = "Delete from Bikes where BikeId=@BikeId";
                cmd.Parameters.AddWithValue("@BikeId", id);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                return cmd.ExecuteNonQuery();
            }
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
                #region Executing StoredProcedures with ADO.net
                //cmd = new SqlCommand("GetAllBikes ");
                //cmd.CommandType = CommandType.StoredProcedure;
                #endregion

                cmd.CommandText = "select * from Bikes";
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    //create an object of BikeClass
                    Bike bike = new Bike();
                    //bike.BikeId = (int)reader["BikeId"];
                    bike.BikeId = reader.GetInt32("BikeId");
                    //bike.BikeName = (string)reader["BikeName"];
                    bike.BikeName = reader.GetString("BikeName");
                    // bike.Price = (decimal)reader["Price"];
                    bike.Price = reader.GetDecimal("Price");
                    //bike.CategoryId = (int)reader["CategoryId"];
                    bike.CategoryId = reader.GetInt32("CategoryId");
                    //bike.Quantity = Convert.IsDBNull(reader["Quantity"]) ? null : (int)reader["Quantity"];
                    bike.Quantity = reader.IsDBNull("Quantity") ? null : reader.GetInt32("Quantity");
                    bikes.Add(bike);


                }
            }
            return bikes;

        }

        public int UpdateBike(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                Console.WriteLine("Enter Price");
                decimal rate = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                cmd.CommandText = "Update Bikes set Price=@Price,Quantity=@Quantity where BikeId=@BikeId";
                cmd.Parameters.AddWithValue("@BikeId", id);
                cmd.Parameters.AddWithValue("@Price", rate);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                return cmd.ExecuteNonQuery();

            }
        }


    }
}



