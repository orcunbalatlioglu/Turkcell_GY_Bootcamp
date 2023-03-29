namespace OpenClosedPrinciple
{
    partial class PaymentPage
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
            this.lblSlash = new System.Windows.Forms.Label();
            this.lblSkt = new System.Windows.Forms.Label();
            this.txtCreditCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.lblCardName = new System.Windows.Forms.Label();
            this.chc3Dsecure = new System.Windows.Forms.CheckBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCv2 = new System.Windows.Forms.Label();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.maskedTxtCv2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Location = new System.Drawing.Point(197, 116);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(12, 15);
            this.lblSlash.TabIndex = 2;
            this.lblSlash.Text = "/";
            // 
            // lblSkt
            // 
            this.lblSkt.AutoSize = true;
            this.lblSkt.Location = new System.Drawing.Point(21, 116);
            this.lblSkt.Name = "lblSkt";
            this.lblSkt.Size = new System.Drawing.Size(111, 15);
            this.lblSkt.TabIndex = 3;
            this.lblSkt.Text = "Son Kullanma Tarihi";
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(149, 68);
            this.txtCreditCardNumber.Mask = "0000 0000 0000 0000";
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(117, 23);
            this.txtCreditCardNumber.TabIndex = 4;
            this.txtCreditCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(17, 71);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(115, 15);
            this.lblCardNo.TabIndex = 5;
            this.lblCardNo.Text = "Kredi Kartı Numarası";
            // 
            // txtCardName
            // 
            this.txtCardName.Location = new System.Drawing.Point(145, 29);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(124, 23);
            this.txtCardName.TabIndex = 6;
            this.txtCardName.TextChanged += new System.EventHandler(this.txtCardName_TextChanged);
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Location = new System.Drawing.Point(28, 32);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(104, 15);
            this.lblCardName.TabIndex = 7;
            this.lblCardName.Text = "Kart Üzerideki İsim";
            // 
            // chc3Dsecure
            // 
            this.chc3Dsecure.AutoSize = true;
            this.chc3Dsecure.Location = new System.Drawing.Point(28, 185);
            this.chc3Dsecure.Name = "chc3Dsecure";
            this.chc3Dsecure.Size = new System.Drawing.Size(114, 19);
            this.chc3Dsecure.TabIndex = 8;
            this.chc3Dsecure.Text = "3D Secure Kullan";
            this.chc3Dsecure.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(90, 222);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(119, 34);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Ödemeyi Tamamla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCv2
            // 
            this.lblCv2.AutoSize = true;
            this.lblCv2.Location = new System.Drawing.Point(104, 152);
            this.lblCv2.Name = "lblCv2";
            this.lblCv2.Size = new System.Drawing.Size(28, 15);
            this.lblCv2.TabIndex = 11;
            this.lblCv2.Text = "CV2";
            // 
            // comboYear
            // 
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.comboYear.Location = new System.Drawing.Point(215, 113);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(42, 23);
            this.comboYear.TabIndex = 13;
            // 
            // comboMonth
            // 
            this.comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboMonth.Location = new System.Drawing.Point(149, 113);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(42, 23);
            this.comboMonth.TabIndex = 14;
            // 
            // maskedTxtCv2
            // 
            this.maskedTxtCv2.Location = new System.Drawing.Point(149, 152);
            this.maskedTxtCv2.Mask = "000";
            this.maskedTxtCv2.Name = "maskedTxtCv2";
            this.maskedTxtCv2.Size = new System.Drawing.Size(28, 23);
            this.maskedTxtCv2.TabIndex = 15;
            this.maskedTxtCv2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTxtCv2.ValidatingType = typeof(int);
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.maskedTxtCv2);
            this.Controls.Add(this.comboMonth);
            this.Controls.Add(this.comboYear);
            this.Controls.Add(this.lblCv2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.chc3Dsecure);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.lblSkt);
            this.Controls.Add(this.lblSlash);
            this.Name = "PaymentPage";
            this.Text = "PaymentPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblSlash;
        private Label lblSkt;
        private MaskedTextBox txtCreditCardNumber;
        private Label lblCardNo;
        private TextBox txtCardName;
        private Label lblCardName;
        private CheckBox chc3Dsecure;
        private Button btnConfirm;
        private Label lblCv2;
        private ComboBox comboYear;
        private ComboBox comboMonth;
        private MaskedTextBox maskedTxtCv2;
    }
}