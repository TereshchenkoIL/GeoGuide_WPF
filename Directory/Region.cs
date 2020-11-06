using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Region :Element, IAdministrative
    {
        [JsonProperty]
        private string kind;
        [JsonProperty]
        private string country;
        [JsonProperty]
        private string capital;

        public string Form
        {
            set { kind = value; }
            get
            {
              return  kind ;
            }
        }
        public string Country
        {
            private set { country = value; }
            get
            {
                return country;
            }
        }
        public string Capital
        {
             set { capital = value; }
            get
            {
                return capital;
            }
        }

       

        public Region(string name, double pop, double square, string _kind, string _country, string cap):base(name, pop, square)
        {
            Form = _kind;
            Country = _country;
            Capital = cap;

        }
        public void Set_Form(string value)
        {
           Form = value;
        }
        public void Set_Country(string value)
        {
           Country = value;
        }
        public void Set_Cap(string value)
        {
            Capital = value;
        }
    }

   
}
