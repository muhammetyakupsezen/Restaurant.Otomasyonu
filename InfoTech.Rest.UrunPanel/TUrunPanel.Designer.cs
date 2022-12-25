namespace InfoTech.Rest.UrunPanel
{
    partial class TUrunPanel
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblUrunFiyati = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUrunAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblUrunFiyati);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 52);
            this.panel2.TabIndex = 3;
            // 
            // LblUrunFiyati
            // 
            this.LblUrunFiyati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUrunFiyati.Location = new System.Drawing.Point(0, 0);
            this.LblUrunFiyati.Name = "LblUrunFiyati";
            this.LblUrunFiyati.Size = new System.Drawing.Size(67, 52);
            this.LblUrunFiyati.TabIndex = 0;
            this.LblUrunFiyati.Text = "Ürün Fiyatı";
            this.LblUrunFiyati.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblUrunFiyati.Click += new System.EventHandler(this.LblUrunFiyati_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblUrunAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(58, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 52);
            this.panel1.TabIndex = 4;
            // 
            // LblUrunAdi
            // 
            this.LblUrunAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUrunAdi.Location = new System.Drawing.Point(0, 0);
            this.LblUrunAdi.Name = "LblUrunAdi";
            this.LblUrunAdi.Size = new System.Drawing.Size(228, 52);
            this.LblUrunAdi.TabIndex = 0;
            this.LblUrunAdi.Text = "Ürün Adı";
            this.LblUrunAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblUrunAdi.Click += new System.EventHandler(this.LblUrunAdi_Click);
            // 
            // TUrunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TUrunPanel";
            this.Size = new System.Drawing.Size(353, 52);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblUrunFiyati;
        private System.Windows.Forms.Label LblUrunAdi;
    }
}
