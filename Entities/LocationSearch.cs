﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaApp.Entities
{
    public class LocationSearch
    {
        public int id { get; set; }
        public string city { get; set; }
        public int age { get; set; }

        public DateTime date { get; set; }
        //public LocationSearch(string city)
        //{
        //    this.city = city;
        //}
        public LocationSearch()
        {

        }
    }
}
