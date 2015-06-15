using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CityInfoApp.BLL;
using CityInfoApp.Model;

namespace CityInfoApp.UI
{
    public partial class CityEntryPage : System.Web.UI.Page
    {
        CountryManager manager = new CountryManager();
        Countries aCountry = new Countries();
        CityManager citymanager = new CityManager();
        Cities acity = new Cities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateDropdownList();
                //countryDropDownList.SelectedValue = "1";
            }
            PopulateCityGridView();


        }

        public void PopulateDropdownList()
        {
            allCountryDropDownlist.DataSource = citymanager.PopolateDropdownList();
            allCountryDropDownlist.DataTextField = "Name";
            allCountryDropDownlist.DataValueField = "ID";
            allCountryDropDownlist.DataBind();

            //countryDropDownList.DataSource = citymanager.PopolateDropdownList();
            //countryDropDownList.DataTextField = "Name";
            //countryDropDownList.DataValueField = "ID";
            //countryDropDownList.DataBind();

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (cityNameTextBox.Text == "" || aboutTextBox.Text == "" || dewellersTextBox.Text == "" ||
                locationTextBox.Text == ""
                || weatherTextBox.Text == "")
            {
                MessageBox.Show("Please Enter All Values");
            }
            else
            {
                acity.Name = cityNameTextBox.Text;
                acity.About = aboutTextBox.Text;
                acity.No_Of_Dwellers = Convert.ToInt32(dewellersTextBox.Text);
                acity.Location = locationTextBox.Text;
                acity.Weather = weatherTextBox.Text;
                acity.Country_ID = Convert.ToInt32(allCountryDropDownlist.SelectedValue);
                //string name = allCountryDropDownlist.SelectedValue;
                //  Response.Write(name);
                // Response.Write(acity.Country_ID);
                MessageBox.Show(citymanager.SaveCityInfo(acity));
                PopulateCityGridView();
                Clear();

            }



        }

        public void PopulateCityGridView()
        {
            cityGridView.DataSource = citymanager.GetAllCity();
            cityGridView.DataBind();
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            cityNameTextBox.Text = "";
            aboutTextBox.Text = "";
            dewellersTextBox.Text = "";
            locationTextBox.Text = "";
            weatherTextBox.Text = "";

        }

    }
}