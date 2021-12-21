using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace PPRACT
{
    [Table(Name = "client")]
    class cl
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int ID { get; set; }
        [Column(Name = "Fname")]
        public string Fname { get; set; }
        [Column(Name = "Name")]
        public string Name { get; set; }
        [Column(Name = "Lname")]
        public string Lname { get; set; }
        [Column(Name = "Dateofbirth")]
        public DateTime Dateofbirth { get; set; }
        [Column(Name = "Town")]
        public string Town { get; set; }
        [Column(Name = "Adress")]
        public string Adress { get; set; }
        [Column(Name = "Telephone")]
        public int Telephone { get; set; }
        [Column(Name = "Passport")]
        public string Passport { get; set; }
        [Column(Name = "NomerID")]
        public int NomerID { get; set; }
    }
    [Table(Name = "nomer")]
    class n
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int ID { get; set; }
        [Column(Name = "Categoty")]
        public int Categoty { get; set; }
        [Column(Name = "Price")]
        public decimal Price { get; set; }
        [Column(Name = "KolviSpace")]
        public string KolviSpace { get; set; }
        [Column(Name = "Housemaid")]
        public int Housemaid { get; set; }
    }
    [Table(Name = "reservation")]
    class reserv
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "ID")]
        public int ID { get; set; }
        [Column(Name = "Client")]
        public int Client { get; set; }
        [Column(Name = "Date_check_in")]
        public DateTime Date_check_in { get; set; }
        [Column(Name = "Date_eviction")]
        public DateTime Date_eviction { get; set; }
        [Column(Name = "additionalServices")]
        public int additionalServices { get; set; }
        [Column(Name = "Cost")]
        public decimal Cost { get; set; }
    }
}
