namespace Drive_through
{
    partial class OrderMenuItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMenuItem));
            this.pic_food = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.pic_del = new System.Windows.Forms.PictureBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.pic_edit = new System.Windows.Forms.PictureBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_del)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_edit)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_food
            // 
            this.pic_food.Location = new System.Drawing.Point(4, 4);
            this.pic_food.Name = "pic_food";
            this.pic_food.Size = new System.Drawing.Size(43, 43);
            this.pic_food.TabIndex = 0;
            this.pic_food.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(53, 4);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_name.Size = new System.Drawing.Size(48, 16);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(53, 32);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(38, 15);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "$0.00";
            // 
            // pic_del
            // 
            this.pic_del.BackColor = System.Drawing.Color.Transparent;
            this.pic_del.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_del.BackgroundImage")));
            this.pic_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_del.Location = new System.Drawing.Point(189, 0);
            this.pic_del.Name = "pic_del";
            this.pic_del.Size = new System.Drawing.Size(31, 30);
            this.pic_del.TabIndex = 4;
            this.pic_del.TabStop = false;
            this.pic_del.Click += new System.EventHandler(this.pic_del_Click);
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(97, 32);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(22, 15);
            this.lbl_amount.TabIndex = 5;
            this.lbl_amount.Text = "X0";
            // 
            // pic_edit
            // 
            this.pic_edit.BackColor = System.Drawing.Color.Transparent;
            this.pic_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_edit.BackgroundImage")));
            this.pic_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_edit.Location = new System.Drawing.Point(164, 0);
            this.pic_edit.Name = "pic_edit";
            this.pic_edit.Size = new System.Drawing.Size(28, 30);
            this.pic_edit.TabIndex = 6;
            this.pic_edit.TabStop = false;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Total.Location = new System.Drawing.Point(161, 32);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(38, 15);
            this.lbl_Total.TabIndex = 7;
            this.lbl_Total.Text = "$0.00";
            // 
            // OrderMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.pic_edit);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.pic_del);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pic_food);
            this.Name = "OrderMenuItem";
            this.Size = new System.Drawing.Size(222, 50);
            this.Load += new System.EventHandler(this.OrderMenuItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_del)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_food;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.PictureBox pic_del;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.PictureBox pic_edit;
        private System.Windows.Forms.Label lbl_Total;
    }
}
