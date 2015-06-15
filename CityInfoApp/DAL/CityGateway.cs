using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CityInfoApp.Model;

namespace CityInfoApp.DAL
{
    
    public class CityGateway
    {
        
          private string connectionString = ConfigurationManager.ConnectionStrings["CityDescriptionDB"].ConnectionString;

        public int SaveCityInfo(Cities aCity)
        {
            string query = string.Format(@"INSERT INTO Cities VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", aCity.Name,
                aCity.About, aCity.No_Of_Dwellers, aCity.Location, aCity.Weather, aCity.Country_ID);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
        public bool ISCityNameAlreadyExists(Cities aCity)
        {
            bool isCityNameAlreadyExists = false;
            string query = string.Format("Select * From Cities Where Name='{0}'", aCity.Name);
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                isCityNameAlreadyExists = true;
                break;
            }
            reader.Close();
            connection.Close();
            return isCityNameAlreadyExists;

        }

        public List<Countries> PopulateDropDownList()
        {
            //List<Countries> countryList = new List<Countries>();
            //SqlConnection connection = new SqlConnection(connectionString);
            //string query = string.Format("SELECT * FROM Countries");
            ////SqlDataAdapter adapter=new SqlDataAdapter();
            //connection.Open();
            //SqlCommand command = new SqlCommand(query, connection);
            ////adapter.SelectCommand=new SqlCommand(query,connection);
            //SqlDataReader reader = command.ExecuteReader();
            //connection.Close();
            //return reader;
            List<Countries> countryList = new List<Countries>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("SELECT * FROM Countries");
            //SqlDataAdapter adapter=new SqlDataAdapter();
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            //adapter.SelectCommand=new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Countries aCountries = new Countries();
                aCountries.ID = Convert.ToInt32(reader["ID"]);
                aCountries.Name = reader["Name"].ToString();
                aCountries.About = reader["About"].ToString();
                countryList.Add(aCountries);
               
            }
            reader.Close();
            connection.Close();
            return countryList;
        }
        public List<DisplayCity> GetAllCity()
        {
            List<DisplayCity> cityInfoList = new List<DisplayCity>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format("Select Cities.Name,Cities.No_of_Dwellers,Countries.Name AS Country From Countries INNER JOIN Cities ON Countries.ID=Cities.Country_ID ORDER BY Cities.Name");
            
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
           
            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
               DisplayCity aCity=new DisplayCity();
                aCity.SL = serial;
                aCity.CityName = reader["Name"].ToString();
                aCity.No_Of_Dwellers = Convert.ToInt32(reader["No_of_Dwellers"]);
                aCity.CountryName = reader["Country"].ToString();
                cityInfoList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return cityInfoList;

        }

        public List<DisplayCityCountry> GetAllCity_CountryByCityName(string cityName)
        {
            List<DisplayCityCountry> cityCountryList = new List<DisplayCityCountry>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format(@"Select Cities.Name as CityName,Cities.About," +
                                         "Cities.No_of_Dwellers,Cities.Location,Cities.Weather," +
                                         "Countries.Name as Country,Countries.About AboutCountry" +
                                         " From Countries INNER JOIN Cities " +
                                         "ON Countries.ID=Cities.Country_ID Where Cities.Name like '%{0}%'",cityName);

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                DisplayCityCountry aCity = new DisplayCityCountry();
                aCity.SL = serial;
                aCity.Name = reader["CityName"].ToString();
                aCity.About = reader["About"].ToString();

                aCity.No_Of_Dwellers = Convert.ToInt32(reader["No_of_Dwellers"]);
                aCity.Location = reader["Location"].ToString();
                aCity.Weather = reader["Weather"].ToString();
                aCity.CountryName = reader["Country"].ToString();
                aCity.AboutCountry = reader["AboutCountry"].ToString();
                cityCountryList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return cityCountryList;

            
        }
        public List<DisplayCityCountry> GetAllCity_CountryByCountryName(string countryName)
        {
            List<DisplayCityCountry> cityCountryList = new List<DisplayCityCountry>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format(@"Select Cities.Name as CityName,Cities.About," +
                                         "Cities.No_of_Dwellers,Cities.Location,Cities.Weather," +
                                         "Countries.Name as Country,Countries.About AboutCountry" +
                                         " From Countries INNER JOIN Cities " +
                                         "ON Countries.ID=Cities.Country_ID Where Countries.Name='{0}'", countryName);

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                DisplayCityCountry aCity = new DisplayCityCountry();
                aCity.SL = serial;
                aCity.Name = reader["CityName"].ToString();
                aCity.About = reader["About"].ToString();

                aCity.No_Of_Dwellers = Convert.ToInt32(reader["No_of_Dwellers"]);
                aCity.Location = reader["Location"].ToString();
                aCity.Weather = reader["Weather"].ToString();
                aCity.CountryName = reader["Country"].ToString();
                aCity.AboutCountry = reader["AboutCountry"].ToString();
                cityCountryList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return cityCountryList;


        }
        public List<DisplayCityCountry> GetAllCity_Country()
        {
            List<DisplayCityCountry> cityCountryList = new List<DisplayCityCountry>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = string.Format(@"Select Cities.Name as CityName,Cities.About," +
                                         "Cities.No_of_Dwellers,Cities.Location,Cities.Weather," +
                                         "Countries.Name as Country,Countries.About AboutCountry" +
                                         " From Countries INNER JOIN Cities " +
                                         "ON Countries.ID=Cities.Country_ID ");

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            int serial = 1;
            while (reader.Read())
            {
                DisplayCityCountry aCity = new DisplayCityCountry();
                aCity.SL = serial;
                aCity.Name = reader["CityName"].ToString();
                aCity.About = reader["About"].ToString();

                aCity.No_Of_Dwellers = Convert.ToInt32(reader["No_of_Dwellers"]);
                aCity.Location = reader["Location"].ToString();
                aCity.Weather = reader["Weather"].ToString();
                aCity.CountryName = reader["Country"].ToString();
                aCity.AboutCountry = reader["AboutCountry"].ToString();
                cityCountryList.Add(aCity);
                serial++;
            }
            reader.Close();
            connection.Close();
            return cityCountryList;


        }

    }
}