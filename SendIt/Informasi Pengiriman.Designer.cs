﻿namespace SendIt
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
            this.alamatJemputField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pengirimanLabel
            // 
            this.pengirimanLabel.AutoSize = true;
            this.pengirimanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengirimanLabel.Location = new System.Drawing.Point(108, 26);
            this.pengirimanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pengirimanLabel.Name = "pengirimanLabel";
            this.pengirimanLabel.Size = new System.Drawing.Size(219, 26);
            this.pengirimanLabel.TabIndex = 0;
            this.pengirimanLabel.Text = "Informasi Pengiriman";
            this.pengirimanLabel.Click += new System.EventHandler(this.pengirimanLabel_Click);
            // 
            // receiverNameInput
            // 
            this.receiverNameInput.Location = new System.Drawing.Point(112, 131);
            this.receiverNameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receiverNameInput.Name = "receiverNameInput";
            this.receiverNameInput.Size = new System.Drawing.Size(138, 20);
            this.receiverNameInput.TabIndex = 1;
            this.receiverNameInput.TextChanged += new System.EventHandler(this.receiverNameInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detail Penerima";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat Tujuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nomor Telepon";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Detail Paket";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Berat (kg)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Jarak (km)";
            // 
            // receiverAddressInput
            // 
            this.receiverAddressInput.Location = new System.Drawing.Point(112, 179);
            this.receiverAddressInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receiverAddressInput.Name = "receiverAddressInput";
            this.receiverAddressInput.Size = new System.Drawing.Size(138, 20);
            this.receiverAddressInput.TabIndex = 9;
            this.receiverAddressInput.TextChanged += new System.EventHandler(this.receiverAddressInput_TextChanged);
            // 
            // receiverPhoneInput
            // 
            this.receiverPhoneInput.Location = new System.Drawing.Point(112, 263);
            this.receiverPhoneInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receiverPhoneInput.Name = "receiverPhoneInput";
            this.receiverPhoneInput.Size = new System.Drawing.Size(138, 20);
            this.receiverPhoneInput.TabIndex = 10;
            this.receiverPhoneInput.TextChanged += new System.EventHandler(this.receiverPhoneInput_TextChanged);
            // 
            // itemDistanceInput
            // 
            this.itemDistanceInput.Location = new System.Drawing.Point(311, 189);
            this.itemDistanceInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemDistanceInput.Name = "itemDistanceInput";
            this.itemDistanceInput.Size = new System.Drawing.Size(138, 20);
            this.itemDistanceInput.TabIndex = 12;
            this.itemDistanceInput.TextChanged += new System.EventHandler(this.itemDistanceInput_TextChanged);
            // 
            // itemWeightInput
            // 
            this.itemWeightInput.Location = new System.Drawing.Point(311, 146);
            this.itemWeightInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemWeightInput.Name = "itemWeightInput";
            this.itemWeightInput.Size = new System.Drawing.Size(138, 20);
            this.itemWeightInput.TabIndex = 11;
            this.itemWeightInput.TextChanged += new System.EventHandler(this.itemWeightInput_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(215, 320);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 35);
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
            this.comboBox1.Location = new System.Drawing.Point(311, 230);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Metode Pembayaran";
            // 
            // hargaField
            // 
            this.hargaField.Location = new System.Drawing.Point(312, 287);
            this.hargaField.Name = "hargaField";
            this.hargaField.Size = new System.Drawing.Size(137, 20);
            this.hargaField.TabIndex = 16;
            this.hargaField.TextChanged += new System.EventHandler(this.hargaField_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 271);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Harga";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(26, 26);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(46, 45);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // alamatJemputField
            // 
            this.alamatJemputField.Location = new System.Drawing.Point(113, 226);
            this.alamatJemputField.Margin = new System.Windows.Forms.Padding(2);
            this.alamatJemputField.Name = "alamatJemputField";
            this.alamatJemputField.Size = new System.Drawing.Size(138, 20);
            this.alamatJemputField.TabIndex = 20;
            this.alamatJemputField.TextChanged += new System.EventHandler(this.alamatJemputField_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Alamat Jemput";
            // 
            // Informasi_Pengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.alamatJemputField);
            this.Controls.Add(this.label10);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox alamatJemputField;
        private System.Windows.Forms.Label label10;
    }
}