using Demo_DataAdapter.Model;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DataAdapter.Repository
{
    class BikeRepository : IBikeRepository
    {
        SqlDataAdapter sqlDataAdapter = null;
        DataSet dataset = null;

        //constructor
        public BikeRepository()
        {
            sqlDataAdapter = new SqlDataAdapter("Select * from Bikes", "Server=DESKTOP-0TE71RT;Database=BikeStore;Trusted_Connection=True");
            dataset = new DataSet();
            sqlDataAdapter.Fill(dataset, "t_Bikes");
        }

        public void AddBike(Bike bike)
        {
            DataRow dataRow = dataset.Tables["t_Bikes"].NewRow();
            dataRow["BikeId"] = bike.BikeId;
            dataRow["BikeName"] = bike.BikeName;
            dataRow["CategoryId"] = bike.CategoryId;
            dataRow["Price"] = bike.Price;
            dataRow["Quantity"] = bike.Quantity;
            dataset.Tables["t_Bikes"].Rows.Add(dataRow);


        }

        public List<Bike> GetAllBikes()
        {
            List<Bike> bikes = new List<Bike>();
            foreach(DataRow row in dataset.Tables["t_Bikes"].Rows)
            {
                Bike bike = new Bike();
                bike.BikeId = (int)row["BikeId"];
                bike.BikeName = row["BikeName"].ToString();
                bikes.Add(bike);
            }
            return bikes;

        }

        public void UpdateChanges()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            sqlDataAdapter.Update(dataset, "t_Bikes");
            Console.WriteLine("Added successfully");

        }
    }
}
