using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Data.Entity;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Data.Linq.Mapping;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Data.Linq;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string connectionString = @"Data Source=terminal211;Initial Catalog=kurs_rem;Integrated Security=True";
        public MainWindow()
        {

            InitializeComponent();


        }
        static DataContext db = new DataContext(connectionString);


        Table<Nick> users = db.GetTable<Nick>();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            List<string> str1 = new List<string>();
            List<string> str2 = new List<string>();
            foreach (var user in users)
            {
                str1.Add(user.Name);
                str2.Add(user.password);
            }
            for (int i = 0; i < str1.Count; i++)
            {
                if (str1[i] == log.Text)
                {
                    if (str2[i] == par1.Password)
                    {
                        Window1 w = new Window1(str1[i]);
                        w.Show();
                        Close();
                    }
                }
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            List<string> str1 = new List<string>();
            List<string> str2 = new List<string>();
            int c = 0;
            foreach (var user in users)
            {
                str1.Add(user.Name);
                str2.Add(user.password);
                if (reg.Text == user.Name)
                {
                    c++;
                }
            }
            
            if (reg.Text != "")
            {
                if (par2.Password != "")
                {
                    if (c == 0)
                    {
                        Nick user1 = new Nick { Name = reg.Text, password = par2.Password, mid = false, hard = false, H_Sc = 0 };
                        db.GetTable<Nick>().InsertOnSubmit(user1);
                        db.SubmitChanges();
                        MessageBox.Show("Регистрация прошла успешно");
                    }
                }
            }
        }
    }
}
