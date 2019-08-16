namespace SatrancOyunu
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
            this.components = new System.ComponentModel.Container();
            this.cmbTasTipleri = new System.Windows.Forms.ComboBox();
            this.btnTasEkle = new System.Windows.Forms.Button();
            this.btnTaslariOynat = new System.Windows.Forms.Button();
            this.flowTahta = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmbTasTipleri
            // 
            this.cmbTasTipleri.FormattingEnabled = true;
            this.cmbTasTipleri.Location = new System.Drawing.Point(582, 26);
            this.cmbTasTipleri.Name = "cmbTasTipleri";
            this.cmbTasTipleri.Size = new System.Drawing.Size(229, 24);
            this.cmbTasTipleri.TabIndex = 1;
            // 
            // btnTasEkle
            // 
            this.btnTasEkle.Location = new System.Drawing.Point(630, 88);
            this.btnTasEkle.Name = "btnTasEkle";
            this.btnTasEkle.Size = new System.Drawing.Size(144, 33);
            this.btnTasEkle.TabIndex = 2;
            this.btnTasEkle.Text = "Taş Ekle";
            this.btnTasEkle.UseVisualStyleBackColor = true;
            this.btnTasEkle.Click += new System.EventHandler(this.btnTasEkle_Click);
            // 
            // btnTaslariOynat
            // 
            this.btnTaslariOynat.Location = new System.Drawing.Point(630, 148);
            this.btnTaslariOynat.Name = "btnTaslariOynat";
            this.btnTaslariOynat.Size = new System.Drawing.Size(144, 45);
            this.btnTaslariOynat.TabIndex = 3;
            this.btnTaslariOynat.Text = "Taşları Hareket Ettir";
            this.btnTaslariOynat.UseVisualStyleBackColor = true;
            this.btnTaslariOynat.Click += new System.EventHandler(this.btnTaslariOynat_Click);
            // 
            // flowTahta
            // 
            this.flowTahta.Location = new System.Drawing.Point(12, 12);
            this.flowTahta.Name = "flowTahta";
            this.flowTahta.Size = new System.Drawing.Size(200, 100);
            this.flowTahta.TabIndex = 4;
            this.flowTahta.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 535);
            this.Controls.Add(this.flowTahta);
            this.Controls.Add(this.btnTaslariOynat);
            this.Controls.Add(this.btnTasEkle);
            this.Controls.Add(this.cmbTasTipleri);
            this.Name = "Form1";
            this.Text = "Satranç";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTasTipleri;
        private System.Windows.Forms.Button btnTasEkle;
        private System.Windows.Forms.Button btnTaslariOynat;
        private System.Windows.Forms.GroupBox flowTahta;
        private System.Windows.Forms.Timer timer1;
    }
}

