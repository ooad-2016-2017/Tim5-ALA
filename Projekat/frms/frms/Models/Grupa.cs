using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Grupa
    {
        public string ID { get; set; }

        public string Naziv { get; set; }
        public List<Student> Studenti { get; set; } = new List<Student>();
    }
}
