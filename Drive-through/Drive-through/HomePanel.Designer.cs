namespace Drive_through
{
    partial class HomePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.lblOrderMenu = new DrakeUI.Framework.DrakeUILabel();
            this.drakeUITextBox1 = new DrakeUI.Framework.DrakeUITextBox();
            this.drakeUIImageButton2 = new DrakeUI.Framework.DrakeUIImageButton();
            this.drakeUIImageButton3 = new DrakeUI.Framework.DrakeUIImageButton();
            this.drakeUIImageButton1 = new DrakeUI.Framework.DrakeUIImageButton();
            this.btnFoodBurger = new DrakeUI.Framework.DrakeUIImageButton();
            this.lblMenuCatagory = new DrakeUI.Framework.DrakeUILabel();
            this.lblChooseOrder = new DrakeUI.Framework.DrakeUILabel();
            this.ShowBillsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.foodDisplay1 = new Drive_through.FoodDisplay();
            this.foodDisplay2 = new Drive_through.FoodDisplay();
            this.foodDisplay3 = new Drive_through.FoodDisplay();
            this.foodDisplay4 = new Drive_through.FoodDisplay();
            this.foodDisplay5 = new Drive_through.FoodDisplay();
            this.foodDisplay6 = new Drive_through.FoodDisplay();
            this.foodDisplay7 = new Drive_through.FoodDisplay();
            this.foodDisplay8 = new Drive_through.FoodDisplay();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_OrdName = new DrakeUI.Framework.DrakeUITextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pic_chargePrice = new System.Windows.Forms.PictureBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new DrakeUI.Framework.DrakeUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.drakeUIImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drakeUIImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drakeUIImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFoodBurger)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chargePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderMenu
            // 
            this.lblOrderMenu.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderMenu.Location = new System.Drawing.Point(895, 23);
            this.lblOrderMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderMenu.Name = "lblOrderMenu";
            this.lblOrderMenu.Size = new System.Drawing.Size(205, 32);
            this.lblOrderMenu.Style = DrakeUI.Framework.UIStyle.Custom;
            this.lblOrderMenu.StyleCustomMode = true;
            this.lblOrderMenu.TabIndex = 15;
            this.lblOrderMenu.Text = "Order Menu";
            this.lblOrderMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // drakeUITextBox1
            // 
            this.drakeUITextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox1.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUITextBox1.Location = new System.Drawing.Point(525, 34);
            this.drakeUITextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.drakeUITextBox1.Maximum = 2147483647D;
            this.drakeUITextBox1.Minimum = -2147483648D;
            this.drakeUITextBox1.Name = "drakeUITextBox1";
            this.drakeUITextBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.drakeUITextBox1.Radius = 20;
            this.drakeUITextBox1.RadiusSides = ((DrakeUI.Framework.UICornerRadiusSides)((DrakeUI.Framework.UICornerRadiusSides.LeftTop | DrakeUI.Framework.UICornerRadiusSides.LeftBottom)));
            this.drakeUITextBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.drakeUITextBox1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.drakeUITextBox1.Size = new System.Drawing.Size(299, 30);
            this.drakeUITextBox1.Style = DrakeUI.Framework.UIStyle.Green;
            this.drakeUITextBox1.TabIndex = 9;
            this.drakeUITextBox1.Watermark = "Search for foods here ...";
            this.drakeUITextBox1.TextChanged += new System.EventHandler(this.drakeUITextBox1_TextChanged);
            // 
            // drakeUIImageButton2
            // 
            this.drakeUIImageButton2.BackColor = System.Drawing.Color.OldLace;
            this.drakeUIImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIImageButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIImageButton2.Image = global::Drive_through.Properties.Resources.icons8_soft_drinks_40;
            this.drakeUIImageButton2.ImageHover = global::Drive_through.Properties.Resources.icons8_soft_drinks_48;
            this.drakeUIImageButton2.Location = new System.Drawing.Point(628, 116);
            this.drakeUIImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIImageButton2.Name = "drakeUIImageButton2";
            this.drakeUIImageButton2.Size = new System.Drawing.Size(123, 79);
            this.drakeUIImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.drakeUIImageButton2.TabIndex = 12;
            this.drakeUIImageButton2.TabStop = false;
            this.drakeUIImageButton2.Text = "Drinks";
            this.drakeUIImageButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIImageButton2.Click += new System.EventHandler(this.drakeUIImageButton2_Click);
            // 
            // drakeUIImageButton3
            // 
            this.drakeUIImageButton3.BackColor = System.Drawing.Color.OldLace;
            this.drakeUIImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIImageButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIImageButton3.Image = global::Drive_through.Properties.Resources.icons8_pizza_48;
            this.drakeUIImageButton3.ImageHover = global::Drive_through.Properties.Resources.icons8_pizza_64;
            this.drakeUIImageButton3.Location = new System.Drawing.Point(444, 116);
            this.drakeUIImageButton3.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIImageButton3.Name = "drakeUIImageButton3";
            this.drakeUIImageButton3.Size = new System.Drawing.Size(123, 79);
            this.drakeUIImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.drakeUIImageButton3.TabIndex = 13;
            this.drakeUIImageButton3.TabStop = false;
            this.drakeUIImageButton3.Text = "Pizza";
            this.drakeUIImageButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.drakeUIImageButton3.Click += new System.EventHandler(this.drakeUIImageButton3_Click);
            // 
            // drakeUIImageButton1
            // 
            this.drakeUIImageButton1.BackColor = System.Drawing.Color.OldLace;
            this.drakeUIImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drakeUIImageButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIImageButton1.Image = global::Drive_through.Properties.Resources.icons8_fire_40;
            this.drakeUIImageButton1.ImageHover = global::Drive_through.Properties.Resources.icons8_fire_48;
            this.drakeUIImageButton1.Location = new System.Drawing.Point(89, 116);
            this.drakeUIImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.drakeUIImageButton1.Name = "drakeUIImageButton1";
            this.drakeUIImageButton1.Size = new System.Drawing.Size(123, 79);
            this.drakeUIImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.drakeUIImageButton1.TabIndex = 11;
            this.drakeUIImageButton1.TabStop = false;
            this.drakeUIImageButton1.Text = "Hot";
            this.drakeUIImageButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFoodBurger
            // 
            this.btnFoodBurger.BackColor = System.Drawing.Color.OldLace;
            this.btnFoodBurger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFoodBurger.Image = global::Drive_through.Properties.Resources.icons8_beef_burger_48;
            this.btnFoodBurger.ImageHover = global::Drive_through.Properties.Resources.icons8_beef_burger_64;
            this.btnFoodBurger.Location = new System.Drawing.Point(260, 116);
            this.btnFoodBurger.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoodBurger.Name = "btnFoodBurger";
            this.btnFoodBurger.Size = new System.Drawing.Size(123, 79);
            this.btnFoodBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFoodBurger.TabIndex = 10;
            this.btnFoodBurger.TabStop = false;
            this.btnFoodBurger.Text = "Burger";
            this.btnFoodBurger.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFoodBurger.Click += new System.EventHandler(this.btnFoodBurger_Click);
            // 
            // lblMenuCatagory
            // 
            this.lblMenuCatagory.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCatagory.Location = new System.Drawing.Point(45, 34);
            this.lblMenuCatagory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuCatagory.Name = "lblMenuCatagory";
            this.lblMenuCatagory.Size = new System.Drawing.Size(291, 32);
            this.lblMenuCatagory.Style = DrakeUI.Framework.UIStyle.DrakeColorBlue;
            this.lblMenuCatagory.StyleCustomMode = true;
            this.lblMenuCatagory.TabIndex = 14;
            this.lblMenuCatagory.Text = "Menu Catagory";
            this.lblMenuCatagory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChooseOrder
            // 
            this.lblChooseOrder.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseOrder.Location = new System.Drawing.Point(45, 210);
            this.lblChooseOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseOrder.Name = "lblChooseOrder";
            this.lblChooseOrder.Size = new System.Drawing.Size(291, 32);
            this.lblChooseOrder.Style = DrakeUI.Framework.UIStyle.DrakeColorBlue;
            this.lblChooseOrder.StyleCustomMode = true;
            this.lblChooseOrder.TabIndex = 16;
            this.lblChooseOrder.Text = "Choose Order";
            this.lblChooseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowBillsPanel
            // 
            this.ShowBillsPanel.AutoScroll = true;
            this.ShowBillsPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.ShowBillsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ShowBillsPanel.Location = new System.Drawing.Point(900, 59);
            this.ShowBillsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ShowBillsPanel.Name = "ShowBillsPanel";
            this.ShowBillsPanel.Size = new System.Drawing.Size(427, 398);
            this.ShowBillsPanel.TabIndex = 17;
            this.ShowBillsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ShowBillsPanel_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FloralWhite;
            this.flowLayoutPanel1.Controls.Add(this.foodDisplay1);
            this.flowLayoutPanel1.Controls.Add(this.foodDisplay2);
            this.flowLayoutPanel1.Controls.Add(this.foodDisplay3);
            this.flowLayoutPanel1.Controls.Add(this.foodDisplay4);
            this.flowLayoutPanel1.Controls.Add(this.foodDisplay5);
            this.flowLayoutPanel1.Controls.Add(this.foodDisplay6);
            this.flowLayoutPanel1.Controls.Add(this.foodDisplay7);
            this.flowLayoutPanel1.Controls.Add(this.foodDisplay8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 252);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(853, 460);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // foodDisplay1
            // 
            this.foodDisplay1.Clicked = null;
            this.foodDisplay1.food = null;
            this.foodDisplay1.Location = new System.Drawing.Point(24, 22);
            this.foodDisplay1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.foodDisplay1.Name = "foodDisplay1";
            this.foodDisplay1.Size = new System.Drawing.Size(172, 182);
            this.foodDisplay1.TabIndex = 1;
            // 
            // foodDisplay2
            // 
            this.foodDisplay2.Clicked = null;
            this.foodDisplay2.food = null;
            this.foodDisplay2.Location = new System.Drawing.Point(222, 22);
            this.foodDisplay2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.foodDisplay2.Name = "foodDisplay2";
            this.foodDisplay2.Size = new System.Drawing.Size(172, 182);
            this.foodDisplay2.TabIndex = 2;
            // 
            // foodDisplay3
            // 
            this.foodDisplay3.Clicked = null;
            this.foodDisplay3.food = null;
            this.foodDisplay3.Location = new System.Drawing.Point(420, 22);
            this.foodDisplay3.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.foodDisplay3.Name = "foodDisplay3";
            this.foodDisplay3.Size = new System.Drawing.Size(172, 182);
            this.foodDisplay3.TabIndex = 3;
            // 
            // foodDisplay4
            // 
            this.foodDisplay4.Clicked = null;
            this.foodDisplay4.food = null;
            this.foodDisplay4.Location = new System.Drawing.Point(618, 22);
            this.foodDisplay4.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.foodDisplay4.Name = "foodDisplay4";
            this.foodDisplay4.Size = new System.Drawing.Size(172, 182);
            this.foodDisplay4.TabIndex = 4;
            this.foodDisplay4.Load += new System.EventHandler(this.foodDisplay4_Load);
            // 
            // foodDisplay5
            // 
            this.foodDisplay5.Clicked = null;
            this.foodDisplay5.food = null;
            this.foodDisplay5.Location = new System.Drawing.Point(24, 228);
            this.foodDisplay5.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.foodDisplay5.Name = "foodDisplay5";
            this.foodDisplay5.Size = new System.Drawing.Size(172, 182);
            this.foodDisplay5.TabIndex = 5;
            // 
            // foodDisplay6
            // 
            this.foodDisplay6.Clicked = null;
            this.foodDisplay6.food = null;
            this.foodDisplay6.Location = new System.Drawing.Point(222, 228);
            this.foodDisplay6.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.foodDisplay6.Name = "foodDisplay6";
            this.foodDisplay6.Size = new System.Drawing.Size(172, 182);
            this.foodDisplay6.TabIndex = 6;
            // 
            // foodDisplay7
            // 
            this.foodDisplay7.Clicked = null;
            this.foodDisplay7.food = null;
            this.foodDisplay7.Location = new System.Drawing.Point(420, 228);
            this.foodDisplay7.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.foodDisplay7.Name = "foodDisplay7";
            this.foodDisplay7.Size = new System.Drawing.Size(172, 182);
            this.foodDisplay7.TabIndex = 7;
            // 
            // foodDisplay8
            // 
            this.foodDisplay8.Clicked = null;
            this.foodDisplay8.food = null;
            this.foodDisplay8.Location = new System.Drawing.Point(618, 228);
            this.foodDisplay8.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.foodDisplay8.Name = "foodDisplay8";
            this.foodDisplay8.Size = new System.Drawing.Size(172, 182);
            this.foodDisplay8.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txt_OrdName);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pic_chargePrice);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(900, 481);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 231);
            this.panel1.TabIndex = 19;
            // 
            // txt_OrdName
            // 
            this.txt_OrdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OrdName.FillColor = System.Drawing.Color.White;
            this.txt_OrdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_OrdName.Location = new System.Drawing.Point(109, 106);
            this.txt_OrdName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_OrdName.Maximum = 2147483647D;
            this.txt_OrdName.Minimum = -2147483648D;
            this.txt_OrdName.Name = "txt_OrdName";
            this.txt_OrdName.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txt_OrdName.Radius = 20;
            this.txt_OrdName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.txt_OrdName.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.txt_OrdName.Size = new System.Drawing.Size(200, 30);
            this.txt_OrdName.Style = DrakeUI.Framework.UIStyle.Green;
            this.txt_OrdName.TabIndex = 6;
            this.txt_OrdName.Text = "Name";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(312, 54);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(72, 25);
            this.lbl_time.TabIndex = 5;
            this.lbl_time.Text = "0000m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Wait Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(148)))), ((int)(((byte)(0)))));
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(147, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Charge Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pic_chargePrice
            // 
            this.pic_chargePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_chargePrice.Image = ((System.Drawing.Image)(resources.GetObject("pic_chargePrice.Image")));
            this.pic_chargePrice.Location = new System.Drawing.Point(67, 146);
            this.pic_chargePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_chargePrice.Name = "pic_chargePrice";
            this.pic_chargePrice.Size = new System.Drawing.Size(275, 52);
            this.pic_chargePrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_chargePrice.TabIndex = 2;
            this.pic_chargePrice.TabStop = false;
            this.pic_chargePrice.Click += new System.EventHandler(this.pic_chargePrice_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(312, 25);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(69, 29);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "$000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total ";
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FillColor = System.Drawing.Color.NavajoWhite;
            this.btn_search.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.btn_search.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_search.Location = new System.Drawing.Point(819, 34);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Radius = 20;
            this.btn_search.RadiusSides = ((DrakeUI.Framework.UICornerRadiusSides)((DrakeUI.Framework.UICornerRadiusSides.RightTop | DrakeUI.Framework.UICornerRadiusSides.RightBottom)));
            this.btn_search.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btn_search.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.btn_search.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.btn_search.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.btn_search.Size = new System.Drawing.Size(35, 32);
            this.btn_search.Style = DrakeUI.Framework.UIStyle.Custom;
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "Go";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1369, 727);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblOrderMenu);
            this.Controls.Add(this.ShowBillsPanel);
            this.Controls.Add(this.lblChooseOrder);
            this.Controls.Add(this.lblMenuCatagory);
            this.Controls.Add(this.drakeUIImageButton2);
            this.Controls.Add(this.drakeUIImageButton3);
            this.Controls.Add(this.drakeUIImageButton1);
            this.Controls.Add(this.btnFoodBurger);
            this.Controls.Add(this.drakeUITextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePanel";
            this.Text = "HomePanel";
            this.Load += new System.EventHandler(this.HomePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drakeUIImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drakeUIImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drakeUIImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFoodBurger)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_chargePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox1;
        private DrakeUI.Framework.DrakeUIImageButton btnFoodBurger;
        private DrakeUI.Framework.DrakeUIImageButton drakeUIImageButton1;
        private DrakeUI.Framework.DrakeUIImageButton drakeUIImageButton2;
        private DrakeUI.Framework.DrakeUIImageButton drakeUIImageButton3;
        private DrakeUI.Framework.DrakeUILabel lblOrderMenu;
        private DrakeUI.Framework.DrakeUILabel lblMenuCatagory;
        private DrakeUI.Framework.DrakeUILabel lblChooseOrder;
        private System.Windows.Forms.FlowLayoutPanel ShowBillsPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FoodDisplay foodDisplay1;
        private FoodDisplay foodDisplay2;
        private FoodDisplay foodDisplay3;
        private FoodDisplay foodDisplay4;
        private FoodDisplay foodDisplay5;
        private FoodDisplay foodDisplay6;
        private FoodDisplay foodDisplay7;
        private FoodDisplay foodDisplay8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_chargePrice;
        private System.Windows.Forms.Label label6;
        private DrakeUI.Framework.DrakeUIButton btn_search;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label8;
        private DrakeUI.Framework.DrakeUITextBox txt_OrdName;
    }
}