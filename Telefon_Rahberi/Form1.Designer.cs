namespace Telefon_Rahberi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lnkSifre = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblK_Adi = new System.Windows.Forms.Label();
            this.txtsifresi = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtk_ksifre1 = new System.Windows.Forms.Label();
            this.txtK_ksifre = new System.Windows.Forms.Label();
            this.lblkadi = new System.Windows.Forms.Label();
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.txtSifre1 = new System.Windows.Forms.TextBox();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkSifre
            // 
            this.lnkSifre.AutoSize = true;
            this.lnkSifre.Enabled = false;
            this.lnkSifre.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkSifre.ForeColor = System.Drawing.Color.Brown;
            this.lnkSifre.LinkArea = new System.Windows.Forms.LinkArea(24, 0);
            this.lnkSifre.LinkColor = System.Drawing.Color.White;
            this.lnkSifre.Location = new System.Drawing.Point(23, 108);
            this.lnkSifre.Name = "lnkSifre";
            this.lnkSifre.Size = new System.Drawing.Size(136, 18);
            this.lnkSifre.TabIndex = 5;
            this.lnkSifre.Text = "Şifrenizi unuttunuz mu ?";
            this.lnkSifre.UseCompatibleTextRendering = true;
            this.lnkSifre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSifre_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 27);
            this.panel1.TabIndex = 8;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(313, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtkullanici
            // 
            this.txtkullanici.Location = new System.Drawing.Point(144, 32);
            this.txtkullanici.MaxLength = 20;
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(100, 20);
            this.txtkullanici.TabIndex = 0;
            this.txtkullanici.TextChanged += new System.EventHandler(this.txtK_Adi_TextChanged);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.Color.Coral;
            this.lblSifre.Location = new System.Drawing.Point(20, 71);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(74, 13);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifrenizi Giriniz";
            // 
            // lblK_Adi
            // 
            this.lblK_Adi.AutoSize = true;
            this.lblK_Adi.ForeColor = System.Drawing.Color.Coral;
            this.lblK_Adi.Location = new System.Drawing.Point(20, 35);
            this.lblK_Adi.Name = "lblK_Adi";
            this.lblK_Adi.Size = new System.Drawing.Size(95, 13);
            this.lblK_Adi.TabIndex = 2;
            this.lblK_Adi.Text = "Kullanici Adi Giriniz";
            // 
            // txtsifresi
            // 
            this.txtsifresi.Location = new System.Drawing.Point(144, 71);
            this.txtsifresi.MaxLength = 20;
            this.txtsifresi.Name = "txtsifresi";
            this.txtsifresi.PasswordChar = '*';
            this.txtsifresi.Size = new System.Drawing.Size(100, 20);
            this.txtsifresi.TabIndex = 1;
            this.txtsifresi.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnGiris.Location = new System.Drawing.Point(23, 129);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(281, 28);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "GIRIŞ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(162, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "KAYIT";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(268, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(268, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kayit Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtk_ksifre1
            // 
            this.txtk_ksifre1.AutoSize = true;
            this.txtk_ksifre1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtk_ksifre1.ForeColor = System.Drawing.Color.White;
            this.txtk_ksifre1.Location = new System.Drawing.Point(18, 108);
            this.txtk_ksifre1.Name = "txtk_ksifre1";
            this.txtk_ksifre1.Size = new System.Drawing.Size(139, 16);
            this.txtk_ksifre1.TabIndex = 17;
            this.txtk_ksifre1.Text = "Şifrenizi Giriniz Tekrar";
            // 
            // txtK_ksifre
            // 
            this.txtK_ksifre.AutoSize = true;
            this.txtK_ksifre.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtK_ksifre.ForeColor = System.Drawing.Color.White;
            this.txtK_ksifre.Location = new System.Drawing.Point(18, 63);
            this.txtK_ksifre.Name = "txtK_ksifre";
            this.txtK_ksifre.Size = new System.Drawing.Size(88, 16);
            this.txtK_ksifre.TabIndex = 16;
            this.txtK_ksifre.Text = "Şifrenizi Girin";
            // 
            // lblkadi
            // 
            this.lblkadi.AutoSize = true;
            this.lblkadi.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkadi.ForeColor = System.Drawing.Color.White;
            this.lblkadi.Location = new System.Drawing.Point(18, 22);
            this.lblkadi.Name = "lblkadi";
            this.lblkadi.Size = new System.Drawing.Size(85, 16);
            this.lblkadi.TabIndex = 15;
            this.lblkadi.Text = "Kullanici Adi ";
            // 
            // txtSifre2
            // 
            this.txtSifre2.Location = new System.Drawing.Point(162, 105);
            this.txtSifre2.MaxLength = 15;
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.Size = new System.Drawing.Size(100, 20);
            this.txtSifre2.TabIndex = 13;
            // 
            // txtSifre1
            // 
            this.txtSifre1.Location = new System.Drawing.Point(162, 63);
            this.txtSifre1.MaxLength = 15;
            this.txtSifre1.Name = "txtSifre1";
            this.txtSifre1.PasswordChar = '*';
            this.txtSifre1.Size = new System.Drawing.Size(100, 20);
            this.txtSifre1.TabIndex = 12;
            // 
            // txtKadi
            // 
            this.txtKadi.Location = new System.Drawing.Point(162, 19);
            this.txtKadi.MaxLength = 20;
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(100, 20);
            this.txtKadi.TabIndex = 11;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.lblK_Adi);
            this.grb1.Controls.Add(this.txtkullanici);
            this.grb1.Controls.Add(this.txtsifresi);
            this.grb1.Controls.Add(this.lblSifre);
            this.grb1.Controls.Add(this.lnkSifre);
            this.grb1.Controls.Add(this.btnGiris);
            this.grb1.Controls.Add(this.pictureBox1);
            this.grb1.Location = new System.Drawing.Point(7, 88);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(325, 210);
            this.grb1.TabIndex = 20;
            this.grb1.TabStop = false;
            this.grb1.Enter += new System.EventHandler(this.grb1_Enter);
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.txtKadi);
            this.grb2.Controls.Add(this.txtSifre1);
            this.grb2.Controls.Add(this.pictureBox2);
            this.grb2.Controls.Add(this.txtSifre2);
            this.grb2.Controls.Add(this.pictureBox3);
            this.grb2.Controls.Add(this.lblkadi);
            this.grb2.Controls.Add(this.button1);
            this.grb2.Controls.Add(this.txtK_ksifre);
            this.grb2.Controls.Add(this.txtk_ksifre1);
            this.grb2.Location = new System.Drawing.Point(375, 88);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(324, 210);
            this.grb2.TabIndex = 21;
            this.grb2.TabStop = false;
            this.grb2.Enter += new System.EventHandler(this.grb2_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Location = new System.Drawing.Point(54, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 10);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(168, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 10);
            this.panel3.TabIndex = 23;
            this.panel3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblK_Adi;
        private System.Windows.Forms.TextBox txtsifresi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtk_ksifre1;
        private System.Windows.Forms.Label txtK_ksifre;
        private System.Windows.Forms.Label lblkadi;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.TextBox txtSifre1;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

