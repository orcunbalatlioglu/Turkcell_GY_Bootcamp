namespace SingleResponsibility
{
    partial class ShoppingCatalog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnItem1 = new System.Windows.Forms.Button();
            this.btnItem2 = new System.Windows.Forms.Button();
            this.btnItem3 = new System.Windows.Forms.Button();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(286, 312);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(81, 44);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnItem1
            // 
            this.btnItem1.Location = new System.Drawing.Point(51, 42);
            this.btnItem1.Name = "btnItem1";
            this.btnItem1.Size = new System.Drawing.Size(75, 49);
            this.btnItem1.TabIndex = 1;
            this.btnItem1.Text = "Item 1";
            this.btnItem1.UseVisualStyleBackColor = true;
            this.btnItem1.Click += new System.EventHandler(this.btnItem1_Click);
            // 
            // btnItem2
            // 
            this.btnItem2.Location = new System.Drawing.Point(51, 128);
            this.btnItem2.Name = "btnItem2";
            this.btnItem2.Size = new System.Drawing.Size(75, 55);
            this.btnItem2.TabIndex = 2;
            this.btnItem2.Text = "Item 2";
            this.btnItem2.UseVisualStyleBackColor = true;
            this.btnItem2.Click += new System.EventHandler(this.btnItem2_Click_1);
            // 
            // btnItem3
            // 
            this.btnItem3.Location = new System.Drawing.Point(51, 219);
            this.btnItem3.Name = "btnItem3";
            this.btnItem3.Size = new System.Drawing.Size(75, 55);
            this.btnItem3.TabIndex = 3;
            this.btnItem3.Text = "Item 3";
            this.btnItem3.UseVisualStyleBackColor = true;
            this.btnItem3.Click += new System.EventHandler(this.btnItem3_Click_1);
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(310, 124);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(39, 23);
            this.numericAmount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(241, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(247, 87);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(229, 124);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(292, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(286, 39);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(286, 84);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 9;
            // 
            // ShoppingCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 383);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.btnItem3);
            this.Controls.Add(this.btnItem2);
            this.Controls.Add(this.btnItem1);
            this.Controls.Add(this.btnOrder);
            this.Name = "ShoppingCatalog";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOrder;
        private Button btnItem1;
        private Button btnItem2;
        private Button btnItem3;
        private NumericUpDown numericAmount;
        private Label label1;
        private Label lblName;
        private Label lblPrice;
        private Label lblAmount;
        private Button btnAdd;
        private TextBox txtName;
        private TextBox txtPrice;
    }
}