
namespace ZarAtmaOyunu
{
    partial class Form1
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
            this.buttonOyuncu1 = new System.Windows.Forms.Button();
            this.buttonOyuncu2 = new System.Windows.Forms.Button();
            this.textBoxOyuncu1Ad = new System.Windows.Forms.TextBox();
            this.labelOyuncu1Ad = new System.Windows.Forms.Label();
            this.labelOyuncu2Ad = new System.Windows.Forms.Label();
            this.buttonOyuncu1AdEkle = new System.Windows.Forms.Button();
            this.buttonOyuncu2AdEkle = new System.Windows.Forms.Button();
            this.textBoxOyuncu2Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKazanan = new System.Windows.Forms.Label();
            this.labelOyuncu1Zar = new System.Windows.Forms.Label();
            this.labelOyuncu2Zar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOyuncu1Bakiye = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOyuncu2Bakiye = new System.Windows.Forms.Label();
            this.labelOyuncu1Bahis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOyuncu2Bahis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOyuncu1
            // 
            this.buttonOyuncu1.Location = new System.Drawing.Point(70, 195);
            this.buttonOyuncu1.Name = "buttonOyuncu1";
            this.buttonOyuncu1.Size = new System.Drawing.Size(80, 62);
            this.buttonOyuncu1.TabIndex = 0;
            this.buttonOyuncu1.Text = "1. Oyuncu Zar At";
            this.buttonOyuncu1.UseVisualStyleBackColor = true;
            this.buttonOyuncu1.Click += new System.EventHandler(this.buttonOyuncu1_Click);
            // 
            // buttonOyuncu2
            // 
            this.buttonOyuncu2.Enabled = false;
            this.buttonOyuncu2.Location = new System.Drawing.Point(214, 195);
            this.buttonOyuncu2.Name = "buttonOyuncu2";
            this.buttonOyuncu2.Size = new System.Drawing.Size(84, 62);
            this.buttonOyuncu2.TabIndex = 1;
            this.buttonOyuncu2.Text = "2. Oyuncu Zar At";
            this.buttonOyuncu2.UseVisualStyleBackColor = true;
            this.buttonOyuncu2.Click += new System.EventHandler(this.buttonOyuncu2_Click);
            // 
            // textBoxOyuncu1Ad
            // 
            this.textBoxOyuncu1Ad.Location = new System.Drawing.Point(60, 76);
            this.textBoxOyuncu1Ad.Name = "textBoxOyuncu1Ad";
            this.textBoxOyuncu1Ad.Size = new System.Drawing.Size(103, 23);
            this.textBoxOyuncu1Ad.TabIndex = 2;
            // 
            // labelOyuncu1Ad
            // 
            this.labelOyuncu1Ad.AutoSize = true;
            this.labelOyuncu1Ad.Location = new System.Drawing.Point(91, 161);
            this.labelOyuncu1Ad.Name = "labelOyuncu1Ad";
            this.labelOyuncu1Ad.Size = new System.Drawing.Size(0, 15);
            this.labelOyuncu1Ad.TabIndex = 4;
            // 
            // labelOyuncu2Ad
            // 
            this.labelOyuncu2Ad.AutoSize = true;
            this.labelOyuncu2Ad.Location = new System.Drawing.Point(240, 161);
            this.labelOyuncu2Ad.Name = "labelOyuncu2Ad";
            this.labelOyuncu2Ad.Size = new System.Drawing.Size(0, 15);
            this.labelOyuncu2Ad.TabIndex = 5;
            // 
            // buttonOyuncu1AdEkle
            // 
            this.buttonOyuncu1AdEkle.Location = new System.Drawing.Point(60, 105);
            this.buttonOyuncu1AdEkle.Name = "buttonOyuncu1AdEkle";
            this.buttonOyuncu1AdEkle.Size = new System.Drawing.Size(103, 39);
            this.buttonOyuncu1AdEkle.TabIndex = 6;
            this.buttonOyuncu1AdEkle.Text = "1. Oyuncu Ad Gir";
            this.buttonOyuncu1AdEkle.UseVisualStyleBackColor = true;
            this.buttonOyuncu1AdEkle.Click += new System.EventHandler(this.buttonOyuncu1AdEkle_Click);
            // 
            // buttonOyuncu2AdEkle
            // 
            this.buttonOyuncu2AdEkle.Location = new System.Drawing.Point(204, 105);
            this.buttonOyuncu2AdEkle.Name = "buttonOyuncu2AdEkle";
            this.buttonOyuncu2AdEkle.Size = new System.Drawing.Size(103, 39);
            this.buttonOyuncu2AdEkle.TabIndex = 8;
            this.buttonOyuncu2AdEkle.Text = "2. Oyuncu Ad Gir";
            this.buttonOyuncu2AdEkle.UseVisualStyleBackColor = true;
            this.buttonOyuncu2AdEkle.Click += new System.EventHandler(this.buttonOyuncu2AdEkle_Click);
            // 
            // textBoxOyuncu2Ad
            // 
            this.textBoxOyuncu2Ad.Location = new System.Drawing.Point(204, 76);
            this.textBoxOyuncu2Ad.Name = "textBoxOyuncu2Ad";
            this.textBoxOyuncu2Ad.Size = new System.Drawing.Size(103, 23);
            this.textBoxOyuncu2Ad.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "KAZANAN";
            // 
            // labelKazanan
            // 
            this.labelKazanan.AutoSize = true;
            this.labelKazanan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKazanan.Location = new System.Drawing.Point(12, 328);
            this.labelKazanan.Name = "labelKazanan";
            this.labelKazanan.Size = new System.Drawing.Size(43, 21);
            this.labelKazanan.TabIndex = 10;
            this.labelKazanan.Text = "label";
            this.labelKazanan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelOyuncu1Zar
            // 
            this.labelOyuncu1Zar.AutoSize = true;
            this.labelOyuncu1Zar.Location = new System.Drawing.Point(92, 270);
            this.labelOyuncu1Zar.Name = "labelOyuncu1Zar";
            this.labelOyuncu1Zar.Size = new System.Drawing.Size(0, 15);
            this.labelOyuncu1Zar.TabIndex = 11;
            // 
            // labelOyuncu2Zar
            // 
            this.labelOyuncu2Zar.AutoSize = true;
            this.labelOyuncu2Zar.Location = new System.Drawing.Point(241, 270);
            this.labelOyuncu2Zar.Name = "labelOyuncu2Zar";
            this.labelOyuncu2Zar.Size = new System.Drawing.Size(0, 15);
            this.labelOyuncu2Zar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bakiye : ";
            // 
            // labelOyuncu1Bakiye
            // 
            this.labelOyuncu1Bakiye.AutoSize = true;
            this.labelOyuncu1Bakiye.Location = new System.Drawing.Point(125, 34);
            this.labelOyuncu1Bakiye.Name = "labelOyuncu1Bakiye";
            this.labelOyuncu1Bakiye.Size = new System.Drawing.Size(25, 15);
            this.labelOyuncu1Bakiye.TabIndex = 15;
            this.labelOyuncu1Bakiye.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bakiye : ";
            // 
            // labelOyuncu2Bakiye
            // 
            this.labelOyuncu2Bakiye.AutoSize = true;
            this.labelOyuncu2Bakiye.Location = new System.Drawing.Point(269, 34);
            this.labelOyuncu2Bakiye.Name = "labelOyuncu2Bakiye";
            this.labelOyuncu2Bakiye.Size = new System.Drawing.Size(25, 15);
            this.labelOyuncu2Bakiye.TabIndex = 17;
            this.labelOyuncu2Bakiye.Text = "100";
            // 
            // labelOyuncu1Bahis
            // 
            this.labelOyuncu1Bahis.AutoSize = true;
            this.labelOyuncu1Bahis.Location = new System.Drawing.Point(125, 58);
            this.labelOyuncu1Bahis.Name = "labelOyuncu1Bahis";
            this.labelOyuncu1Bahis.Size = new System.Drawing.Size(13, 15);
            this.labelOyuncu1Bahis.TabIndex = 19;
            this.labelOyuncu1Bahis.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Bahis : ";
            // 
            // labelOyuncu2Bahis
            // 
            this.labelOyuncu2Bahis.AutoSize = true;
            this.labelOyuncu2Bahis.Location = new System.Drawing.Point(269, 58);
            this.labelOyuncu2Bahis.Name = "labelOyuncu2Bahis";
            this.labelOyuncu2Bahis.Size = new System.Drawing.Size(13, 15);
            this.labelOyuncu2Bahis.TabIndex = 21;
            this.labelOyuncu2Bahis.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Bahis : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 401);
            this.Controls.Add(this.labelOyuncu2Bahis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelOyuncu1Bahis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelOyuncu2Bakiye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelOyuncu1Bakiye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelOyuncu2Zar);
            this.Controls.Add(this.labelOyuncu1Zar);
            this.Controls.Add(this.labelKazanan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOyuncu2AdEkle);
            this.Controls.Add(this.textBoxOyuncu2Ad);
            this.Controls.Add(this.buttonOyuncu1AdEkle);
            this.Controls.Add(this.labelOyuncu2Ad);
            this.Controls.Add(this.labelOyuncu1Ad);
            this.Controls.Add(this.textBoxOyuncu1Ad);
            this.Controls.Add(this.buttonOyuncu2);
            this.Controls.Add(this.buttonOyuncu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOyuncu1;
        private System.Windows.Forms.Button buttonOyuncu2;
        private System.Windows.Forms.TextBox textBoxOyuncu1Ad;
        private System.Windows.Forms.Label labelOyuncu1Ad;
        private System.Windows.Forms.Label labelOyuncu2Ad;
        private System.Windows.Forms.Button buttonOyuncu1AdEkle;
        private System.Windows.Forms.Button buttonOyuncu2AdEkle;
        private System.Windows.Forms.TextBox textBoxOyuncu2Ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKazanan;
        private System.Windows.Forms.Label labelOyuncu1Zar;
        private System.Windows.Forms.Label labelOyuncu2Zar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOyuncu1Bakiye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOyuncu2Bakiye;
        private System.Windows.Forms.Label labelOyuncu1Bahis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOyuncu2Bahis;
        private System.Windows.Forms.Label label7;
    }
}

