using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Directory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        World world;
        string State;
        GridView Cont;
        
        public MainWindow()
        {

            
            InitializeComponent();
            
            Prepare();
            #region init
            Cont = new GridView();
            Cont.AllowsColumnReorder = true;

            GridViewColumn c1 = new GridViewColumn();
            c1.DisplayMemberBinding = new Binding("Name");
            c1.Header = "Назва";
            c1.Width = 100;
            Cont.Columns.Add(c1);

            GridViewColumn c2 = new GridViewColumn();
            c2.DisplayMemberBinding = new Binding("Population");
            c2.Header = "Чисельність населення, млрд";
            c2.Width = 150;
            Cont.Columns.Add(c2);

            GridViewColumn c3 = new GridViewColumn();
            c3.DisplayMemberBinding = new Binding("Square");
            c3.Header = "Площа, км^2";
            c3.Width = 100;
            Cont.Columns.Add(c3);

            GridViewColumn c4 = new GridViewColumn();
            c4.DisplayMemberBinding = new Binding("Biggest_City");
            c4.Header = "Найбільше місто";
            c4.Width = 150;
            Cont.Columns.Add(c4);

            GridViewColumn c5 = new GridViewColumn();
            c5.DisplayMemberBinding = new Binding("Density");
            c5.Header = "Густота населення, л/км^2";
            c5.Width = 150;
            Cont.Columns.Add(c5);
            GridViewColumn c6 = new GridViewColumn();
            c6.DisplayMemberBinding = new Binding("Lowest_Point");
            c6.Header = "Найнижча точка, м";
            c6.Width = 150;
            Cont.Columns.Add(c6);
            GridViewColumn c7 = new GridViewColumn();
            c7.DisplayMemberBinding = new Binding("Peak");
            c7.Header = "Найвижча точка, м";
            c7.Width = 150;
            Cont.Columns.Add(c7);

            list.View = Cont;
            list.ItemsSource = world.continents;
#endregion


        }

        private void Continent_Checked(object sender, RoutedEventArgs e)
        {
            State = "Continent";
            #region listvCont

            if (list != null)
            {
                list.View = Cont;
                list.ItemsSource = null;
                list.ItemsSource = world.continents;
            }

            #endregion

            #region Sort_Cont
            if (Sort_Box != null)
            {
                Sort_Box.Items.Clear();
                ComboBoxItem it1 = new ComboBoxItem();
                it1.Content = "За площею";

                ComboBoxItem it2 = new ComboBoxItem();
                it2.Content = "За чисельністю населення";
                ComboBoxItem it3 = new ComboBoxItem();
                it3.Content = "За густиною населення";
                ComboBoxItem it4 = new ComboBoxItem();
                it4.Content = "За найвищою точкою";
                ComboBoxItem it5 = new ComboBoxItem();
                it5.Content = "За найнижчою точкою";
                ComboBoxItem it6 = new ComboBoxItem();
                it6.Content = "За назвою";


                Sort_Box.Items.Add(it1);
                Sort_Box.Items.Add(it2);
                Sort_Box.Items.Add(it3);
                Sort_Box.Items.Add(it4);
                Sort_Box.Items.Add(it5);
                Sort_Box.Items.Add(it6);

            }
            #endregion



        }

        private void City_Checked(object sender, RoutedEventArgs e)
        {
            State = "City";
            #region listvCity
            GridView myGridView = new GridView();
            myGridView.AllowsColumnReorder = true;

            GridViewColumn gvc1 = new GridViewColumn();
            gvc1.DisplayMemberBinding = new Binding("Name");
            gvc1.Header = "Назва";
            gvc1.Width = 100;
            myGridView.Columns.Add(gvc1);

            GridViewColumn gvc2 = new GridViewColumn();
            gvc2.DisplayMemberBinding = new Binding("Population");
            gvc2.Header = "Чисельність населення, тис";
            gvc2.Width = 200;
            myGridView.Columns.Add(gvc2);

            GridViewColumn gvc3 = new GridViewColumn();
            gvc3.DisplayMemberBinding = new Binding("Square");
            gvc3.Header = "Площа, км^2";
            gvc3.Width = 150;
            myGridView.Columns.Add(gvc3);
            list.View = myGridView;
            list.ItemsSource = null;
            list.ItemsSource = world.cities;
            #endregion

            #region Sort_City
            if (Sort_Box != null)
            {
                Sort_Box.Items.Clear();
                ComboBoxItem it1 = new ComboBoxItem();
                it1.Content = "За площею";

                ComboBoxItem it2 = new ComboBoxItem();
                it2.Content = "За чисельністю населення";

                ComboBoxItem it3 = new ComboBoxItem();
                it3.Content = "За назвою";

                Sort_Box.Items.Add(it1);
                Sort_Box.Items.Add(it2);
                Sort_Box.Items.Add(it3);

            }
            #endregion


        }

        private void Country_Checked(object sender, RoutedEventArgs e)
        {
            State = "Country";
            #region listvCountry
            GridView myGridView = new GridView();
            myGridView.AllowsColumnReorder = true;

            GridViewColumn gvc1 = new GridViewColumn();
            gvc1.DisplayMemberBinding = new Binding("Name");
            gvc1.Header = "Назва";
            gvc1.Width = 100;
            myGridView.Columns.Add(gvc1);

            GridViewColumn gvc2 = new GridViewColumn();
            gvc2.DisplayMemberBinding = new Binding("Population");
            gvc2.Header = "Чисельність населення,млн";
            gvc2.Width = 150;
            myGridView.Columns.Add(gvc2);

            GridViewColumn gvc3 = new GridViewColumn();
            gvc3.DisplayMemberBinding = new Binding("Square");
            gvc3.Header = "Площа,тис.км^2";
            gvc3.Width = 100;
            myGridView.Columns.Add(gvc3);

            GridViewColumn gvc4 = new GridViewColumn();
            gvc4.DisplayMemberBinding = new Binding("Capital");
            gvc4.Header = "Столиця";
            gvc4.Width = 150;

            myGridView.Columns.Add(gvc4);

            GridViewColumn gvc5 = new GridViewColumn();
            gvc5.DisplayMemberBinding = new Binding("Form");
            gvc5.Header = "Форма правління";
            gvc5.Width = 150;

            myGridView.Columns.Add(gvc5);



            list.View = myGridView;
            list.ItemsSource = null;
            list.ItemsSource = world.countries;


            #endregion

            #region Sort_Count
            if (Sort_Box != null)
            {
                Sort_Box.Items.Clear();
                ComboBoxItem it1 = new ComboBoxItem();
                it1.Content = "За площею";

                ComboBoxItem it2 = new ComboBoxItem();
                it2.Content = "За чисельністю населення";
                ComboBoxItem it3 = new ComboBoxItem();
                it3.Content = "За назвою";

                Sort_Box.Items.Add(it1);
                Sort_Box.Items.Add(it2);
                Sort_Box.Items.Add(it3);
            }
            #endregion
        }

        private void Region_Checked(object sender, RoutedEventArgs e)
        {
            State = "Region";
            #region listvRegion
            GridView myGridView = new GridView();
            myGridView.AllowsColumnReorder = true;

            GridViewColumn gvc1 = new GridViewColumn();
            gvc1.DisplayMemberBinding = new Binding("Name");
            gvc1.Header = "Назва";
            gvc1.Width = 100;
            myGridView.Columns.Add(gvc1);

            GridViewColumn gvc2 = new GridViewColumn();
            gvc2.DisplayMemberBinding = new Binding("Population");
            gvc2.Header = "Чисельність населення,млн";
            gvc2.Width = 150;
            myGridView.Columns.Add(gvc2);

            GridViewColumn gvc3 = new GridViewColumn();
            gvc3.DisplayMemberBinding = new Binding("Square");
            gvc3.Header = "Площа,км^2";
            gvc3.Width = 100;
            myGridView.Columns.Add(gvc3);

            GridViewColumn gvc4 = new GridViewColumn();
            gvc4.DisplayMemberBinding = new Binding("Country");
            gvc4.Header = "Країна";
            gvc4.Width = 150;

            myGridView.Columns.Add(gvc4);

            GridViewColumn gvc5 = new GridViewColumn();
            gvc5.DisplayMemberBinding = new Binding("Form");
            gvc5.Header = "Вид";
            gvc5.Width = 70;

            myGridView.Columns.Add(gvc5);

            GridViewColumn gvc6 = new GridViewColumn();
            gvc6.DisplayMemberBinding = new Binding("Capital");
            gvc6.Header = "Столиця";
            gvc6.Width = 100;

            myGridView.Columns.Add(gvc6);



            list.View = myGridView;

            list.ItemsSource = null;
            list.ItemsSource = world.regions;




            #endregion

            #region Sort_Reg
            if (Sort_Box != null)
            {
                Sort_Box.Items.Clear();
                ComboBoxItem it1 = new ComboBoxItem();
                it1.Content = "За площею";

                ComboBoxItem it2 = new ComboBoxItem();
                it2.Content = "За чисельністю населення";

                ComboBoxItem it3 = new ComboBoxItem();
                it3.Content = "За назвою";

                Sort_Box.Items.Add(it1);
                Sort_Box.Items.Add(it2);
                Sort_Box.Items.Add(it3);
            }
            #endregion

        }

       

        private void Sort_Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string sort = Sort_Box.SelectedItem.ToString().Substring(37).Trim();

                switch (State)
                {

                    case "City":
                        if (sort == "За назвою")
                            world.CitySort(new Name_Comparer());
                        else if (sort == "За площею")
                            world.CitySort(new Square_Comparer());
                        else if (sort == "За чисельністю населення")
                            world.CitySort(new Population_Comparer());
                        list.ItemsSource = null;
                        list.ItemsSource = world.cities;
                        break;

                    case "Country":
                        if (sort == "За назвою")
                            world.CountrySort(new Name_Comparer());
                        else if (sort == "За площею")
                            world.CountrySort(new Square_Comparer());
                        else if (sort == "За чисельністю населення")
                            world.CountrySort(new Population_Comparer());
                        list.ItemsSource = null;
                        list.ItemsSource = world.countries;
                        break;

                    case "Region":
                        if (sort == "За назвою")
                            world.RegionSort(new Name_Comparer());
                        else if (sort == "За площею")
                            world.RegionSort(new Square_Comparer());
                        else if (sort == "За чисельністю населення")
                            world.RegionSort(new Population_Comparer());
                        list.ItemsSource = null;
                        list.ItemsSource = world.regions;
                        break;

                    case "Continent":
                        if (sort == "За назвою")
                            world.ContinentSort(new Name_Comparer());
                        else if (sort == "За площею")
                            world.ContinentSort(new Square_Comparer());
                        else if (sort == "За чисельністю населення")
                            world.ContinentSort(new Population_Comparer());
                        else if (sort == "За густиною населення")
                            world.ContinentSort(new Density_Comparator());
                        else if (sort == "За найвищою точкою")
                            world.ContinentSort(new Peak_Comparator());
                        else if (sort == "За найнижчою точкою")
                            world.ContinentSort(new Lowest_Comparator());
                        list.ItemsSource = null;
                        list.ItemsSource = world.continents;
                        break;




                }


            }
            catch (Exception ex)
            {

            }

        }

        private void Click(object sender, MouseButtonEventArgs e)
        {
            if (list.SelectedItem is City)
            {

                City cur = (City)list.SelectedItem;
                map.Center = new Microsoft.Maps.MapControl.WPF.Location(cur.Latitude, cur.Longitude);
                map.ZoomLevel = 8;
            }
            else if (list.SelectedItem is Country)
            {
                Country count = (Country)list.SelectedItem;
                City cur = world.FindCity(count.Capital);
                if (cur != null)
                {


                    map.Center = new Microsoft.Maps.MapControl.WPF.Location(cur.Latitude, cur.Longitude);
                    map.ZoomLevel = 4;
                }
                else
                    MessageBox.Show("Не знайдено столицю країни, зверніться до служби підтримки");
            }
            else if (list.SelectedItem is Continent)
            {
                Continent cont = (Continent)list.SelectedItem;
                if (cont.Name.ToLowerInvariant() == "євразія")
                {
                    map.Center = new Microsoft.Maps.MapControl.WPF.Location(49, 23);
                    map.ZoomLevel = 3;
                    return;
                }
                else if (cont.Name.ToLowerInvariant() == "африка")
                {
                    map.Center = new Microsoft.Maps.MapControl.WPF.Location(3, 12);
                    map.ZoomLevel = 3;
                    return;
                }
                else if (cont.Name.ToLowerInvariant() == "австралія")
                {
                    map.Center = new Microsoft.Maps.MapControl.WPF.Location(-26, 133);
                    map.ZoomLevel = 3;
                    return;
                }
                else if (cont.Name.ToLowerInvariant() == "північна америка")
                {
                    map.Center = new Microsoft.Maps.MapControl.WPF.Location(65, -80);
                    map.ZoomLevel = 3;
                    return;
                }
                else if (cont.Name.ToLowerInvariant() == "південна америка")
                {
                    map.Center = new Microsoft.Maps.MapControl.WPF.Location(-30, -60);
                    map.ZoomLevel = 3;
                    return;
                }
                else if (cont.Name.ToLowerInvariant() == "антарктида")
                {
                    map.Center = new Microsoft.Maps.MapControl.WPF.Location(-70, 0);
                    map.ZoomLevel = 3;
                    return;
                }
            }
            else if (list.SelectedItem is Region)
            {
                Region region = (Region)list.SelectedItem;
                City cur = world.FindCity(region.Capital);
                if (cur != null)
                {


                    map.Center = new Microsoft.Maps.MapControl.WPF.Location(cur.Latitude, cur.Longitude);
                    map.ZoomLevel = 6;
                    return;
                }

                Country c = world.FindCountry(region.Country);
                if (c != null)
                {
                    City fromcountry = world.FindCity(c.Capital);
                    if (fromcountry != null)
                    {


                        map.Center = new Microsoft.Maps.MapControl.WPF.Location(fromcountry.Latitude, fromcountry.Longitude);
                        map.ZoomLevel = 6;
                        return;
                    }
                }

                MessageBox.Show("Не знайдено область, зверніться до служби підтримки");

            }
        }


        private void Search_Click(object sender, RoutedEventArgs e)
        {

            string name = Search_Box.Text.ToLowerInvariant();

            var City = world.FindCity(name);
            var Country = world.FindCountry(name);
            var Continent = world.FindContinent(name);
            var Region = world.FindRegion(name);

            if (City != null)
            {
                List<City> l = new List<City>();
                l.Add(City);
                City_Checked(this, null);
                list.ItemsSource = l;
                return;
            }
            else if (Country != null)
            {
                List<Country> l = new List<Country>();
                l.Add(Country);
                Country_Checked(this, null);
                list.ItemsSource = l;
            }
            else if (Continent != null)
            {
                List<Continent> l = new List<Continent>();
                l.Add(Continent);
                Continent_Checked(this, null);
                list.ItemsSource = l;
            }
            else if (Region != null)
            {
                List<Region> l = new List<Region>();
                l.Add(Region);
                Region_Checked(this, null);
                list.ItemsSource = l;
            }
            else
                MessageBox.Show("Не удалось найти \n попробуйте снова");
        }
        public void Prepare()
        {
            Saver saver = new Saver();
            world = saver.Load();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            help.Owner = this;
            help.Show();
        }
    }
}
