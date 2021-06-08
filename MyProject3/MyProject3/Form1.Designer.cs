
namespace MyProject3
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
            this.txNama = new System.Windows.Forms.TextBox();
            this.cbDepartemen = new System.Windows.Forms.ComboBox();
            this.cbGolongan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbpria = new System.Windows.Forms.RadioButton();
            this.rbWanita = new System.Windows.Forms.RadioButton();
            this.rbMenikah = new System.Windows.Forms.RadioButton();
            this.rbBelumMenikah = new System.Windows.Forms.RadioButton();
            this.nmJmAnak = new System.Windows.Forms.NumericUpDown();
            this.txGjPokok = new System.Windows.Forms.TextBox();
            this.txTnjIstri = new System.Windows.Forms.TextBox();
            this.txTnjAnak = new System.Windows.Forms.TextBox();
            this.txTotalGaji = new System.Windows.Forms.TextBox();
            this.hitung = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmJmAnak)).BeginInit();
            this.SuspendLayout();
            // 
            // txNama
            // 
            this.txNama.Location = new System.Drawing.Point(416, 30);
            this.txNama.Name = "txNama";
            this.txNama.Size = new System.Drawing.Size(358, 31);
            this.txNama.TabIndex = 0;
            // 
            // cbDepartemen
            // 
            this.cbDepartemen.FormattingEnabled = true;
            this.cbDepartemen.Items.AddRange(new object[] {
            "Administrator",
            "Keuangan",
            "Marketing"});
            this.cbDepartemen.Location = new System.Drawing.Point(416, 84);
            this.cbDepartemen.Name = "cbDepartemen";
            this.cbDepartemen.Size = new System.Drawing.Size(358, 33);
            this.cbDepartemen.TabIndex = 1;
            // 
            // cbGolongan
            // 
            this.cbGolongan.FormattingEnabled = true;
            this.cbGolongan.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cbGolongan.Location = new System.Drawing.Point(416, 145);
            this.cbGolongan.Name = "cbGolongan";
            this.cbGolongan.Size = new System.Drawing.Size(358, 33);
            this.cbGolongan.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWanita);
            this.groupBox1.Controls.Add(this.rbpria);
            this.groupBox1.Location = new System.Drawing.Point(416, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBelumMenikah);
            this.groupBox2.Controls.Add(this.rbMenikah);
            this.groupBox2.Location = new System.Drawing.Point(416, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 83);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // rbpria
            // 
            this.rbpria.AutoSize = true;
            this.rbpria.Location = new System.Drawing.Point(25, 32);
            this.rbpria.Name = "rbpria";
            this.rbpria.Size = new System.Drawing.Size(66, 29);
            this.rbpria.TabIndex = 0;
            this.rbpria.TabStop = true;
            this.rbpria.Text = "Pria";
            this.rbpria.UseVisualStyleBackColor = true;
            // 
            // rbWanita
            // 
            this.rbWanita.AutoSize = true;
            this.rbWanita.Location = new System.Drawing.Point(197, 32);
            this.rbWanita.Name = "rbWanita";
            this.rbWanita.Size = new System.Drawing.Size(91, 29);
            this.rbWanita.TabIndex = 1;
            this.rbWanita.TabStop = true;
            this.rbWanita.Text = "Wanita";
            this.rbWanita.UseVisualStyleBackColor = true;
            // 
            // rbMenikah
            // 
            this.rbMenikah.AutoSize = true;
            this.rbMenikah.Location = new System.Drawing.Point(25, 30);
            this.rbMenikah.Name = "rbMenikah";
            this.rbMenikah.Size = new System.Drawing.Size(104, 29);
            this.rbMenikah.TabIndex = 1;
            this.rbMenikah.TabStop = true;
            this.rbMenikah.Text = "Menikah";
            this.rbMenikah.UseVisualStyleBackColor = true;
            // 
            // rbBelumMenikah
            // 
            this.rbBelumMenikah.AutoSize = true;
            this.rbBelumMenikah.Location = new System.Drawing.Point(197, 30);
            this.rbBelumMenikah.Name = "rbBelumMenikah";
            this.rbBelumMenikah.Size = new System.Drawing.Size(158, 29);
            this.rbBelumMenikah.TabIndex = 2;
            this.rbBelumMenikah.TabStop = true;
            this.rbBelumMenikah.Text = "Belum Menikah";
            this.rbBelumMenikah.UseVisualStyleBackColor = true;
            // 
            // nmJmAnak
            // 
            this.nmJmAnak.Location = new System.Drawing.Point(416, 435);
            this.nmJmAnak.Name = "nmJmAnak";
            this.nmJmAnak.Size = new System.Drawing.Size(358, 31);
            this.nmJmAnak.TabIndex = 5;
            // 
            // txGjPokok
            // 
            this.txGjPokok.Location = new System.Drawing.Point(416, 490);
            this.txGjPokok.Name = "txGjPokok";
            this.txGjPokok.Size = new System.Drawing.Size(358, 31);
            this.txGjPokok.TabIndex = 6;
            // 
            // txTnjIstri
            // 
            this.txTnjIstri.Location = new System.Drawing.Point(416, 548);
            this.txTnjIstri.Name = "txTnjIstri";
            this.txTnjIstri.Size = new System.Drawing.Size(358, 31);
            this.txTnjIstri.TabIndex = 7;
            // 
            // txTnjAnak
            // 
            this.txTnjAnak.Location = new System.Drawing.Point(416, 612);
            this.txTnjAnak.Name = "txTnjAnak";
            this.txTnjAnak.Size = new System.Drawing.Size(358, 31);
            this.txTnjAnak.TabIndex = 8;
            // 
            // txTotalGaji
            // 
            this.txTotalGaji.Location = new System.Drawing.Point(416, 671);
            this.txTotalGaji.Name = "txTotalGaji";
            this.txTotalGaji.Size = new System.Drawing.Size(358, 31);
            this.txTotalGaji.TabIndex = 9;
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(416, 735);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(147, 34);
            this.hitung.TabIndex = 10;
            this.hitung.Text = "Hitung";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.hitung_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(629, 735);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(145, 34);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Departemen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Golongan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Jenis kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Jumlah anak";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gaji Pokok";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tunjangan Istri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 615);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tunjangan Anak";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 677);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total gaji";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 844);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.txTotalGaji);
            this.Controls.Add(this.txTnjAnak);
            this.Controls.Add(this.txTnjIstri);
            this.Controls.Add(this.txGjPokok);
            this.Controls.Add(this.nmJmAnak);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbGolongan);
            this.Controls.Add(this.cbDepartemen);
            this.Controls.Add(this.txNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmJmAnak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNama;
        private System.Windows.Forms.ComboBox cbDepartemen;
        private System.Windows.Forms.ComboBox cbGolongan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWanita;
        private System.Windows.Forms.RadioButton rbpria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbBelumMenikah;
        private System.Windows.Forms.RadioButton rbMenikah;
        private System.Windows.Forms.NumericUpDown nmJmAnak;
        private System.Windows.Forms.TextBox txGjPokok;
        private System.Windows.Forms.TextBox txTnjIstri;
        private System.Windows.Forms.TextBox txTnjAnak;
        private System.Windows.Forms.TextBox txTotalGaji;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

