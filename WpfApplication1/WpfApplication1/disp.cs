using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Linq;
namespace WpfApplication1
{

    class dispetcher
    {
        public string name;
        public int shtraf = 0;
        public int pogoda = 0;
        public int rec_pol;
        static string connectionString = @"Data Source=terminal211;Initial Catalog=kurs_rem;Integrated Security=True";
        static DataContext db = new DataContext(connectionString);
        public dispetcher(int s)
        {

            Table<Dispetch> users = db.GetTable<Dispetch>();
            Random rnd = new Random(DateTime.Now.Millisecond);
            name = rnd.Next(0, 10000).ToString();
            if (s == 1)
            {
                pogoda = rnd.Next(-200, 200);
            }
            else if (s == 2)
            {
                pogoda = rnd.Next(-350, 350);
            }
            else
            {
                pogoda = rnd.Next(-500, 500);
            }
           
            Dispetch user1 = new Dispetch { Name = rnd.Next(0, 10000).ToString(), Weather = pogoda};
            db.GetTable<Dispetch>().InsertOnSubmit(user1);
            db.SubmitChanges();
        }

        public void rec(int sp)
        {
            rec_pol = 7 * sp - pogoda;
        }




        public void prov(int sp)
        {
            if (sp - 300 >= rec_pol)
            {
                if (sp - 600 >= rec_pol)
                {
                    if (sp - 1000 >= rec_pol)
                    {
                        razb2();
                        return;
                    }
                    else
                    {
                        shtraf = shtraf + 50;
                        return;
                    }
                }
                else
                {
                    shtraf = shtraf + 25;
                    return;
                }
            }
            if (sp + 300 <= rec_pol)
            {
                if (sp + 600 <= rec_pol)
                {
                    if (sp + 1000 <= rec_pol)
                    {
                        razb2();
                        return;
                    }
                    else
                    {
                        shtraf = shtraf + 50;
                        return;
                    }
                }
                else
                {
                    shtraf = shtraf + 25;
                    return;
                }
            }
        }


        public void razb()
        {
            MessageBox.Show("you loose");
            Environment.Exit(1);

            
        }



        public void razb2()
        {
            MessageBox.Show("you loose");
            Environment.Exit(1);

        }













    }
}
