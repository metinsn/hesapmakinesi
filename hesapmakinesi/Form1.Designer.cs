namespace hesapmakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnBol = new System.Windows.Forms.Button();
            this.BtncCarp = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btncikar = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnTopla = new System.Windows.Forms.Button();
            this.BtnEşittir = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.EkranTxtBox = new System.Windows.Forms.TextBox();
            this.BtnOndalik = new System.Windows.Forms.Button();
            this.BtnHafizasil = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnYuzde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn1.Location = new System.Drawing.Point(12, 58);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(100, 60);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn2.Location = new System.Drawing.Point(118, 58);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(100, 60);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn3.Location = new System.Drawing.Point(224, 58);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(100, 60);
            this.Btn3.TabIndex = 2;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnBol
            // 
            this.BtnBol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnBol.Location = new System.Drawing.Point(330, 58);
            this.BtnBol.Name = "BtnBol";
            this.BtnBol.Size = new System.Drawing.Size(100, 60);
            this.BtnBol.TabIndex = 3;
            this.BtnBol.Text = "/";
            this.BtnBol.UseVisualStyleBackColor = true;
            this.BtnBol.Click += new System.EventHandler(this.dortislem);
            // 
            // BtncCarp
            // 
            this.BtncCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtncCarp.Location = new System.Drawing.Point(330, 124);
            this.BtncCarp.Name = "BtncCarp";
            this.BtncCarp.Size = new System.Drawing.Size(100, 60);
            this.BtncCarp.TabIndex = 7;
            this.BtncCarp.Text = "*";
            this.BtncCarp.UseVisualStyleBackColor = true;
            this.BtncCarp.Click += new System.EventHandler(this.dortislem);
            // 
            // Btn6
            // 
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn6.Location = new System.Drawing.Point(224, 124);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(100, 60);
            this.Btn6.TabIndex = 6;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn5
            // 
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn5.Location = new System.Drawing.Point(118, 124);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(100, 60);
            this.Btn5.TabIndex = 5;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn4
            // 
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn4.Location = new System.Drawing.Point(12, 124);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(100, 60);
            this.Btn4.TabIndex = 4;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btncikar
            // 
            this.Btncikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btncikar.Location = new System.Drawing.Point(330, 190);
            this.Btncikar.Name = "Btncikar";
            this.Btncikar.Size = new System.Drawing.Size(100, 60);
            this.Btncikar.TabIndex = 11;
            this.Btncikar.Text = "-";
            this.Btncikar.UseVisualStyleBackColor = true;
            this.Btncikar.Click += new System.EventHandler(this.dortislem);
            // 
            // Btn9
            // 
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn9.Location = new System.Drawing.Point(224, 190);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(100, 60);
            this.Btn9.TabIndex = 10;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn8
            // 
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn8.Location = new System.Drawing.Point(118, 190);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(100, 60);
            this.Btn8.TabIndex = 9;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Btn7
            // 
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn7.Location = new System.Drawing.Point(12, 190);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(100, 60);
            this.Btn7.TabIndex = 8;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnTopla
            // 
            this.BtnTopla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnTopla.Location = new System.Drawing.Point(330, 256);
            this.BtnTopla.Name = "BtnTopla";
            this.BtnTopla.Size = new System.Drawing.Size(100, 60);
            this.BtnTopla.TabIndex = 15;
            this.BtnTopla.Text = "+";
            this.BtnTopla.UseVisualStyleBackColor = true;
            this.BtnTopla.Click += new System.EventHandler(this.dortislem);
            // 
            // BtnEşittir
            // 
            this.BtnEşittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnEşittir.Location = new System.Drawing.Point(224, 322);
            this.BtnEşittir.Name = "BtnEşittir";
            this.BtnEşittir.Size = new System.Drawing.Size(100, 60);
            this.BtnEşittir.TabIndex = 14;
            this.BtnEşittir.Text = "=";
            this.BtnEşittir.UseVisualStyleBackColor = true;
            this.BtnEşittir.Click += new System.EventHandler(this.BtnEşittir_Click);
            // 
            // Btn0
            // 
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn0.Location = new System.Drawing.Point(118, 256);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(100, 60);
            this.Btn0.TabIndex = 13;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnSil.Location = new System.Drawing.Point(12, 322);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(100, 60);
            this.BtnSil.TabIndex = 12;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // EkranTxtBox
            // 
            this.EkranTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EkranTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkranTxtBox.Location = new System.Drawing.Point(12, 12);
            this.EkranTxtBox.Multiline = true;
            this.EkranTxtBox.Name = "EkranTxtBox";
            this.EkranTxtBox.Size = new System.Drawing.Size(418, 40);
            this.EkranTxtBox.TabIndex = 16;
            // 
            // BtnOndalik
            // 
            this.BtnOndalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnOndalik.Location = new System.Drawing.Point(12, 256);
            this.BtnOndalik.Name = "BtnOndalik";
            this.BtnOndalik.Size = new System.Drawing.Size(100, 60);
            this.BtnOndalik.TabIndex = 17;
            this.BtnOndalik.Text = ",";
            this.BtnOndalik.UseVisualStyleBackColor = true;
            this.BtnOndalik.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnHafizasil
            // 
            this.BtnHafizasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnHafizasil.Location = new System.Drawing.Point(118, 322);
            this.BtnHafizasil.Name = "BtnHafizasil";
            this.BtnHafizasil.Size = new System.Drawing.Size(100, 60);
            this.BtnHafizasil.TabIndex = 18;
            this.BtnHafizasil.Text = "Hafıza Sil";
            this.BtnHafizasil.UseVisualStyleBackColor = true;
            this.BtnHafizasil.Click += new System.EventHandler(this.BtnHafizasil_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(330, 322);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(100, 56);
            this.listBox1.TabIndex = 19;
            // 
            // BtnYuzde
            // 
            this.BtnYuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnYuzde.Location = new System.Drawing.Point(224, 256);
            this.BtnYuzde.Name = "BtnYuzde";
            this.BtnYuzde.Size = new System.Drawing.Size(100, 60);
            this.BtnYuzde.TabIndex = 20;
            this.BtnYuzde.Text = "%";
            this.BtnYuzde.UseVisualStyleBackColor = true;
            this.BtnYuzde.Click += new System.EventHandler(this.BtnYuzde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(440, 390);
            this.Controls.Add(this.BtnYuzde);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnHafizasil);
            this.Controls.Add(this.BtnOndalik);
            this.Controls.Add(this.EkranTxtBox);
            this.Controls.Add(this.BtnTopla);
            this.Controls.Add(this.BtnEşittir);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.Btncikar);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtncCarp);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnBol);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnBol;
        private System.Windows.Forms.Button BtncCarp;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btncikar;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnTopla;
        private System.Windows.Forms.Button BtnEşittir;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox EkranTxtBox;
        private System.Windows.Forms.Button BtnOndalik;
        private System.Windows.Forms.Button BtnHafizasil;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnYuzde;
    }
}

