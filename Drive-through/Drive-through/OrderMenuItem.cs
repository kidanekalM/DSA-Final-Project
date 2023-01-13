using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drive_through.domain;

namespace Drive_through
{
    public partial class OrderMenuItem : UserControl
    {
        public string foodName;
        private EventHandler onDelClick;

        public EventHandler OnDelClick
        {
            get { return onDelClick; }
            set { onDelClick = value;
                pic_del.Click += value;     
            }
        }
        private EventHandler onEditClick;
        public PictureBox PictureBoxpic_del;
        public EventHandler OnEditClick
        {
            get { return onEditClick; }
            set { onEditClick = value; }
        }

        public OrderMenuItem()
        {
            InitializeComponent();
            PictureBoxpic_del = pic_del;
            Food f = Food.Burgers.First();
            int amount = 2;
            foodName = f.Name;
            pic_food.Image = f.FoodPic;
            lbl_name.Text = f.Name;
            lbl_price.Text = "$" + f.Price.ToString();
            lbl_amount.Text = "X" + amount.ToString();
            lbl_Total.Text = "$" + (f.Price * amount).ToString();
        }
        public OrderMenuItem(Food f, int amount)
        {
            InitializeComponent();
            PictureBoxpic_del = pic_del;
            pic_food.Image = f.FoodPic;
            lbl_name.Text = f.Name;
            foodName = f.Name;
            lbl_price.Text = "$" + f.Price.ToString();
            lbl_amount.Text ="X" + amount.ToString();
            lbl_Total.Text = "$" + (f.Price * amount).ToString();
        }

        private void OrderMenuItem_Load(object sender, EventArgs e)
        {

        }

        private void pic_del_Click(object sender, EventArgs e)
        {

        }
    }
}
