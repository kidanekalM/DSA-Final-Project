using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Drive_through.domain
{
    public class Order
    {

        public static domain.Queue<domain.Order> queue = new domain.Queue<domain.Order>();
        public Order() { }
        public string OrderName { get; set; }
        
        private List<Food> _foods;
        public List<Food> Foods 
        {
            get { return _foods; }
            set { _foods = value;
                _totalPrice = _totalTime = 0;
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
            get {
                    _totalTime = 0;
                foreach (Food food in _foods)
                {
                    _totalTime += food.TimeInMin;
                }
                return _totalTime; }
        }

        private double _totalPrice;
        public double TotalPrice
        {
            get {
                    _totalPrice = 0;
                foreach (Food food in _foods)
                {
                    _totalPrice += food.Price;
                }
                return _totalPrice; }
        }

    }
}
