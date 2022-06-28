namespace MappingExample
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
            this.btn_Esle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_ogrenciEkle = new System.Windows.Forms.Button();
            this.btn_ogretmenEkle = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Esle
            // 
            this.btn_Esle.Location = new System.Drawing.Point(161, 131);
            this.btn_Esle.Name = "btn_Esle";
            this.btn_Esle.Size = new System.Drawing.Size(137, 86);
            this.btn_Esle.TabIndex = 4;
            this.btn_Esle.Text = "Eşle";
            this.btn_Esle.UseVisualStyleBackColor = true;
            this.btn_Esle.Click += new System.EventHandler(this.btn_Esle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(516, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 404);
            this.listBox1.TabIndex = 5;
            // 
            // btn_ogrenciEkle
            // 
            this.btn_ogrenciEkle.Location = new System.Drawing.Point(13, 246);
            this.btn_ogrenciEkle.Name = "btn_ogrenciEkle";
            this.btn_ogrenciEkle.Size = new System.Drawing.Size(148, 52);
            this.btn_ogrenciEkle.TabIndex = 6;
            this.btn_ogrenciEkle.Text = "Öğrenci Ekle";
            this.btn_ogrenciEkle.UseVisualStyleBackColor = true;
            this.btn_ogrenciEkle.Click += new System.EventHandler(this.btn_ogrenciEkle_Click);
            // 
            // btn_ogretmenEkle
            // 
            this.btn_ogretmenEkle.Location = new System.Drawing.Point(298, 246);
            this.btn_ogretmenEkle.Name = "btn_ogretmenEkle";
            this.btn_ogretmenEkle.Size = new System.Drawing.Size(148, 52);
            this.btn_ogretmenEkle.TabIndex = 6;
            this.btn_ogretmenEkle.Text = "Öğretmen Ekle";
            this.btn_ogretmenEkle.UseVisualStyleBackColor = true;
            this.btn_ogretmenEkle.Click += new System.EventHandler(this.btn_ogretmenEkle_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(893, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(371, 404);
            this.listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(1270, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(371, 404);
            this.listBox3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 434);
            this.Controls.Add(this.btn_ogretmenEkle);
            this.Controls.Add(this.btn_ogrenciEkle);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Esle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_Esle;
        private ListBox listBox1;
        private Button btn_ogrenciEkle;
        private Button btn_ogretmenEkle;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}