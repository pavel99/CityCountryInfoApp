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
    public partial class ViewCountryPage : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {

            countryGridView.DataSource = countryManager.GetCountryInfo();
            countryGridView.DataBind();

        }

        protected void searchCountryButton_Click(object sender, EventArgs e)
        {
            if (searchCountryTextBox.Text == "")
            {
                MessageBox.Show("Please enter values");
            }
            else
            {
                string countryName = searchCountryTextBox.Text;
                countryGridView.DataSource = countryManager.GetCountryInfoByCountryName(countryName);
                countryGridView.DataBind();
                searchCountryTextBox.Text = "";
            }


        }
    }
}