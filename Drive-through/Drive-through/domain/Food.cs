using Drive_through.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive_through.domain
{

    internal class Food
    {
        public Image FoodPic { get; set; }
        public string FoodType { get; set; }
        public string Name { get; set; }
        public int TimeInMin { get; set; } = 10;
        public double Price { get; set; } = 200;
        
        public static Tree FoodTree = new Tree();
        public static List<Food> Burgers = new List<Food>();
        public static List<Food> Pizza = new List<Food>();
        public static List<Food> Drinks = new List<Food>();
        public Food() { }
        static Food()
        {
            /***
             * Add foods
             */
            Food food = new Food();
            food.Name = "Cheese Burger";
            food.FoodType = "Burger";
            food.FoodPic = global::Drive_through.Properties.Resources.CheeseBurger;
            Burgers.Add(food);  
            food.add(food);
            food = new Food();
            food.Name = "Beef Burger";
            food.FoodType = "Burger";
            food.FoodPic = global::Drive_through.Properties.Resources.beefBurger;
            Burgers.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Chicken Burger";
            food.FoodType = "Burger";
            food.FoodPic = global::Drive_through.Properties.Resources.chickenBurger;
            Burgers.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Double Burger";
            food.FoodType = "Burger";
            food.FoodPic = global::Drive_through.Properties.Resources.doubleBurger;
            Burgers.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Salmon Burger";
            food.FoodType = "Burger";
            food.FoodPic = global::Drive_through.Properties.Resources.salmonBurger;
            Burgers.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Turkey Burger";
            food.FoodType = "Burger";
            food.FoodPic = global::Drive_through.Properties.Resources.turkeyBurger;
            Burgers.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Vegan Burger";
            food.FoodType = "Burger";
            food.FoodPic = global::Drive_through.Properties.Resources.veganBurger;
            Burgers.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Veggie Burger";
            food.FoodType = "Burger";
            food.FoodPic = global::Drive_through.Properties.Resources.veggieBurger;
            Burgers.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Cheese Pizza";
            food.FoodType = "Pizza";
            food.FoodPic = global::Drive_through.Properties.Resources.CheesePizza;
            Pizza.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Beef Pizza";
            food.FoodType = "Pizza";
            food.FoodPic = global::Drive_through.Properties.Resources.BeefPizza;
            Pizza.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Special Pizza";
            food.FoodType = "Pizza";
            food.FoodPic = global::Drive_through.Properties.Resources.SpecialPizza;
            Pizza.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Pepperoni Pizza";
            food.FoodType = "Pizza";
            food.FoodPic = global::Drive_through.Properties.Resources.PerperonniPizza;
            Pizza.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Mushroom Pizza";
            food.FoodType = "Pizza";
            food.FoodPic = global::Drive_through.Properties.Resources.MushroomPizza;
            Pizza.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Chicago Pizza";
            food.FoodType = "Pizza";
            food.FoodPic = global::Drive_through.Properties.Resources.ChicagoPIzza;
            Pizza.Add(food);
            food.add(food);
            food = new Food();

            food.Name = "Veggie Pizza";
            food.FoodType = "Pizza";
            food.FoodPic = global::Drive_through.Properties.Resources.VeggiePizza;
            Pizza.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Vegan Pizza";
            food.FoodType = "Pizza";
            food.FoodPic = global::Drive_through.Properties.Resources.VeganPizza;
            food.add(food);
            Pizza.Add(food);
            food = new Food();
            food.Name = "Mountain Dew";
            food.FoodType = "Drink";
            food.FoodPic = global::Drive_through.Properties.Resources.MountainDew;
            Drinks.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Coke";
            food.FoodType = "Drink";
            food.FoodPic = global::Drive_through.Properties.Resources.cokeDrink;
            Drinks.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Pepsi ";
            food.FoodType = "Drink";
            food.FoodPic = global::Drive_through.Properties.Resources.pepsi;
            Drinks.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Mirinda";
            food.FoodType = "Drink";
            food.FoodPic = global::Drive_through.Properties.Resources.mirinda;
            Drinks.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Sprite";
            food.FoodType = "Drink";
            food.FoodPic = global::Drive_through.Properties.Resources.sprite;
            Drinks.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Ambo";
            food.FoodType = "Drink";
            food.FoodPic = global::Drive_through.Properties.Resources.Ambo;
            Drinks.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "7 UP";
            food.FoodType = "Drink";
            food.FoodPic = global::Drive_through.Properties.Resources._7up;
            Drinks.Add(food);
            food.add(food);
            food = new Food();
            food.Name = "Fanta";
            food.FoodType = "Drink";
            food.FoodPic = global::Drive_through.Properties.Resources.fanta;
            Drinks.Add(food);
            food.add(food);


        }

        public Food Search(string Name)
        {
            return FoodTree.Search(Name);
        }
        void add(Food food)
        {
            FoodTree.Insert(food);
        }
    }
}
