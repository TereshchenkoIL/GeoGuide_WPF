using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Continent : Element
    {
        [JsonProperty]
        private double density;
        [JsonProperty]
        private string biggest_City;
        [JsonProperty]
        private double peak;
        [JsonProperty]
        private double lowest_point;

        public double Lowest_Point
        {
            private set
            {
               lowest_point = value;
            }
            get
            {
                return lowest_point;
            }
        }
        public double Peak
        {
            private set
            {
                peak = value;
            }
            get
            {
                return peak;
            }
        }
        public double Density
        {
            private set
            {
                density = value;
            }
            get
            {
                return density;
            }
        }

        public string Biggest_City
        {
            private set
            {
                biggest_City = value;
            }
            get
            {
                return biggest_City;
            }
        }


        public Continent(string name, double pop, double square, double density, string biggest, double peak, double lowest) : base(name, pop, square)
        {
            Density = density;
            Biggest_City = biggest;
            Peak = peak;
            Lowest_Point = lowest;
        }

        public void Set_Density(double dens)
        {
            Density = dens;
        }

        public void Set_City(string name)
        {
            Biggest_City = name;
        }

        public void Set_Peak(double peak)
        {
            Peak = peak;
        }

        public void Set_Lowest(double point)
        {
            Lowest_Point = point;
        }
    }
}
