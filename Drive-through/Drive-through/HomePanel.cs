using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drive_through
{
    public partial class HomePanel : Form
    {
        public HomePanel()
        {
            InitializeComponent();

            foreach (var x in global::Drive_through.domain.Food.Burgers)
            {
                FoodDisplay fd = new FoodDisplay();
                fd.NAME = x.Name;
                fd.PRICE = x.Price;
                fd.IMAGE = x.FoodPic;
                flowLayoutPanel1.Controls.Add(fd);
            }
            foreach (var x in global::Drive_through.domain.Food.Pizza)
            {
                FoodDisplay fd = new FoodDisplay();
                fd.NAME = x.Name;
                fd.PRICE = x.Price;
                fd.IMAGE = x.FoodPic;
                flowLayoutPanel1.Controls.Add(fd);
            }
            foreach (var x in global::Drive_through.domain.Food.Drinks)
            {
                FoodDisplay fd = new FoodDisplay();
                fd.NAME = x.Name;
                fd.PRICE = x.Price;
                fd.IMAGE = x.FoodPic;
                flowLayoutPanel1.Controls.Add(fd);
            }

        }

        private void btnFoodBurger_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var x in global::Drive_through.domain.Food.Burgers)
            {
                FoodDisplay fd = new FoodDisplay();
                fd.NAME = x.Name;
                fd.PRICE = x.Price;
                fd.IMAGE = x.FoodPic;
                flowLayoutPanel1.Controls.Add(fd);
            }
        }

        private void drakeUIImageButton3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var x in global::Drive_through.domain.Food.Pizza)
            {
                FoodDisplay fd = new FoodDisplay();
                fd.NAME = x.Name;
                fd.PRICE = x.Price;
                fd.IMAGE = x.FoodPic;
                flowLayoutPanel1.Controls.Add(fd);
            }
        }

        private void drakeUIImageButton2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var x in global::Drive_through.domain.Food.Drinks)
            {
                FoodDisplay fd = new FoodDisplay();
                fd.NAME = x.Name;
                fd.PRICE = x.Price;
                fd.IMAGE = x.FoodPic;
                flowLayoutPanel1.Controls.Add(fd);
            }
        }
    }
}
