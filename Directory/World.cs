using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Directory
{
    class World
    {
        public List<City> cities;
        public List<Country> countries;
        public List<Region> regions;
        public List<Continent> continents;
         public World(List<City> c, List<Continent> cont, List<Country> count, List<Region> reg)
        {
            cities = c;
            countries = count;
            continents = cont;
            regions = reg;
        }
        public World()
        {

        }

        #region Sorts
        public void CitySort(IComparer<City> comparer)
        {
            cities.Sort(comparer);
        }
        public void CountrySort(IComparer<Country> comparer)
        {
            countries.Sort(comparer);
        }
        public void ContinentSort(IComparer<Continent> comparer)
        {
         continents.Sort(comparer);
        }
        public void RegionSort(IComparer<Region> comparer)
        {
           regions.Sort(comparer);
        }
        #endregion

        #region Find
        public City FindCity(string name)
        {
            return cities.Where(x => x.Name.ToLowerInvariant() == name.ToLowerInvariant()).FirstOrDefault();
        }

        public Country  FindCountry(string name)
        {
            return countries.Where(x => x.Name.ToLowerInvariant() == name.ToLowerInvariant()).FirstOrDefault();
        }

        public Continent FindContinent(string name)
        {
            return continents.Where(x => x.Name.ToLowerInvariant() == name.ToLowerInvariant()).FirstOrDefault();
        }
        public Region FindRegion(string name)
        {
            return regions.Where(x => x.Name.ToLowerInvariant() == name.ToLowerInvariant()).FirstOrDefault();
        }
        #endregion

        #region Add
        public void Add_City(string name, double pop_count, double square, double lat, double lon)
        {
         
            if (cities.Count() > 0 && cities.Where(x => x.Name == name).FirstOrDefault() == null)
            {
                cities.Add(new City(name, pop_count, square, lat, lon));
                MessageBox.Show("Збережено");
               
            }
            else if (cities.Count == 0)
            {
                cities.Add(new City(name, pop_count, square, lat, lon));
                MessageBox.Show("Збережено");
              
            }
            else
                MessageBox.Show("Таке місто вже існує");
        }

        public void Add_Country(string name, double pop_count, double square, string form, string cap)
        {
        
            if (countries.Count() > 0 && countries.Where(x => x.Name == name).Count() == 0)
            {
                Country c = new Country(name, pop_count, square, form, cap);

                countries.Add(c);
                MessageBox.Show("Збережено");
               
            }
            else if (countries.Count() == 0)
            {
                Country c = new Country(name, pop_count, square, form, cap);
                countries.Add(c);
                MessageBox.Show("Збережено");
               
            }
            else
            {
                MessageBox.Show("Така країна вже існує");
            }
        }

        public void Add_Continent(string name, double pop, double square, double dens, string biggest, double peak, double lowest)
        {
         
            if (continents.Count() > 0 && continents.Where(x => x.Name == name).FirstOrDefault() == null)
            {
                Continent c = new Continent(name, pop, square, dens, biggest, peak, lowest);
                continents.Add(c);
                MessageBox.Show("Збережено");
            }
            else if (continents.Count() == 0)
            {
                Continent c = new Continent(name, pop, square, dens, biggest, peak, lowest);
                continents.Add(c);
                MessageBox.Show("Збережено");
            }
            else
                MessageBox.Show("Такий континент вже існує");
        }

        public void Add_Region(string name, double pop, double square, string kind, string count, string cap)
        {
            if (regions.Count() > 0 && regions.Where(x => x.Name == name).FirstOrDefault() == null)
            {
                Region r = new Region(name, pop, square, kind, count, cap);
                regions.Add(r);
                MessageBox.Show("Збережено");
            }
            else if (regions.Count() == 0)
            {
                Region r = new Region(name, pop, square, kind, count, cap);
                regions.Add(r);
                MessageBox.Show("Збережено");
            }
            else
            {
                MessageBox.Show("Такий регіон вже існує");
            }
        }
        #endregion

        #region Delete
         public void Delet_City(string name)
        {
            var delet_elem = cities.Where(x => x.Name == name).FirstOrDefault();
            if (delet_elem != null)
            {
                cities.Remove(delet_elem);
                MessageBox.Show("Видалено");
            }
            else
                MessageBox.Show("Такого міста немає", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

        }
        public void Delet_Country(string name)
        {
            Country del_elem = countries.Where(x => x.Name == name).FirstOrDefault();
            if (del_elem != null)
            {
                countries.Remove(del_elem);
                MessageBox.Show("Видалено");
            }
            else
            {
                MessageBox.Show("Немає країни з такою назвою");
            }
        }
        public void Delet_Continent(string name)
        {
            Continent del_elem = continents.Where(x => x.Name == name).FirstOrDefault();
            if (del_elem != null)
            {
                continents.Remove(del_elem);
                MessageBox.Show("Видалено");
            }
            else
            {
                MessageBox.Show("Немає материка з такою назвою");
            }
        }
        public void Delet_Region(string name)
        {
            Region del_elem = regions.Where(x => x.Name == name).FirstOrDefault();
            if (del_elem != null)
            {
                regions.Remove(del_elem);
                MessageBox.Show("Видалено");
            }
            else
            {
                MessageBox.Show("Немає материка з такою назвою");
            }
        }

        #endregion

        
     



    }
}
