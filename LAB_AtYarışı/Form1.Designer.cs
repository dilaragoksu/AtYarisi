namespace LAB_AtYarışı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pctrAt3 = new System.Windows.Forms.PictureBox();
            this.pctrAt2 = new System.Windows.Forms.PictureBox();
            this.pctrAt1 = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.lblGosterge = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAt1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(715, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pctrAt3
            // 
            this.pctrAt3.BackColor = System.Drawing.Color.Transparent;
            this.pctrAt3.ErrorImage = null;
            this.pctrAt3.Image = global::LAB_AtYarışı.Properties.Resources.ata_binme_hareketli_resim_0039;
            this.pctrAt3.Location = new System.Drawing.Point(75, 455);
            this.pctrAt3.Name = "pctrAt3";
            this.pctrAt3.Size = new System.Drawing.Size(121, 98);
            this.pctrAt3.TabIndex = 1;
            this.pctrAt3.TabStop = false;
            // 
            // pctrAt2
            // 
            this.pctrAt2.BackColor = System.Drawing.Color.Transparent;
            this.pctrAt2.ErrorImage = null;
            this.pctrAt2.Image = global::LAB_AtYarışı.Properties.Resources.ata_binme_hareketli_resim_0015;
            this.pctrAt2.Location = new System.Drawing.Point(75, 332);
            this.pctrAt2.Name = "pctrAt2";
            this.pctrAt2.Size = new System.Drawing.Size(121, 98);
            this.pctrAt2.TabIndex = 1;
            this.pctrAt2.TabStop = false;
            // 
            // pctrAt1
            // 
            this.pctrAt1.BackColor = System.Drawing.Color.Transparent;
            this.pctrAt1.ErrorImage = null;
            this.pctrAt1.Image = global::LAB_AtYarışı.Properties.Resources.ata_binme_hareketli_resim_0008;
            this.pctrAt1.Location = new System.Drawing.Point(75, 209);
            this.pctrAt1.Name = "pctrAt1";
            this.pctrAt1.Size = new System.Drawing.Size(121, 98);
            this.pctrAt1.TabIndex = 1;
            this.pctrAt1.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Gold;
            this.btnBasla.ForeColor = System.Drawing.Color.Maroon;
            this.btnBasla.Location = new System.Drawing.Point(260, 52);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.Gold;
            this.btnSifirla.ForeColor = System.Drawing.Color.Maroon;
            this.btnSifirla.Location = new System.Drawing.Point(363, 52);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 23);
            this.btnSifirla.TabIndex = 2;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // lblGosterge
            // 
            this.lblGosterge.AutoSize = true;
            this.lblGosterge.BackColor = System.Drawing.Color.Transparent;
            this.lblGosterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGosterge.Location = new System.Drawing.Point(257, 21);
            this.lblGosterge.Name = "lblGosterge";
            this.lblGosterge.Size = new System.Drawing.Size(0, 17);
            this.lblGosterge.TabIndex = 3;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.BackColor = System.Drawing.Color.Transparent;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(808, 565);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 17);
            this.lblSure.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(898, 587);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblGosterge);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pctrAt3);
            this.Controls.Add(this.pctrAt2);
            this.Controls.Add(this.pctrAt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrAt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pctrAt1;
        private System.Windows.Forms.PictureBox pctrAt2;
        private System.Windows.Forms.PictureBox pctrAt3;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Label lblGosterge;
        private System.Windows.Forms.Label lblSure;
    }
}

