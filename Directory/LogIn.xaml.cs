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
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        List<User> users;
        public LogIn()
        {
            users = new List<User>();
            InitializeComponent();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader("Users.json"))
            {
                using (JsonTextReader reader = new JsonTextReader(sr))
                {
                    users = (List<User>)serializer.Deserialize(reader, typeof(List<User>));

                }
            }
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            string name = user_name.Text;
            string pas = user_pas.Password;
      
            if (users.Where(x => (x.Name == name && x.Password == pas)).FirstOrDefault() != null)
            {
                MessageBox.Show("Добро пожаловать");
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
            }
            else if (users.Where(x => x.Name == name).FirstOrDefault() == null)
                MessageBox.Show("Користувача з таким іменем не існує");
            else
                MessageBox.Show("Неправильний пароль");

        }

        private void Register_Click(object sender, MouseButtonEventArgs e)
        {
            Register register = new Register();
            register.Show();
            Close();
        }

   

        private void Catch(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers.HasFlag(ModifierKeys.Shift) && e.Key == Key.F1)
            {
                Admin_Log admin = new Admin_Log();
                admin.Show();
                this.Close();
            }

        }
    }
}
