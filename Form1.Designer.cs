namespace kalkulator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.operator1 = new System.Windows.Forms.ComboBox();
            this.angka1 = new System.Windows.Forms.TextBox();
            this.angka2 = new System.Windows.Forms.TextBox();
            this.hasilteks = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // operator1
            // 
            this.operator1.FormattingEnabled = true;
            this.operator1.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.operator1.Location = new System.Drawing.Point(82, 20);
            this.operator1.Name = "operator1";
            this.operator1.Size = new System.Drawing.Size(191, 28);
            this.operator1.TabIndex = 4;
            // 
            // angka1
            // 
            this.angka1.Location = new System.Drawing.Point(82, 72);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(191, 26);
            this.angka1.TabIndex = 5;
            // 
            // angka2
            // 
            this.angka2.Location = new System.Drawing.Point(82, 129);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(191, 26);
            this.angka2.TabIndex = 6;
            // 
            // hasilteks
            // 
            this.hasilteks.Location = new System.Drawing.Point(82, 177);
            this.hasilteks.Name = "hasilteks";
            this.hasilteks.Size = new System.Drawing.Size(191, 26);
            this.hasilteks.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hasilteks);
            this.Controls.Add(this.angka2);
            this.Controls.Add(this.angka1);
            this.Controls.Add(this.operator1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox operator1;
        private System.Windows.Forms.TextBox angka1;
        private System.Windows.Forms.TextBox angka2;
        private System.Windows.Forms.TextBox hasilteks;
        private System.Windows.Forms.Button button1;
    }
}

