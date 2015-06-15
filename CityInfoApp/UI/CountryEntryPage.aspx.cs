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
    public partial class CountryEntryPage : System.Web.UI.Page
    {
        private Countries aCountry = new Countries();
        private CountryManager manager = new CountryManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGridView();


        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            if (countryNameTextbox.Text == "" || aboutTextbox.Text == "")
            {
                MessageBox.Show("Please enter all values");

            }
            else
            {

                aCountry.Name = countryNameTextbox.Text;
                aCountry.About = aboutTextbox.Text;
                MessageBox.Show(manager.SaveCountry(aCountry));
                clear();
                PopulateGridView();



            }


        }

        public void PopulateGridView()
        {
            countryGridView.DataSource = manager.Getcountries();
            countryGridView.DataBind();
        }

        public void clear()
        {
            countryNameTextbox.Text = "";
            aboutTextbox.Text = "";
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}