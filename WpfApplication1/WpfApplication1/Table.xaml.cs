using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data.Entity;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Linq;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Table.xaml
    /// </summary>
    public partial class Table : Window
    {
        public Table(int g)
        {
            InitializeComponent();
            if (g == 1)
            {
                Table<EScore> users = db.GetTable<EScore>();
                foreach (var user in users)
                {
                    EScore us = user;
                    listBox.Items.Add(us.Name+"   "+us.score);
                    
                }
            }
            else if (g == 2)
            {
                Table<MScore> users = db.GetTable<MScore>();
                foreach (var user in users)
                {
                    MScore us = user;
                    listBox.Items.Add(us);
                }
            }
            else
            {
                Table<HScore> users = db.GetTable<HScore>();
                foreach (var user in users)
                {
                    HScore us = user;
                    listBox.Items.Add(us);
                }
            }
        }
        static string connectionString = @"Data Source=terminal211;Initial Catalog=kurs_rem;Integrated Security=True";
        static DataContext db = new DataContext(connectionString);
        
    }
}
