﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    public class Person
    {
        public long id { get; set; }

        public string firstNmae { get; set; }

        public string lastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set }
    }
}
