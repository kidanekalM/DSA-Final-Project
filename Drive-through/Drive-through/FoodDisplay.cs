using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drive_through
{
    public partial class FoodDisplay : UserControl
    {
        private string _name;
        private double _price;
        private Image _image;
        public string NAME
        {
            get { return _name; }
            set { _name = value; lbl_Name.Text = value; }
        }

        public double PRICE
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = value.ToString(); }
        }

        public Image IMAGE
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }

        public FoodDisplay()
        {
            InitializeComponent();
        }
    }
}
