using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Admin_Log.xaml
    /// </summary>
    public partial class Admin_Log : Window
    {
        public Admin_Log()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = Admin_name.Text;
            string pas = Admin_pas.Password;

            if(name == "admin" && pas == "admin")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильний ввод", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
