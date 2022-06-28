namespace MappingExample
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_OgretmenEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 31);
            this.textBox1.TabIndex = 0;
            // 
            // btn_OgretmenEkle
            // 
            this.btn_OgretmenEkle.Location = new System.Drawing.Point(230, 179);
            this.btn_OgretmenEkle.Name = "btn_OgretmenEkle";
            this.btn_OgretmenEkle.Size = new System.Drawing.Size(123, 44);
            this.btn_OgretmenEkle.TabIndex = 1;
            this.btn_OgretmenEkle.Text = "Kaydet";
            this.btn_OgretmenEkle.UseVisualStyleBackColor = true;
            this.btn_OgretmenEkle.Click += new System.EventHandler(this.btn_OgretmenEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğretmen Adı";
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(424, 288);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(155, 54);
            this.btn_kapat.TabIndex = 3;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 354);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OgretmenEkle);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Öğrentmen Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btn_OgretmenEkle;
        private Label label1;
        private Button btn_kapat;
    }
}