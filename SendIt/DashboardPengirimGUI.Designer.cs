namespace SendIt
{
    partial class DashboardPengirimGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPengirimGUI));
            this.kirimButton = new System.Windows.Forms.Button();
            this.informasiButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelFitur = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kirimButton
            // 
            this.kirimButton.Location = new System.Drawing.Point(98, 249);
            this.kirimButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kirimButton.Name = "kirimButton";
            this.kirimButton.Size = new System.Drawing.Size(161, 51);
            this.kirimButton.TabIndex = 0;
            this.kirimButton.Text = "Kirim Barang";
            this.kirimButton.UseVisualStyleBackColor = true;
            this.kirimButton.Click += new System.EventHandler(this.kirimButton_Click);
            // 
            // informasiButton
            // 
            this.informasiButton.Location = new System.Drawing.Point(373, 249);
            this.informasiButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.informasiButton.Name = "informasiButton";
            this.informasiButton.Size = new System.Drawing.Size(161, 51);
            this.informasiButton.TabIndex = 1;
            this.informasiButton.Text = "Informasi Pengiriman";
            this.informasiButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(373, 74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelFitur
            // 
            this.labelFitur.AutoSize = true;
            this.labelFitur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFitur.Location = new System.Drawing.Point(267, 32);
            this.labelFitur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFitur.Name = "labelFitur";
            this.labelFitur.Size = new System.Drawing.Size(55, 26);
            this.labelFitur.TabIndex = 4;
            this.labelFitur.Text = "Fitur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardPengirimGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelFitur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.informasiButton);
            this.Controls.Add(this.kirimButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashboardPengirimGUI";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kirimButton;
        private System.Windows.Forms.Button informasiButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelFitur;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}