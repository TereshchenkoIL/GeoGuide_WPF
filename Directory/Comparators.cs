using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Name_Comparer : IComparer<Element>
    {
        public int Compare(Element x, Element y)
        {
            return x.Name.CompareTo(y.Name);

        }
    }

    class Square_Comparer : IComparer<Element>
    {
        public int Compare(Element x, Element y)
        {
            return  -x.Square.CompareTo(y.Square);

        }
    }

    class Population_Comparer : IComparer<Element>
    {
        public int Compare(Element x, Element y)
        {
            return  -x.Population.CompareTo(y.Population);

        }
    }

    class Density_Comparator : IComparer<Continent>
    {
        public int Compare(Continent x, Continent y)
        {
            return x.Density.CompareTo(y.Density);
        }
    }

    class Peak_Comparator : IComparer<Continent>
    {
        public int Compare(Continent x, Continent y)
        {
            return x.Peak.CompareTo(y.Peak);
        }
    }

    class Lowest_Comparator : IComparer<Continent>
    {
        public int Compare(Continent x, Continent y)
        {
            return x.Lowest_Point.CompareTo(y.Lowest_Point);
        }
    }


}
