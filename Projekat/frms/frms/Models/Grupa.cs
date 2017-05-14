﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frms.Models
{
    class Grupa
    {
        [AutoIncrement, PrimaryKey]
        public int ID { get; set; }

        public string Naziv { get; set; }
        public List<Student> Studenti { get; set; }
    }
}