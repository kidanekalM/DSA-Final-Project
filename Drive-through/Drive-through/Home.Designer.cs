
namespace Drive_through
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txt_search = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.tripple_burgers5 = new Drive_through.User_controls.Tripple_burgers();
            this.tripple_burgers6 = new Drive_through.User_controls.Tripple_burgers();
            this.tripple_burgers3 = new Drive_through.User_controls.Tripple_burgers();
            this.tripple_burgers4 = new Drive_through.User_controls.Tripple_burgers();
            this.tripple_burgers2 = new Drive_through.User_controls.Tripple_burgers();
            this.tripple_burgers1 = new Drive_through.User_controls.Tripple_burgers();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_burger = new Guna.UI.WinForms.GunaCircleButton();
            this.lbl_menuCatagory = new System.Windows.Forms.Label();
            this.lbl_chooseOrder = new System.Windows.Forms.Label();
            this.btn_Pizza = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_drinks = new Guna.UI.WinForms.GunaCircleButton();
            this.lbl_orderMenu = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaGradientButton1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(127, 647);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.lbl_orderMenu);
            this.gunaPanel2.Controls.Add(this.gunaButton1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(908, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(292, 647);
            this.gunaPanel2.TabIndex = 1;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.gunaPanel3.Controls.Add(this.btn_drinks);
            this.gunaPanel3.Controls.Add(this.btn_Pizza);
            this.gunaPanel3.Controls.Add(this.lbl_chooseOrder);
            this.gunaPanel3.Controls.Add(this.lbl_menuCatagory);
            this.gunaPanel3.Controls.Add(this.btn_burger);
            this.gunaPanel3.Controls.Add(this.tripple_burgers5);
            this.gunaPanel3.Controls.Add(this.tripple_burgers6);
            this.gunaPanel3.Controls.Add(this.tripple_burgers3);
            this.gunaPanel3.Controls.Add(this.tripple_burgers4);
            this.gunaPanel3.Controls.Add(this.tripple_burgers2);
            this.gunaPanel3.Controls.Add(this.tripple_burgers1);
            this.gunaPanel3.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaPanel3.Controls.Add(this.txt_search);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel3.Location = new System.Drawing.Point(127, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(781, 647);
            this.gunaPanel3.TabIndex = 2;
            this.gunaPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel3_Paint);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(539, 12);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(43, 29);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox1.TabIndex = 21;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.White;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_search.Location = new System.Drawing.Point(588, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(165, 30);
            this.txt_search.TabIndex = 20;
            this.txt_search.Text = "search for food";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Red;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(249, 12);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(31, 29);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "X";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // tripple_burgers5
            // 
            this.tripple_burgers5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tripple_burgers5.Location = new System.Drawing.Point(588, 454);
            this.tripple_burgers5.Margin = new System.Windows.Forms.Padding(9);
            this.tripple_burgers5.Name = "tripple_burgers5";
            this.tripple_burgers5.Size = new System.Drawing.Size(150, 178);
            this.tripple_burgers5.TabIndex = 27;
            // 
            // tripple_burgers6
            // 
            this.tripple_burgers6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tripple_burgers6.Location = new System.Drawing.Point(588, 255);
            this.tripple_burgers6.Margin = new System.Windows.Forms.Padding(6);
            this.tripple_burgers6.Name = "tripple_burgers6";
            this.tripple_burgers6.Size = new System.Drawing.Size(150, 181);
            this.tripple_burgers6.TabIndex = 26;
            // 
            // tripple_burgers3
            // 
            this.tripple_burgers3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tripple_burgers3.Location = new System.Drawing.Point(320, 454);
            this.tripple_burgers3.Margin = new System.Windows.Forms.Padding(9);
            this.tripple_burgers3.Name = "tripple_burgers3";
            this.tripple_burgers3.Size = new System.Drawing.Size(145, 178);
            this.tripple_burgers3.TabIndex = 25;
            // 
            // tripple_burgers4
            // 
            this.tripple_burgers4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tripple_burgers4.Location = new System.Drawing.Point(320, 253);
            this.tripple_burgers4.Margin = new System.Windows.Forms.Padding(6);
            this.tripple_burgers4.Name = "tripple_burgers4";
            this.tripple_burgers4.Size = new System.Drawing.Size(145, 181);
            this.tripple_burgers4.TabIndex = 24;
            // 
            // tripple_burgers2
            // 
            this.tripple_burgers2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tripple_burgers2.Location = new System.Drawing.Point(32, 451);
            this.tripple_burgers2.Margin = new System.Windows.Forms.Padding(6);
            this.tripple_burgers2.Name = "tripple_burgers2";
            this.tripple_burgers2.Size = new System.Drawing.Size(147, 181);
            this.tripple_burgers2.TabIndex = 23;
            // 
            // tripple_burgers1
            // 
            this.tripple_burgers1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tripple_burgers1.Location = new System.Drawing.Point(32, 253);
            this.tripple_burgers1.Margin = new System.Windows.Forms.Padding(4);
            this.tripple_burgers1.Name = "tripple_burgers1";
            this.tripple_burgers1.Size = new System.Drawing.Size(147, 181);
            this.tripple_burgers1.TabIndex = 22;
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(12, 82);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(97, 57);
            this.gunaGradientButton1.TabIndex = 24;
            this.gunaGradientButton1.Text = "HOME";
            // 
            // btn_burger
            // 
            this.btn_burger.AnimationHoverSpeed = 0.07F;
            this.btn_burger.AnimationSpeed = 0.03F;
            this.btn_burger.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_burger.BorderColor = System.Drawing.Color.Black;
            this.btn_burger.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_burger.FocusedColor = System.Drawing.Color.Empty;
            this.btn_burger.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_burger.ForeColor = System.Drawing.Color.White;
            this.btn_burger.Image = null;
            this.btn_burger.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_burger.Location = new System.Drawing.Point(32, 83);
            this.btn_burger.Name = "btn_burger";
            this.btn_burger.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_burger.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_burger.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_burger.OnHoverImage = null;
            this.btn_burger.OnPressedColor = System.Drawing.Color.Black;
            this.btn_burger.Size = new System.Drawing.Size(85, 56);
            this.btn_burger.TabIndex = 28;
            this.btn_burger.Text = "BURGER";
            // 
            // lbl_menuCatagory
            // 
            this.lbl_menuCatagory.AutoSize = true;
            this.lbl_menuCatagory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menuCatagory.Location = new System.Drawing.Point(6, 38);
            this.lbl_menuCatagory.Name = "lbl_menuCatagory";
            this.lbl_menuCatagory.Size = new System.Drawing.Size(195, 28);
            this.lbl_menuCatagory.TabIndex = 29;
            this.lbl_menuCatagory.Text = "Menu Catagory";
            // 
            // lbl_chooseOrder
            // 
            this.lbl_chooseOrder.AutoSize = true;
            this.lbl_chooseOrder.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chooseOrder.Location = new System.Drawing.Point(6, 186);
            this.lbl_chooseOrder.Name = "lbl_chooseOrder";
            this.lbl_chooseOrder.Size = new System.Drawing.Size(175, 28);
            this.lbl_chooseOrder.TabIndex = 30;
            this.lbl_chooseOrder.Text = "Choose Order";
            // 
            // btn_Pizza
            // 
            this.btn_Pizza.AnimationHoverSpeed = 0.07F;
            this.btn_Pizza.AnimationSpeed = 0.03F;
            this.btn_Pizza.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Pizza.BorderColor = System.Drawing.Color.Black;
            this.btn_Pizza.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Pizza.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Pizza.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Pizza.ForeColor = System.Drawing.Color.White;
            this.btn_Pizza.Image = null;
            this.btn_Pizza.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_Pizza.Location = new System.Drawing.Point(349, 83);
            this.btn_Pizza.Name = "btn_Pizza";
            this.btn_Pizza.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Pizza.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Pizza.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Pizza.OnHoverImage = null;
            this.btn_Pizza.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Pizza.Size = new System.Drawing.Size(85, 56);
            this.btn_Pizza.TabIndex = 31;
            this.btn_Pizza.Text = "PIZZA";
            // 
            // btn_drinks
            // 
            this.btn_drinks.AnimationHoverSpeed = 0.07F;
            this.btn_drinks.AnimationSpeed = 0.03F;
            this.btn_drinks.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_drinks.BorderColor = System.Drawing.Color.Black;
            this.btn_drinks.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_drinks.FocusedColor = System.Drawing.Color.Empty;
            this.btn_drinks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_drinks.ForeColor = System.Drawing.Color.White;
            this.btn_drinks.Image = null;
            this.btn_drinks.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_drinks.Location = new System.Drawing.Point(653, 83);
            this.btn_drinks.Name = "btn_drinks";
            this.btn_drinks.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_drinks.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_drinks.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_drinks.OnHoverImage = null;
            this.btn_drinks.OnPressedColor = System.Drawing.Color.Black;
            this.btn_drinks.Size = new System.Drawing.Size(85, 56);
            this.btn_drinks.TabIndex = 32;
            this.btn_drinks.Text = "DRINKS";
            // 
            // lbl_orderMenu
            // 
            this.lbl_orderMenu.AutoSize = true;
            this.lbl_orderMenu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderMenu.Location = new System.Drawing.Point(60, 38);
            this.lbl_orderMenu.Name = "lbl_orderMenu";
            this.lbl_orderMenu.Size = new System.Drawing.Size(151, 28);
            this.lbl_orderMenu.TabIndex = 31;
            this.lbl_orderMenu.Text = "Order Menu";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 647);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.Text = "Home";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaLineTextBox txt_search;
        private User_controls.Tripple_burgers tripple_burgers3;
        private User_controls.Tripple_burgers tripple_burgers4;
        private User_controls.Tripple_burgers tripple_burgers2;
        private User_controls.Tripple_burgers tripple_burgers1;
        private User_controls.Tripple_burgers tripple_burgers5;
        private User_controls.Tripple_burgers tripple_burgers6;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaCircleButton btn_drinks;
        private Guna.UI.WinForms.GunaCircleButton btn_Pizza;
        private System.Windows.Forms.Label lbl_chooseOrder;
        private System.Windows.Forms.Label lbl_menuCatagory;
        private Guna.UI.WinForms.GunaCircleButton btn_burger;
        private System.Windows.Forms.Label lbl_orderMenu;
    }
}