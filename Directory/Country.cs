using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Country : Element, IAdministrative
    {
        [JsonProperty]
        private string form;
    
        private string capital;


        public string Capital
        {
             set
            {
                capital = value;
            }
            get
            {
                return capital;
            }
        }
        public string Form
        {
             set
            {
                form = value;
            }
            get
            {
                return form;
            }
        }

        public Country(string name, double pop, double square, string _form, string capital) : base(name, pop, square)
        {
            Form = _form;
            Capital = capital;

        }
      

        public void Set_Form(string form)
        {
            Form = form;
        }

        public void Set_Cap(string city)
        {
            Capital = city;
        }

        
    }
}
