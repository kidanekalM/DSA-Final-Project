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
            OrderDetail p = new OrderDetail();

            OrdersListContainer.Controls.Add(p);
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OrderDetail p = new OrderDetail();
       
            OrdersListContainer.Controls.Add(p);
        }

        private void txtSearchByName_Enter(object sender, EventArgs e)
        {
            txtSearchByName.Text = "";
        }

        private void txtSearchByName_Leave(object sender, EventArgs e)
        {
            txtSearchByName.Text = "Search for Order";

        }
    }
}
