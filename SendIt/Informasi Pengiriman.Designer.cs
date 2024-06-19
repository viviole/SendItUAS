namespace SendIt
{
    partial class Informasi_Pengiriman
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
            this.pengirimanLabel = new System.Windows.Forms.Label();
            this.receiverNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.receiverAddressInput = new System.Windows.Forms.TextBox();
            this.receiverPhoneInput = new System.Windows.Forms.TextBox();
            this.itemDistanceInput = new System.Windows.Forms.TextBox();
            this.itemWeightInput = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hargaField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pengirimanLabel
            // 
            this.pengirimanLabel.AutoSize = true;
            this.pengirimanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengirimanLabel.Location = new System.Drawing.Point(143, 55);
            this.pengirimanLabel.Name = "pengirimanLabel";
            this.pengirimanLabel.Size = new System.Drawing.Size(282, 32);
            this.pengirimanLabel.TabIndex = 0;
            this.pengirimanLabel.Text = "Informasi Pengiriman";
            this.pengirimanLabel.Click += new System.EventHandler(this.pengirimanLabel_Click);
            // 
            // receiverNameInput
            // 
            this.receiverNameInput.Location = new System.Drawing.Point(149, 180);
            this.receiverNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receiverNameInput.Name = "receiverNameInput";
            this.receiverNameInput.Size = new System.Drawing.Size(183, 22);
            this.receiverNameInput.TabIndex = 1;
            this.receiverNameInput.TextChanged += new System.EventHandler(this.receiverNameInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detail Penerima";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat Tujuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nomor Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Detail Paket";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Berat (kg)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Jarak (km)";
            // 
            // receiverAddressInput
            // 
            this.receiverAddressInput.Location = new System.Drawing.Point(149, 233);
            this.receiverAddressInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receiverAddressInput.Name = "receiverAddressInput";
            this.receiverAddressInput.Size = new System.Drawing.Size(183, 22);
            this.receiverAddressInput.TabIndex = 9;
            this.receiverAddressInput.TextChanged += new System.EventHandler(this.receiverAddressInput_TextChanged);
            // 
            // receiverPhoneInput
            // 
            this.receiverPhoneInput.Location = new System.Drawing.Point(149, 283);
            this.receiverPhoneInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.receiverPhoneInput.Name = "receiverPhoneInput";
            this.receiverPhoneInput.Size = new System.Drawing.Size(183, 22);
            this.receiverPhoneInput.TabIndex = 10;
            this.receiverPhoneInput.TextChanged += new System.EventHandler(this.receiverPhoneInput_TextChanged);
            // 
            // itemDistanceInput
            // 
            this.itemDistanceInput.Location = new System.Drawing.Point(415, 233);
            this.itemDistanceInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemDistanceInput.Name = "itemDistanceInput";
            this.itemDistanceInput.Size = new System.Drawing.Size(183, 22);
            this.itemDistanceInput.TabIndex = 12;
            this.itemDistanceInput.TextChanged += new System.EventHandler(this.itemDistanceInput_TextChanged);
            // 
            // itemWeightInput
            // 
            this.itemWeightInput.Location = new System.Drawing.Point(415, 180);
            this.itemWeightInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemWeightInput.Name = "itemWeightInput";
            this.itemWeightInput.Size = new System.Drawing.Size(183, 22);
            this.itemWeightInput.TabIndex = 11;
            this.itemWeightInput.TextChanged += new System.EventHandler(this.itemWeightInput_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(184, 353);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(149, 43);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "QRIS",
            "Transfer Bank"});
            this.comboBox1.Location = new System.Drawing.Point(415, 283);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Metode Pembayaran";
            // 
            // hargaField
            // 
            this.hargaField.Location = new System.Drawing.Point(416, 353);
            this.hargaField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hargaField.Name = "hargaField";
            this.hargaField.Size = new System.Drawing.Size(181, 22);
            this.hargaField.TabIndex = 16;
            this.hargaField.TextChanged += new System.EventHandler(this.hargaField_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Harga";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(35, 32);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(62, 55);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Informasi_Pengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hargaField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.itemDistanceInput);
            this.Controls.Add(this.itemWeightInput);
            this.Controls.Add(this.receiverPhoneInput);
            this.Controls.Add(this.receiverAddressInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiverNameInput);
            this.Controls.Add(this.pengirimanLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Informasi_Pengiriman";
            this.Text = "Informasi_Pengiriman";
            this.Load += new System.EventHandler(this.Informasi_Pengiriman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pengirimanLabel;
        private System.Windows.Forms.TextBox receiverNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox receiverAddressInput;
        private System.Windows.Forms.TextBox receiverPhoneInput;
        private System.Windows.Forms.TextBox itemDistanceInput;
        private System.Windows.Forms.TextBox itemWeightInput;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hargaField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Back;
    }
}