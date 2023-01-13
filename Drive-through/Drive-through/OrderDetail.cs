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
    public partial class OrderDetail : UserControl
    {
        public domain.Order order;

        public int totalTime;
        public OrderDetail()
        {
            InitializeComponent();
        }
        public OrderDetail(domain.Order ord)
        {
            order= ord;
            totalTime = order.TotalTime;
            InitializeComponent();
            timer1.Start();

        }


        private void OrderDetail_Load(object sender, EventArgs e)
        {
            if(order != null)
            {
                foreach(domain.Food f in order.Foods)
                {
                    Label lbl_f1 = new Label();
                    lbl_f1.Text = f.Name+ "  $"+ f.Price ;
                    lbl_f1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    OrderList.Controls.Add(lbl_f1);
                }
                lbl_total.Text = "$"+order.TotalPrice.ToString()+".00";
                label6.Text = order.OrderName;
                /*
                domain.Order o = new domain.Order();
                domain.Food f = new domain.Food();
                this.label1.Text = f.Name;
                this.label5.Text = o.TotalPrice.ToString();
                this.label3.Text = o.TotalTime.ToString();
                */
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(order != null)
            {
                if(totalTime > 0)
                {
                    //MessageBox.Show(totalTime + "");
                    totalTime -= 1;
                    label3.Text = totalTime.ToString();
                    
                    Order.queue.Dequeue();
                }
                else
                {
                    label3.Text = totalTime.ToString();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Order is NUll in OrderDetails in tick fin");
                timer1.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }
    }
}
