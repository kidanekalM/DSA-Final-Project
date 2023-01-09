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
    public partial class OrderDetail : UserControl
    {
        public OrderDetail()
        {
            InitializeComponent();
        }
       

        private void OrderDetail_Load(object sender, EventArgs e)
        {
            domain.Order o = new domain.Order();
            domain.Food f = new domain.Food();
            this.label1.Text = f.Name;
            this.label5.Text = o.TotalPrice.ToString();
            this.label3.Text = o.TotalTime.ToString();

        }
    }
}
