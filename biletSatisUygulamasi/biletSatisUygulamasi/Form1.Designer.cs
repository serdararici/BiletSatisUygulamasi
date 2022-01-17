namespace biletSatisUygulamasi
{
    partial class Form1
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
            this.musteriBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttoncikis = new System.Windows.Forms.Button();
            this.biletBtn = new System.Windows.Forms.Button();
            this.personelBtn = new System.Windows.Forms.Button();
            this.etkinlikBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilet Uygulaması";
            // 
            // musteriBtn
            // 
            this.musteriBtn.BackColor = System.Drawing.Color.Gold;
            this.musteriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriBtn.Location = new System.Drawing.Point(98, 216);
            this.musteriBtn.Name = "musteriBtn";
            this.musteriBtn.Size = new System.Drawing.Size(205, 118);
            this.musteriBtn.TabIndex = 1;
            this.musteriBtn.Text = "Müşteri İşlemleri";
            this.musteriBtn.UseVisualStyleBackColor = false;
            this.musteriBtn.Click += new System.EventHandler(this.musteriBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::biletSatisUygulamasi.Properties.Resources.ticket;
            this.pictureBox1.Location = new System.Drawing.Point(727, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttoncikis
            // 
            this.buttoncikis.BackColor = System.Drawing.Color.Crimson;
            this.buttoncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttoncikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttoncikis.Location = new System.Drawing.Point(759, 473);
            this.buttoncikis.Name = "buttoncikis";
            this.buttoncikis.Size = new System.Drawing.Size(193, 90);
            this.buttoncikis.TabIndex = 3;
            this.buttoncikis.Text = "ÇIKIŞ";
            this.buttoncikis.UseVisualStyleBackColor = false;
            this.buttoncikis.Click += new System.EventHandler(this.buttoncikis_Click);
            // 
            // biletBtn
            // 
            this.biletBtn.BackColor = System.Drawing.Color.Gold;
            this.biletBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.biletBtn.Location = new System.Drawing.Point(393, 216);
            this.biletBtn.Name = "biletBtn";
            this.biletBtn.Size = new System.Drawing.Size(205, 118);
            this.biletBtn.TabIndex = 4;
            this.biletBtn.Text = "Bilet İşlemleri";
            this.biletBtn.UseVisualStyleBackColor = false;
            this.biletBtn.Click += new System.EventHandler(this.biletBtn_Click);
            // 
            // personelBtn
            // 
            this.personelBtn.BackColor = System.Drawing.Color.Gold;
            this.personelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelBtn.Location = new System.Drawing.Point(98, 408);
            this.personelBtn.Name = "personelBtn";
            this.personelBtn.Size = new System.Drawing.Size(205, 118);
            this.personelBtn.TabIndex = 5;
            this.personelBtn.Text = "Personel İşlemleri";
            this.personelBtn.UseVisualStyleBackColor = false;
            this.personelBtn.Click += new System.EventHandler(this.personelBtn_Click);
            // 
            // etkinlikBtn
            // 
            this.etkinlikBtn.BackColor = System.Drawing.Color.Gold;
            this.etkinlikBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.etkinlikBtn.Location = new System.Drawing.Point(393, 408);
            this.etkinlikBtn.Name = "etkinlikBtn";
            this.etkinlikBtn.Size = new System.Drawing.Size(205, 118);
            this.etkinlikBtn.TabIndex = 6;
            this.etkinlikBtn.Text = "Etkinlik İşlemleri";
            this.etkinlikBtn.UseVisualStyleBackColor = false;
            this.etkinlikBtn.Click += new System.EventHandler(this.etkinlikBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(998, 625);
            this.Controls.Add(this.etkinlikBtn);
            this.Controls.Add(this.personelBtn);
            this.Controls.Add(this.biletBtn);
            this.Controls.Add(this.buttoncikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.musteriBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button musteriBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttoncikis;
        private System.Windows.Forms.Button biletBtn;
        private System.Windows.Forms.Button personelBtn;
        private System.Windows.Forms.Button etkinlikBtn;
    }
}

