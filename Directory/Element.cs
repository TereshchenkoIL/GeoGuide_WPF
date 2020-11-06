using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
     abstract class Element
    {
        protected string name;
        [JsonProperty]
        protected double population;
        [JsonProperty]
        protected double square;

        public string Name
        {
            private set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public double Population
        {
            private set
            {
                population = value;
            }
            get
            {
                return population;
            }
        }
        public double Square
        {
            private set
            {
                square = value;
            }
            get
            {
                return square;
            }
        }

        public Element(string _name, double _pop, double _square)
        {
            Name = _name;

            Population = _pop;

            Square = _square;
        }

        public void Set_Name(string name)
        {
            Name = name;
        }

        public void Set_Population(double pop)
        {
            Population = pop;
        }

        public void Set_Square(double square)
        {
            Square = square;
        }

    }
}
