using Drive_through.domain;
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
    public partial class Home : Form
    {
        public DashboardPanel dashboardPanel;

        private domain.Order _order;

        public domain.Order Order
        {
            get { return _order; }
            set { _order = value; }
        }
        public Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txt_Name.Text= "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            txt_Name.Text = "Order Name";

        }

        private void txtSearchByName_Leave(object sender, EventArgs e)
        {
            txtSearchByName.Text = "Search for Order";
        }

        private void txtSearchByName_Enter(object sender, EventArgs e)
        {
            txtSearchByName.Text = "";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = global::Drive_through.Properties.Resources.Burger_active_icon;
            pictureBox3.Image = global::Drive_through.Properties.Resources.Pizza_icon;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = global::Drive_through.Properties.Resources.Pizza_active_icon;
            pictureBox2.Image = global::Drive_through.Properties.Resources.Burger_icon;

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pic_chargePrice_Click(object sender, EventArgs e)
        {
            Order.OrderName = txt_Name.Text;
            if (dashboardPanel != null)
            {
                dashboardPanel.AddOrder(Order);
                OrderMenu.Controls.Clear();
                txt_Name.Text = "Name";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
