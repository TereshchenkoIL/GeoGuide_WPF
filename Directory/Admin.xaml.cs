using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;


namespace Directory
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        World world;
      
        GridView Cont;

        string State;
        public Admin()
        {

            
            InitializeComponent();

            world = new World();
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

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


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
                            world.CitySort( new Name_Comparer());
                        else if (sort == "За площею")
                            world.CitySort(new Square_Comparer());
                        else if (sort == "За чисельністю населення")
                            world.CitySort(new Population_Comparer());
                        list.ItemsSource = null;
                        list.ItemsSource = world.cities;
                        break;

                    case "Country":
                        if (sort == "За назвою")
                            world.CountrySort( new Name_Comparer());
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
                           world.ContinentSort( new Name_Comparer());
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
                        list.ItemsSource =  world.continents;
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
                City cur =world.FindCity(count.Capital);
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
                    map.ZoomLevel =3;
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void City_add_Click(object sender, RoutedEventArgs e)
        {
            string name = city_name_add.Text;
           double pop_count = -1;
            double square = -1;
            double lat = 190;
            double lon = 190;
            try
            {
                pop_count = double.Parse(city_pop_add.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() +" в населенні", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
                square = double.Parse(city_square_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()+" в площі", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
                lat = double.Parse(city_lat_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()+" в широті", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
              
            }
            try
            {
                lon = double.Parse(city_long_add.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в довготі", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if(pop_count > 0 && square > 0 && lat != 190 && lon != 190 && name !="")
            {
                world.Add_City(name, pop_count, square, lat, lon);
            }else
            {

                MessageBox.Show("Неправильний ввод", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void City_Delete_Click(object sender, RoutedEventArgs e)
        {
            string name = city_delete.Text;
            world.Delet_City(name);

        }

        private void City_Edit_Click(object sender, RoutedEventArgs e)
        {
            string name = city_name_ed.Text;
            if (world.FindCity(name) == null)
            {
                MessageBox.Show("Міста з такою назвою не має");
                return;
            }
            var c = world.FindCity(name);

            double pop_count = -1;
            double  square = -1;
            double lat = 361;
            double lon = 361;
            try
            {
                if(city_pop_ed.Text!= "")
                pop_count = double.Parse(city_pop_ed.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в населенні", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
                if(city_square_ed.Text != "")
                square = double.Parse(city_square_ed.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() +" в площі", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
                if(city_lat_ed.Text != "")
                lat = double.Parse(city_lat_ed.Text);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в широті", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                lat = 361;
            }
            try
            {
                if(city_long_ed.Text != "")
                lon = double.Parse(city_long_ed.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в довготі", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                lon = 361;
            }
          
            if(square > 0)
            {
              
                c.Set_Square(square);
               
            }
            if (pop_count > 0)
            {
                c.Set_Population(pop_count);
            }
            if (lat != 361)
            {
                c.Set_Latitude(lat);
            }
            if (lon != 361)
            {
               c.Set_Longitude(lon);
            }

            list.ItemsSource = null;
            list.ItemsSource = world.cities;
            MessageBox.Show("Змінено");
        }

        private void Country_Add_Click(object sender, RoutedEventArgs e)
        {
            string name = country_name_add.Text;
            double pop_count = -1;
            double square = -1;
            string form = country_form_add.Text;
            string cap = country_cap_add.Text;
            try
            {
                pop_count = double.Parse(country_pop_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()+ " в населенні", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
                square = double.Parse(country_square_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в площі", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
          
            if(pop_count > 0 && square > 0 && form != "" && cap != "" && name !="" )
            {
                world.Add_Country(name, pop_count, square, form, cap);
               
            }
        }

        private void Country_Del_Click(object sender, RoutedEventArgs e)
        {
            string name = country_del.Text;
            world.Delet_Country(name);
        }

        private void Country_Edit_Click(object sender, RoutedEventArgs e)
        {
            string name = country_name_ed.Text;
            var c = world.FindCountry(name);
            if(c == null)
            {
                MessageBox.Show("Країни з такою назвою не має");
                return;
            }
         
            double pop_count = -1;
            double square = -1;
            string form = country_form_ed.Text;
            string cap = country_cap_ed.Text;
            try
            {
                if(country_pop_ed.Text != "")
                pop_count = double.Parse(country_pop_ed.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в населенні", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
                if(country_square_ed.Text != "")
                square = double.Parse(country_square_ed.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в площі", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if(pop_count > 0)
            {
                c.Set_Population(pop_count);
            }
            if(square > 0)
            {
                c.Set_Square(square);
            }
            if(form != "")
            {
                c.Set_Form(form);
            }
            if(cap != "")
            {
                c.Set_Cap(cap);
            }

            MessageBox.Show("Змінено");
        }

        private void Continent_Add_Click(object sender, RoutedEventArgs e)
        {
            string name = cont_name_add.Text;
            double pop = -1;
            double square = -1;
            double peak = -1;
            double lowest = -1;
            string biggest = cont_biggest_add.Text;
            double dens = -1;

            try
            {
                pop = double.Parse(cont_pop_add.Text);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в населенні", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                square = double.Parse(cont_square_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в площі", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                peak = double.Parse(cont_peak_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()+ " в найаищій точці", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                lowest = double.Parse(cont_lowest_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в найнижчій", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
               dens = double.Parse(cont_dens_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в густоті", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
            if (pop > 0 && square > 0 && dens > 0 && biggest != "" && name != "")
            {
                world.Add_Continent(name, pop, square, dens, biggest, peak, lowest);
               
               
            }
            else
                MessageBox.Show("Перевірте ввод", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


        }

        private void Continent_Delete_Click(object sender, RoutedEventArgs e)
        {
            string name = cont_delete.Text;
            world.Delet_Continent(name);

        }

        private void Continent_Ed_Click(object sender, RoutedEventArgs e)
        {
            string name = cont_name_ed.Text;
            double pop = -1;
            double square = -1;
            double peak = -1;
            double lowest = -1;
            string biggest = cont_biggest_ed.Text;
            double dens = -1;
            Continent cont = world.FindContinent(name);
            if(cont == null)
            {
                MessageBox.Show("Немає материка з такою назвою");
                return;
            }

            try
            {
                if(cont_pop_ed.Text != "")
                pop = double.Parse(cont_pop_ed.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                if (cont_square_ed.Text != "")
                    square = double.Parse(cont_square_ed.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                if (cont_peak_ed.Text != "")
                    peak = double.Parse(cont_peak_ed.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                if (cont_lowest_ed.Text != "")
                    lowest = double.Parse(cont_lowest_ed.Text);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                if (cont_dens_ed.Text != "")
                    dens = double.Parse(cont_dens_ed.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (cont != null)
            {
                if (pop > 0)
                    cont.Set_Population(pop);
                if (square > 0)
                    cont.Set_Square(square);
                if (peak != -1)
                    cont.Set_Peak(peak);
                if (lowest != -1)
                    cont.Set_Lowest(lowest);
                if (dens > 0)
                    cont.Set_Density(dens);
                if (biggest != "")
                    cont.Set_City(biggest);

              
                MessageBox.Show("Змінено");
            }

        }

        private void Region_Add_Click(object sender, RoutedEventArgs e)
        {
            string name = region_name_add.Text;
            double pop = -1;
            double square = -1;
            string count = region_count_add.Text;
            string cap = region_cap_add.Text;
            string kind = region_kind_add.Text;
            try
            {
                pop = double.Parse(region_pop_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в населенні", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                square = double.Parse(region_square_add.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " в площі", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (pop > 0 && square > 0 && count != "" && cap != "" && kind !="" && name != "")
            {
                world.Add_Region(name, pop, square, kind, count, cap);

            }
        }

        private void Region_Delete_Click(object sender, RoutedEventArgs e)
        {
            string name = region_delete.Text;
           
            world.Delet_Region(name);
            list.ItemsSource = null;

        }

        private void Region_Ed_Click(object sender, RoutedEventArgs e)
        {
            string name = region_name_ed.Text;
            double pop = -1;
            double square = -1;
            string country = region_count_ed.Text;
            string cap = region_cap_ed.Text;
            string kind = region_kind_ed.Text;
            Region r = world.FindRegion(name);

            try
            {
                pop = double.Parse(region_pop_ed.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString() + " в населенні", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
            try
            {
                square = double.Parse(region_square_ed.Text);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString() + " в площі", "Error", MessageBoxButton.OK, MessageBoxImage.Error); }
            if (r == null)
            {
                MessageBox.Show("Немає регіона з такою назвою");
                return;
            }
          
            if (pop > 0)
            {
                MessageBox.Show(pop.ToString());
                r.Set_Population(pop);
            }
            if (square > 0)
                r.Set_Square(square);
            if (country != "")
                r.Set_Country(country);
            if (cap != "")
                r.Set_Cap(cap);
            if (kind != "")
                r.Set_Form(kind);

           
            MessageBox.Show("Змінено");

        }

       

        public void Prepare()
        {
            Saver saver = new Saver();
            world = saver.Load();
        }

      

        private void Close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Saver saver = new Saver();
            saver.Save(world);
        }
    }
}

