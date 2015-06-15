using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CityInfoApp.Model
{
    public class Cities
    {
        public int ID { get; set; }

        public string Name{ get; set; }

        public string About { get; set; }

        public int No_Of_Dwellers{ get; set; }

        public string Location{ get; set; }

        public string Weather{ get; set; }

        public int Country_ID{ get; set; }
    }
}