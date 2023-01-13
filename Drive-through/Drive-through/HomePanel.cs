using Drive_through.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drive_through
{
    public partial class HomePanel : Form
    {
        private domain.Order _order;

        public domain.Order Order
        {
            get { return _order; }
            set { _order = value; }
        }
        public DashboardPanel dashboardPanel;
        public HomePanel()
        {
            InitializeComponent();
        }
        public HomePanel(DashboardPanel dashboardPanel)
        {
            InitializeComponent();
            this.dashboardPanel = dashboardPanel;
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            foodDisplay1.food = domain.Food.Burgers[0];
            foodDisplay2.food = domain.Food.Burgers[1];
            foodDisplay4.food = domain.Food.Burgers[3];
            foodDisplay3.food = domain.Food.Burgers[2];
            foodDisplay5.food = domain.Food.Burgers[4];
            foodDisplay6.food = domain.Food.Burgers[5];
            foodDisplay7.food = domain.Food.Burgers[6];
            foodDisplay8.food = domain.Food.Burgers[7];
            foodDisplay2.Clicked = FoodDispClick;
            foodDisplay4.Clicked = FoodDispClick;
            foodDisplay3.Clicked = FoodDispClick;
            foodDisplay5.Clicked = FoodDispClick;
            foodDisplay1.Clicked = FoodDispClick;
            foodDisplay6.Clicked = FoodDispClick;
            foodDisplay7.Clicked = FoodDispClick;
            foodDisplay8.Clicked = FoodDispClick;
        }

        private void btnFoodBurger_Click(object sender, EventArgs e)
        {

            foodDisplay1.food = domain.Food.Burgers[0];
            foodDisplay2.food = domain.Food.Burgers[1];
            foodDisplay3.food = domain.Food.Burgers[2];
            foodDisplay4.food = domain.Food.Burgers[3];
            foodDisplay5.food = domain.Food.Burgers[4];
            foodDisplay6.food = domain.Food.Burgers[5];
            foodDisplay7.food = domain.Food.Burgers[6];
            foodDisplay8.food = domain.Food.Burgers[7];
            foodDisplay1.Show();
            foodDisplay2.Show();
            foodDisplay3.Show();
            foodDisplay4.Show();
            foodDisplay6.Show();
            foodDisplay5.Show();
            foodDisplay7.Show();
            foodDisplay8.Show();
        }

        private void drakeUIImageButton3_Click(object sender, EventArgs e)
        {

            foodDisplay1.food = domain.Food.Pizza[0];
            foodDisplay2.food = domain.Food.Pizza[1];
            foodDisplay3.food = domain.Food.Pizza[2];
            foodDisplay4.food = domain.Food.Pizza[3];
            foodDisplay6.food = domain.Food.Pizza[5];
            foodDisplay5.food = domain.Food.Pizza[4];
            foodDisplay7.food = domain.Food.Pizza[6];
            foodDisplay8.food = domain.Food.Pizza[7];
            foodDisplay1.Show();
            foodDisplay2.Show();
            foodDisplay3.Show();
            foodDisplay4.Show();
            foodDisplay6.Show();
            foodDisplay5.Show();
            foodDisplay7.Show();
            foodDisplay8.Show();
        }

        private void drakeUIImageButton2_Click(object sender, EventArgs e)
        {                                        
            foodDisplay1.food = domain.Food.Drinks[0];
            foodDisplay2.food = domain.Food.Drinks[1];
            foodDisplay3.food = domain.Food.Drinks[2];
            foodDisplay4.food = domain.Food.Drinks[3];
            foodDisplay6.food = domain.Food.Drinks[5];
            foodDisplay5.food = domain.Food.Drinks[4];
            foodDisplay7.food = domain.Food.Drinks[6];
            foodDisplay8.food = domain.Food.Drinks[7];
            foodDisplay1.Show();
            foodDisplay2.Show();
            foodDisplay3.Show();
            foodDisplay4.Show();
            foodDisplay6.Show();
            foodDisplay5.Show();
            foodDisplay7.Show();
            foodDisplay8.Show();
        }
        public void FoodDispClick(Object sender, EventArgs e)
        {
            //MessageBox.Show("Add food");
            FoodDisplay fdsp =  (FoodDisplay) sender;
            if(Order == null)
            {
                Order = new domain.Order();
                Order.Foods = new List<domain.Food>();
                Order.Foods.Add(fdsp.food);
                OrderMenuItem ord = new OrderMenuItem(fdsp.food,1);
                ord.Size = new Size(317, 50);
                ord.OnDelClick += deleteOrderItem;

                lbl_total.Text = "$" + Order.TotalPrice.ToString();
                lbl_time.Text = Order.TotalTime.ToString() + "min";
                ShowBillsPanel.Controls.Add(ord);
            }
            else
            {

                lbl_time.Text = Order.TotalTime.ToString() + "min";
                lbl_total.Text = "$" + Order.TotalPrice.ToString();
                OrderMenuItem ord = new OrderMenuItem(fdsp.food, 1);
                ord.Size = new Size(317, 50);
                ord.OnDelClick += deleteOrderItem;

                ShowBillsPanel.Controls.Add(ord);
                Order.Foods.Add(fdsp.food);

            }
        }
        public void deleteOrderItem(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            foreach(OrderMenuItem ordm in ShowBillsPanel.Controls)
            {
                if (ordm.PictureBoxpic_del.Equals(sender))
                {
                    Order.Foods.Remove(Order.Foods.Find(f => f.Name == ordm.foodName));
                    ShowBillsPanel.Controls.Remove(ordm);
                }
            }
            lbl_total.Text = "$"+Order.TotalPrice.ToString();
            lbl_time.Text = Order.TotalTime.ToString()+"min";
        }
        public void pic_chargePrice_Click(object sender, EventArgs e)
        {
            Order.OrderName = txt_OrdName.Text;
            if(dashboardPanel != null)
            {
                dashboardPanel.AddOrder(Order);
                ShowBillsPanel.Controls.Clear();
                txt_OrdName.Text = "Name";
            }
        }

        private void ShowBillsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drakeUITextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            foodDisplay1.Hide();
            foodDisplay2.Hide();
            foodDisplay3.Hide();
            foodDisplay4.Hide();
            foodDisplay6.Hide();
            foodDisplay5.Hide();
            foodDisplay7.Hide();
            foodDisplay8.Hide();
            Food searchResult = Food.FoodTree.Search(drakeUITextBox1.Text);
            if (searchResult != null)
            {
                foodDisplay1.Show();
                foodDisplay1.food = searchResult;
            }
            else
            {
                MessageBox.Show("We could not find the food you were looking for!\n Check our menu");
                btnFoodBurger_Click(sender, e);
            }
            //
        }

        private void label6_Click(object sender, EventArgs e)
        {
            pic_chargePrice_Click(sender, e);
        }
    }
}
