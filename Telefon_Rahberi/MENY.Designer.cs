namespace Telefon_Rahberi
{
    partial class MENY
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnk_g = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Location = new System.Drawing.Point(304, 89);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(110, 89);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "LISTELE";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.MouseLeave += new System.EventHandler(this.btnList_MouseLeave);
            this.btnList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnList_MouseMove);
            // 
            // btnk_g
            // 
            this.btnk_g.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnk_g.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnk_g.Location = new System.Drawing.Point(165, 91);
            this.btnk_g.Name = "btnk_g";
            this.btnk_g.Size = new System.Drawing.Size(110, 89);
            this.btnk_g.TabIndex = 6;
            this.btnk_g.Text = "Kayıt Ekle / Güncelle";
            this.btnk_g.UseVisualStyleBackColor = true;
            this.btnk_g.Click += new System.EventHandler(this.btnk_g_Click);
            this.btnk_g.MouseLeave += new System.EventHandler(this.btnk_g_MouseLeave);
            this.btnk_g.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button7_MouseMove);
            // 
            // MENY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(676, 439);
            this.Controls.Add(this.btnk_g);
            this.Controls.Add(this.btnList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MENY";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnk_g;
    }
}