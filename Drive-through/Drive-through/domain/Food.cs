﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive_through.domain
{
    internal class Food
    {
        public int FoodID { get; set; }
        public Image FoodPic { get; set; }
        public string FoodType { get; set; }
        public string Name { get; set; }
        public int TimeInMin { get; set; }
        public double Price { get; set; }
        
    }
}
