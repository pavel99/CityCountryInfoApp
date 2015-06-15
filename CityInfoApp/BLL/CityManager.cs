using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CityInfoApp.DAL;
using CityInfoApp.Model;

namespace CityInfoApp.BLL

{
    
    
    public class CityManager
    {
        CityGateway gateway=new CityGateway();
        public List<Countries> PopolateDropdownList()
        {
            return gateway.PopulateDropDownList();

        }

        public string SaveCityInfo(Cities aCity)
        {
            if (!gateway.ISCityNameAlreadyExists(aCity))
            {
                if (gateway.SaveCityInfo(aCity)>0)
                {
                    return "City info saved Succesfully";
                }
                else
                {
                    return "City info saving failed";

                }
                
            }
            else
            {
                return "City Name already exists";
            }
        }

        public List<DisplayCity> GetAllCity()
        {
            return gateway.GetAllCity();
        }

        public List<DisplayCityCountry> GetAllCity_CountryByCityName(string cityName)
        {
            return gateway.GetAllCity_CountryByCityName(cityName);
        }
        public List<DisplayCityCountry> GetAllCity_CountryByCountryName(string countryName)
        {
            return gateway.GetAllCity_CountryByCountryName(countryName);
        }

        public List<DisplayCityCountry> GetAllCity_Country()
        {
            return gateway.GetAllCity_Country();
        }
    }
}