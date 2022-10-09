namespace LunchOrder
{
    partial class frmLunchOrder
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.radioBtnSalad = new System.Windows.Forms.RadioButton();
            this.radioBtnPizza = new System.Windows.Forms.RadioButton();
            this.radioBtnHamBurger = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gpxAddOnItem = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.gbxMainCourse.SuspendLayout();
            this.gpxAddOnItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlaceOrder.Location = new System.Drawing.Point(398, 218);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(132, 35);
            this.btnPlaceOrder.TabIndex = 17;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblOrderTotal);
            this.GroupBox1.Controls.Add(this.lblSalesTax);
            this.GroupBox1.Controls.Add(this.lblSubtotal);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(26, 206);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox1.Size = new System.Drawing.Size(336, 160);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(156, 111);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(132, 31);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(156, 74);
            this.lblSalesTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(132, 31);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(156, 37);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(132, 31);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(24, 111);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(120, 25);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Order total:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 74);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 25);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tax (13%):";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(24, 37);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Subtotal:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.radioBtnSalad);
            this.gbxMainCourse.Controls.Add(this.radioBtnPizza);
            this.gbxMainCourse.Controls.Add(this.radioBtnHamBurger);
            this.gbxMainCourse.Location = new System.Drawing.Point(26, 22);
            this.gbxMainCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbxMainCourse.Size = new System.Drawing.Size(216, 160);
            this.gbxMainCourse.TabIndex = 19;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main course";
            // 
            // radioBtnSalad
            // 
            this.radioBtnSalad.AutoSize = true;
            this.radioBtnSalad.Location = new System.Drawing.Point(38, 111);
            this.radioBtnSalad.Name = "radioBtnSalad";
            this.radioBtnSalad.Size = new System.Drawing.Size(124, 24);
            this.radioBtnSalad.TabIndex = 2;
            this.radioBtnSalad.TabStop = true;
            this.radioBtnSalad.Text = "Salad -$4.95";
            this.radioBtnSalad.UseVisualStyleBackColor = true;
            this.radioBtnSalad.CheckedChanged += new System.EventHandler(this.radioBtnSalad_CheckedChanged);
            // 
            // radioBtnPizza
            // 
            this.radioBtnPizza.AutoSize = true;
            this.radioBtnPizza.Location = new System.Drawing.Point(38, 75);
            this.radioBtnPizza.Name = "radioBtnPizza";
            this.radioBtnPizza.Size = new System.Drawing.Size(121, 24);
            this.radioBtnPizza.TabIndex = 1;
            this.radioBtnPizza.TabStop = true;
            this.radioBtnPizza.Text = "Pizza -$5.95";
            this.radioBtnPizza.UseVisualStyleBackColor = true;
            this.radioBtnPizza.CheckedChanged += new System.EventHandler(this.radioBtnPizza_CheckedChanged);
            // 
            // radioBtnHamBurger
            // 
            this.radioBtnHamBurger.AutoSize = true;
            this.radioBtnHamBurger.Location = new System.Drawing.Point(38, 40);
            this.radioBtnHamBurger.Name = "radioBtnHamBurger";
            this.radioBtnHamBurger.Size = new System.Drawing.Size(165, 24);
            this.radioBtnHamBurger.TabIndex = 0;
            this.radioBtnHamBurger.TabStop = true;
            this.radioBtnHamBurger.Text = "HamBurger -$6.95";
            this.radioBtnHamBurger.UseVisualStyleBackColor = true;
            this.radioBtnHamBurger.CheckedChanged += new System.EventHandler(this.radioBtnHamBurger_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(398, 329);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 35);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gpxAddOnItem
            // 
            this.gpxAddOnItem.Controls.Add(this.checkBox3);
            this.gpxAddOnItem.Controls.Add(this.checkBox2);
            this.gpxAddOnItem.Controls.Add(this.checkBox1);
            this.gpxAddOnItem.Location = new System.Drawing.Point(260, 22);
            this.gpxAddOnItem.Name = "gpxAddOnItem";
            this.gpxAddOnItem.Size = new System.Drawing.Size(270, 160);
            this.gpxAddOnItem.TabIndex = 22;
            this.gpxAddOnItem.TabStop = false;
            this.gpxAddOnItem.Text = "Add-On-Item( $0.75/Each)";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 111);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(124, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "French Fries";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 75);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(237, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Ketchup, Mustard, and Mayo";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(236, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Lettuce ,Tomato and Onions";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(566, 386);
            this.Controls.Add(this.gpxAddOnItem);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gbxMainCourse);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLunchOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSD-2354 Lunch Order";
            this.GroupBox1.ResumeLayout(false);
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.gpxAddOnItem.ResumeLayout(false);
            this.gpxAddOnItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPlaceOrder;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblOrderTotal;
        internal System.Windows.Forms.Label lblSalesTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox gbxMainCourse;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioBtnSalad;
        private System.Windows.Forms.RadioButton radioBtnPizza;
        private System.Windows.Forms.RadioButton radioBtnHamBurger;
        private System.Windows.Forms.GroupBox gpxAddOnItem;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

