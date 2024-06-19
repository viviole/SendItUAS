namespace SendIt
{
    partial class KurirDetailPesanan
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sedangDipickupButton = new System.Windows.Forms.Button();
            this.sedangDikirimButton = new System.Windows.Forms.Button();
            this.sudahDiterimaButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(161, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(488, 196);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // sedangDipickupButton
            // 
            this.sedangDipickupButton.Location = new System.Drawing.Point(161, 333);
            this.sedangDipickupButton.Name = "sedangDipickupButton";
            this.sedangDipickupButton.Size = new System.Drawing.Size(136, 48);
            this.sedangDipickupButton.TabIndex = 2;
            this.sedangDipickupButton.Text = "Sedang Dipickup";
            this.sedangDipickupButton.UseVisualStyleBackColor = true;
            this.sedangDipickupButton.Click += new System.EventHandler(this.sedangDipickupButton_Click);
            // 
            // sedangDikirimButton
            // 
            this.sedangDikirimButton.Location = new System.Drawing.Point(340, 333);
            this.sedangDikirimButton.Name = "sedangDikirimButton";
            this.sedangDikirimButton.Size = new System.Drawing.Size(136, 48);
            this.sedangDikirimButton.TabIndex = 3;
            this.sedangDikirimButton.Text = "Sedang Dikirim";
            this.sedangDikirimButton.UseVisualStyleBackColor = true;
            this.sedangDikirimButton.Click += new System.EventHandler(this.sedangDikirimButton_Click);
            // 
            // sudahDiterimaButton
            // 
            this.sudahDiterimaButton.Location = new System.Drawing.Point(513, 333);
            this.sudahDiterimaButton.Name = "sudahDiterimaButton";
            this.sudahDiterimaButton.Size = new System.Drawing.Size(136, 48);
            this.sudahDiterimaButton.TabIndex = 4;
            this.sudahDiterimaButton.Text = "Sudah Diterima";
            this.sudahDiterimaButton.UseVisualStyleBackColor = true;
            this.sudahDiterimaButton.Click += new System.EventHandler(this.sudahDiterimaButton_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(30, 31);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(108, 50);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // KurirDetailPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.sudahDiterimaButton);
            this.Controls.Add(this.sedangDikirimButton);
            this.Controls.Add(this.sedangDipickupButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "KurirDetailPesanan";
            this.Text = "KurirDetailPesanan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sedangDipickupButton;
        private System.Windows.Forms.Button sedangDikirimButton;
        private System.Windows.Forms.Button sudahDiterimaButton;
        private System.Windows.Forms.Button Back;
    }
}