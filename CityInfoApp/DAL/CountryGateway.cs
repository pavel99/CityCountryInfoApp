using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CityInfoApp.Model;

namespace CityInfoApp.DAL
{
    public class CountryGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["CityDescriptionDB"].ConnectionString;

        public int SaveCountryInfo(Countries aCountry)
        {
            string query = string.Format("INSERT INTO Countries VALUES('{0}','{1}')",aCountry.Name,aCountry.About);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
           // INSERT INTO Countries VALUES('{0}','{1}')", aCountry.Name, aCountry.About

        }

        public bool ISCountryNameAlreadyExists(Countries acountry)
        {
            bool isCountryNameAlreadyExists = false;
            string query = string.Format("Select * From Countries Where Name='{0}'", acountry.Name);
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                isCountryNameAlreadyExists = true;
                break;
            }
            reader.Close();
            connection.Close();
            return isCountryNameAlreadyExists;

        }

        public List<Countries> GetAllCountry()
        {
            List<Countries> countryList=new List<Countries>();
            SqlConnection  connection=new SqlConnection(connectionString);
            string query = string.Format("SELECT * FROM Countries");
            //SqlDataAdapter adapter=new SqlDataAdapter();
            connection.Open();
            SqlCommand command=new SqlCommand(query,connection);
            //adapter.SelectCommand=new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                Countries aCountries=new Countries();
                aCountries.ID = serial;
                aCountries.Name = reader["Name"].ToString();
                aCountries.About = reader["About"].ToString();
                countryList.Add(aCountries);
                serial++;
            }
            reader.Close();
            connection.Close();
            return countryList;
            
        }

        public List<CountryInfo> GetCountryInfo()
        {
            List<CountryInfo> countryList = new List<CountryInfo>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("Select Countries.Name, Countries.About, Count(Cities.Name) as Number_OF_City, SUM(Cities.No_of_Dwellers) as No_OF_Dwellers FROM Countries INNER JOIN Cities ON Countries.ID=Cities.Country_ID GROUP BY Countries.Name,Countries.About");
            //SqlDataAdapter adapter=new SqlDataAdapter();
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            //adapter.SelectCommand=new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                CountryInfo countryInfo =new CountryInfo();
                countryInfo.SL = serial;
                countryInfo.CountryName = reader["Name"].ToString();
                countryInfo.About = reader["About"].ToString();
                countryInfo.No_OF_City =Convert.ToInt32(reader["Number_OF_City"]);
                countryInfo.No_of_Dwellers = Convert.ToInt32(reader["No_OF_Dwellers"]);
                countryList.Add(countryInfo);
                serial++;
            }
            reader.Close();
            connection.Close();
            return countryList;
            
        }
        public List<CountryInfo> GetCountryInfoByCountryName(string countryName)
        {
            List<CountryInfo> countryList = new List<CountryInfo>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format(@"Select Countries.Name, Countries.About," +
                                         " Count(Cities.Name) as Number_OF_City, SUM(Cities.No_of_Dwellers) as No_OF_Dwellers " +
                                         "FROM Countries INNER JOIN Cities ON" +
                                         " Countries.ID=Cities.Country_ID " +
                                         "Where Countries.Name like '%{0}%'  GROUP BY Countries.Name,Countries.About  ", countryName);
            //SqlDataAdapter adapter=new SqlDataAdapter();
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            //adapter.SelectCommand=new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                CountryInfo countryInfo = new CountryInfo();
                countryInfo.SL = serial;
                countryInfo.CountryName = reader["Name"].ToString();
                countryInfo.About = reader["About"].ToString();
                countryInfo.No_OF_City = Convert.ToInt32(reader["Number_OF_City"]);
                countryInfo.No_of_Dwellers = Convert.ToInt32(reader["No_OF_Dwellers"]);
                countryList.Add(countryInfo);
                serial++;
            }
            reader.Close();
            connection.Close();
            return countryList;

        }
    }
}