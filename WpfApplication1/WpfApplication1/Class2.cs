using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace WpfApplication1
{
    [Table(Name = "Nicks")]
    public class Nick
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Name_")]
        public string Name { get; set; }
        [Column(Name= "Password_")]
        public String password { get; set; }
        [Column(Name = "Middle")]
        public bool mid { get; set; }
        [Column(Name = "hard")]
        public bool hard { get; set; }
        [Column(Name = "Hi_Score")]
        public int H_Sc { get; set; }
    }


    [Table(Name = "H_Score")]
    public class HScore
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Skore")]
        public int score { get; set; }
        [Column(Name = "Namee")]
        public String Name { get; set; }
       
    }

    [Table(Name = "M_Score")]
    public class MScore
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Skore")]
        public int score { get; set; }
        [Column(Name = "Namee")]
        public String Name { get; set; }

    }


    [Table(Name = "E_Score")]
    public class EScore
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Skore")]
        public int score { get; set; }
        [Column(Name = "Namee")]
        public String Name { get; set; }

    }


    [Table(Name = "Dispetchers")]
    public class Dispetch
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "Weather")]
        public int Weather { get; set; }
        [Column(Name = "Name_")]
        public String Name { get; set; }

    }



}
