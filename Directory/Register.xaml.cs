using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Directory
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        List<User> users;
        JsonSerializer serializer = new JsonSerializer();
        public Register()
        {
            InitializeComponent();
            users = new List<User>();
            using (StreamReader sr = new StreamReader("Users.json"))
            {
                using (JsonTextReader reader = new JsonTextReader(sr))
                {
                    users = (List<User>)serializer.Deserialize(reader, typeof(List<User>));

                }
            }
        }
        

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string n = name.Text;
            string pas = first_pas.Password;
            string pas2 = second_pas.Password;

            if( n != "" && pas != "" && pas2 != "" && pas == pas2 )
            {
                if (users.Where(x => x.Name == n).FirstOrDefault() == null)
                {
                    users.Add(new User(n, pas));

                    using (StreamWriter writer = new StreamWriter("Users.json"))
                    {
                        using (JsonWriter jw = new JsonTextWriter(writer))
                        {
                            serializer.Serialize(jw, users);

                        }
                    }
                    MessageBox.Show("Зарегістровано");
                    LogIn logIn = new LogIn();
                    this.Close();
                    logIn.Show();
                    
                }else
                    MessageBox.Show("Такий користувач вже існує", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


            }
            else
                MessageBox.Show("Паролі не збігаються", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
