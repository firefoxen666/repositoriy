using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Linq;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        int gem = 0;
        string je = "";
        static string connectionString = @"Data Source=terminal211;Initial Catalog=kurs_rem;Integrated Security=True";
        static DataContext db = new DataContext(connectionString);

        public Game(int z, string gtn)
        {
            je = gtn;
            InitializeComponent();
            MessageBox.Show("↑(+250м) shift+↑(+500м) →(+50км/ч) shift+→(+150км/ч) ↓(-250м) shift+↓(-500м) ←(-50км/ч) shift+←(-150км/ч)");
            gem = z;
            p = new plane(gem);



        }
        public void win(int d)
        {



            MessageBox.Show($"you win\n your score:{d}");
            if (gem == 1)
            {
                Table<EScore> users = db.GetTable<EScore>();
                EScore user1 = new EScore { Name = je, score = d };
                db.GetTable<EScore>().InsertOnSubmit(user1);
                db.SubmitChanges();
                Table<Nick> users1 = db.GetTable<Nick>();
                foreach (var user in users1)
                {
                    if (user.Name == je)
                    {
                        user.mid = true;
                    }
                }
                db.SubmitChanges();
            }
            if (gem == 2)
            {
                Table<MScore> users = db.GetTable<MScore>();
                MScore user1 = new MScore { Name = je, score = d };
                db.GetTable<MScore>().InsertOnSubmit(user1);
                db.SubmitChanges();
                Table<Nick> users1 = db.GetTable<Nick>();
                foreach (var user in users1)
                {
                    if (user.Name == je)
                    {
                        user.hard = true;
                        if (user.H_Sc < d)
                        {
                            user.H_Sc = d;
                        }
                    }
                }
                db.SubmitChanges();
            }
            if (gem == 3)
            {
                Table<HScore> users = db.GetTable<HScore>();
                HScore user1 = new HScore { Name = je, score = d };
                db.GetTable<HScore>().InsertOnSubmit(user1);
                db.SubmitChanges();
            }
            this.Close();

        }

        delegate void operation(int sped);

        class plane
        {
            public int speed = 0;

            public int high = 0;
            public List<dispetcher> disp = new List<dispetcher>();
            public plane(int ge)
            {
                int ch = 2;

                for (int i = 0; i < ch; i++)
                {
                    dispetcher c = new dispetcher(ge);
                    disp.Add(c);
                }


            }

















        }

        plane p;

        private void d2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        public void sh()
        {
            Speed.Text = p.speed.ToString();
            High.Text = p.high.ToString();
        }

        public void menu1(KeyEventArgs ke)
        {

            operation[] ope = new operation[p.disp.Count];
            for (int i = 0; i < p.disp.Count; i++)
            {
                ope[i] = new operation(p.disp[i].prov);
            }










            if (ke.Key == Key.Up)
            {
                if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                { p.high = p.high + 500; }
                else { p.high = p.high + 250; }

            }
            else if (ke.Key == Key.Down)
            {
                if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                {
                    p.high = p.high - 500;
                }
                else
                {
                    p.high = p.high - 250;
                }
            }
            else if (ke.Key == Key.Left)
            {
                if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                {
                    p.speed = p.speed - 150;

                }
                else
                {
                    p.speed = p.speed - 50;
                }
            }
            else if (ke.Key == Key.Right)
            {
                if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))
                {
                    p.speed = p.speed + 150;
                }
                else
                {
                    p.speed = p.speed + 50;

                }
            }
            else
            {
                Environment.Exit(0);
            }



            if (p.speed == 1000)
            {


            }
            else if (p.speed < 0 && p.high < 0)
            {
                p.disp[0].razb();
            }

            if (p.speed > 1000)
            {
                for (int i = 0; i < p.disp.Count; i++)
                {
                    p.disp[i].shtraf = p.disp[i].shtraf + 100;



                }
            }


            if (p.speed == 0 && p.high != 0)
            {
                st(10000);
            }




            if (p.speed >= 200 && p.high == 0)
            {

                st(10000);
            }



            if (p.high < 0 || p.speed < 0)
            {
                st(10000);
            }






            if (p.high == 0 && p.speed == 0)
            {

            }
            else if (p.speed >= 50)
            {
                for (int i = 0; i < p.disp.Count; i++)
                {

                    p.disp[i].rec_pol = 7 * p.speed - p.disp[i].pogoda;



                    ope[i](p.high);
                }


            }


            Speed.Text = p.speed.ToString();
            High.Text = p.high.ToString();
            int ce = 0;




            d1.Text = p.disp[0].rec_pol.ToString();
            Shtr1.Text = p.disp[0].shtraf.ToString();
            d2.Text = p.disp[1].rec_pol.ToString();
            Shtr2.Text = p.disp[1].shtraf.ToString();
            ce = 4;


        }
        public void st(int oc)
        {
            if (oc >= 1000)
            {

                MessageBox.Show("you loose");
                this.Close();

            }
        }

        int sches = 0;
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {

            int pe = 0;
            if (e.Key == Key.Up || e.Key == Key.Right || e.Key == Key.Left || e.Key == Key.Down)
                menu1(e);

            pe = p.speed;
            if (p.speed == 1000)
            {
                MessageBox.Show("снижайтесь");
                sches = 1;
            }
            if (sches == 1)
            {
                if (p.speed == 0)
                {
                    if (p.high == 0)
                    {
                        int c = 1000;
                        if (p.disp[0].shtraf > p.disp[1].shtraf)
                        {
                            c = c - p.disp[0].shtraf;

                        }
                        else
                        {
                            c = c - p.disp[1].shtraf;
                        }
                        win(c);
                    }
                }
            }

        }
    }
}
