using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class City : Element
    {
        [JsonProperty]
        private double latitude;
        [JsonProperty]
        private double longitude;

        public double Latitude
        {
            private set { latitude = value; }
            get
            {
                return latitude;
            }
        }

        public double Longitude
        {
            private set { longitude = value; }
            get
            {
                return longitude;
            }
        }


        public City(string name, double pop, double square, double latitude, double longitude) : base(name, pop, square)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public void Set_Latitude(double l)
        {
            Latitude = l;
        }

        public void Set_Longitude(double l)
        {
            Longitude = l;
        }
    }
}
