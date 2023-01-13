using DS_Project_Trial;
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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
            openChildForm(new HomePanel());
        }

        private void AdminMainPage_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPbHome_Click(object sender, EventArgs e)
        {
            BtnPbHome.Image = global::Drive_through.Properties.Resources.HomeActiveBtn;
            BtnPbDashboard.Image = global::Drive_through.Properties.Resources.DashboardBtn;
            BtnPbBills.Image = global::Drive_through.Properties.Resources.BillsBtn;
            openChildForm(new HomePanel());
        }

        private void BtnPbDashboard_Click(object sender, EventArgs e)
        {
            BtnPbHome.Image = global::Drive_through.Properties.Resources.HomeBtn;
            BtnPbDashboard.Image = global::Drive_through.Properties.Resources.DashboardActive;
            BtnPbBills.Image = global::Drive_through.Properties.Resources.BillsBtn;
            openChildForm(new DashboardPanel());

        }

        private void BtnPbBills_Click(object sender, EventArgs e)
        {
            BtnPbHome.Image = global::Drive_through.Properties.Resources.HomeBtn;
            BtnPbDashboard.Image = global::Drive_through.Properties.Resources.DashboardBtn;
            BtnPbBills.Image = global::Drive_through.Properties.Resources.BillActive;
            openChildForm(new BillsPanel());

        }

        private void BtnPbLogOut_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }
    }
}
