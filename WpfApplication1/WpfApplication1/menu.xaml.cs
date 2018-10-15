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
using System.Data.Entity;
using System.Data.Linq;

namespace WpfApplication1
{
   
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        static string connectionString = @"Data Source=terminal211;Initial Catalog=kurs_rem;Integrated Security=True";
        public Window1(string str)
        {
            InitializeComponent();
            List<string> str1 = new List<string>();
            List<string> str2 = new List<string>();
            foreach (var user in users)
            {
                str1.Add(user.Name);
                str2.Add(user.password);
            }
            for (int i = 0; i < str1.Count; i++)
            {
                if (str1[i] == str)
                {
                   foreach(var user in users)
                    {
                        if(str==user.Name)
                        {
                            NK.Text = user.Name;
                            rek.Text = user.H_Sc.ToString();
                            if (user.mid == true)
                            {
                                medium.IsEnabled = true;
                            }
                            if (user.hard == true)
                            {
                                hard.IsEnabled = true;
                            }
                        }
                    }
                }
            }
        }
        static DataContext db = new DataContext(connectionString);


        Table<Nick> users = db.GetTable<Nick>();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int ge = 1;
            medium.IsEnabled = true;
            if (medium.IsChecked == true)
            {
                ge = 2;
                hard.IsEnabled = true;
            }
            else if (hard.IsChecked == true)
            {
                ge = 3;
            }
            Game g = new Game(ge,NK.Text);
            g.ShowDialog();

        }

        private void table_Click(object sender, RoutedEventArgs e)
        {
            int ge = 1;
            if (medium.IsChecked == true)
            {
                ge = 2;

            }
            else if (hard.IsChecked == true)
            {
                ge = 3;
            }
            
            Table t = new Table(ge);
            t.ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void easy_Checked(object sender, RoutedEventArgs e)
        {
            if (easy.IsChecked != null || medium.IsChecked != null || hard.IsChecked != null)
            {
                game.IsEnabled = true;

            }
            if (easy.IsChecked != null || medium.IsChecked != null || hard.IsChecked != null)
            {
                table.IsEnabled = true;

            }
        }

        private void medium_Checked(object sender, RoutedEventArgs e)
        {

            if (easy.IsChecked != null || medium.IsChecked != null || hard.IsChecked != null)
            {
                game.IsEnabled = true;

            }
            if (easy.IsChecked != null || medium.IsChecked != null || hard.IsChecked != null)
            {
                table.IsEnabled = true;

            }
        }

        private void hard_Checked(object sender, RoutedEventArgs e)
        {

            if (easy.IsChecked != null || medium.IsChecked != null || hard.IsChecked != null)
            {
                game.IsEnabled = true;

            }
            if (easy.IsChecked != null || medium.IsChecked != null || hard.IsChecked != null)
            {
                table.IsEnabled = true;

            }
        }
    }
}
