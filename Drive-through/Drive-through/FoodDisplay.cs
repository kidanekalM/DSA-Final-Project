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
        //public domain.Food food { get; set; }
        private EventHandler _click;

        public EventHandler Clicked
        {
            get { return _click; }
            set { _click = value;
                //pictureBox1.Click += value;
                //lbl_Name.Click += value;
                //lbl_price.Click += value;
                this.Click += value;
            }
        }

        private domain.Food _food;

        public domain.Food food
        {
            get { return _food; }
            set { _food = value;
                if(value != null)
                {
                    this.pictureBox1.Image = value.FoodPic;
                    this.lbl_Name.Text = value.Name;
                    this.lbl_price.Text = "$" + value.Price.ToString();
                }
            }
        }

        public FoodDisplay()
        {
            InitializeComponent();
        }
        public FoodDisplay(domain.Food f)
        {
            _food = f;
            InitializeComponent();
            this.pictureBox1.Image = f.FoodPic;
            this.lbl_Name.Text = f.Name;
            this.lbl_price.Text = "$" + f.Price.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clicked(this, null);
        }
    }
}
