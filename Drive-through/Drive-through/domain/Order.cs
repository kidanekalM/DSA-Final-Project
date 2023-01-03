using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Drive_through.domain
{
    internal class Order
    {
        public int OrderID { get; set; }
        
        private List<Food> _foods;
        public List<Food> Foods 
        {
            get { return _foods; }
            set { _foods = value;
                foreach(Food food in _foods)
                {
                    _totalTime += food.TimeInMin;
                    _totalPrice+= food.Price;
                }     
            }
        }
        private int _totalTime;
        public int TotalTime
        {
            set { _totalTime = value; }
            get { return _totalTime; }
        }

        private double _totalPrice;
        public double TotalPrice
        {
            get { return _totalPrice; }
        }


    }
}
