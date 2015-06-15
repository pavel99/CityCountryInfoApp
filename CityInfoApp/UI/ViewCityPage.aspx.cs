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
    public partial class ViewCityPage : System.Web.UI.Page
    {
        CityManager cityManager = new CityManager();
        DisplayCityCountry aCityCountry = new DisplayCityCountry();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateDropdownList();

            }
            PopulateGridView();

        }
        public void PopulateDropdownList()
        {
            countryDropDownList.DataSource = cityManager.PopolateDropdownList();
            countryDropDownList.DataTextField = "Name";
            countryDropDownList.DataValueField = "ID";
            countryDropDownList.DataBind();

            //countryDropDownList.DataSource = citymanager.PopolateDropdownList();
            //countryDropDownList.DataTextField = "Name";
            //countryDropDownList.DataValueField = "ID";
            //countryDropDownList.DataBind();

        }

        public void PopulateGridViewByCityName()
        {
            if (cityTextBox.Text == "")
            {
                MessageBox.Show("Please Enter City name of partial City Name");
            }
            else
            {
                string cityName = cityTextBox.Text;
                viewCityGridView.DataSource = cityManager.GetAllCity_CountryByCityName(cityName);
                viewCityGridView.DataBind();

            }

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (cityRadioButton.Checked)
            {
                PopulateGridViewByCityName();
                cityTextBox.Text = "";
            }
            else if (countryRadioButton.Checked)
            {
                PopulateGridViewByCountryName();
                cityTextBox.Text = "";

            }

        }
        public void PopulateGridViewByCountryName()
        {


            string countryName = countryDropDownList.SelectedItem.Text;
            //test.Text = countryName;

            viewCityGridView.DataSource = cityManager.GetAllCity_CountryByCountryName(countryName);
            viewCityGridView.DataBind();



        }

        public void PopulateGridView()
        {
            viewCityGridView.DataSource = cityManager.GetAllCity_Country();
            viewCityGridView.DataBind();
        }

    }
}