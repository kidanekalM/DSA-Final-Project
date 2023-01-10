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
    public partial class DashboardPanel : Form
    {
        public DashboardPanel()
        {
            InitializeComponent();
        }

        private void DashboardPanel_Load(object sender, EventArgs e)
        {
            List<Order> p = new List<Order>();
            try
            {
                foreach(var order in p)
                {
                   // OrderDetail o = new OrderDetail();

                   //OrdersListContainer.Controls.Add(o);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            /*OrderDetail p = new OrderDetail();
       
            OrdersListContainer.Controls.Add(p);*/
        }

        private void txtSearchByName_Enter(object sender, EventArgs e)
        {
            txtSearchByName.Text = "";
        }

        private void txtSearchByName_Leave(object sender, EventArgs e)
        {
            txtSearchByName.Text = "Search for Order";

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Food f = new Food();
            if(string.IsNullOrEmpty(txtSearchByName.Text))
            {
                errorProvider1.SetError(pictureBox3, "Enter a valid name!");
            }
            else
            {
                errorProvider1.Clear();
                f.Search(txtSearchByName.Text);

            }


        }
    }
}
