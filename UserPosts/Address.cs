﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UserPosts
{
    public class Address
    {
        public string street {  get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public Geo geo { get; set; }
    }
}
