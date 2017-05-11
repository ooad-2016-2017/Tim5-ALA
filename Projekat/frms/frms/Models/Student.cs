using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Student
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Index { get; set; }
        public string Odsijek { get; set; }
    }
}
