using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CityInfoApp.DAL;
using CityInfoApp.Model;

namespace CityInfoApp.BLL
{
    public class CountryManager
    {
        
    
        CountryGateway countryGateway=new CountryGateway();
        public string SaveCountry(Countries acountry)
        {
            if (!countryGateway.ISCountryNameAlreadyExists(acountry))
            {
                if ((countryGateway.SaveCountryInfo(acountry) > 0))
                {
                    return "Country Information Saved Succesfully";

                }
                else
                {
                    return "Country Information Saving Failed";
                }
            }
            else
            {
                return "Country Name Already Exists";
            }

        }

        public List<Countries> Getcountries()
        {
            return countryGateway.GetAllCountry();
        }

        public List<CountryInfo> GetCountryInfo()
        {
            return countryGateway.GetCountryInfo();
        }

        public List<CountryInfo> GetCountryInfoByCountryName(string countryName)
        {
            return countryGateway.GetCountryInfoByCountryName(countryName);
        }

    }
}