namespace PersonelOtomasyonu.PL
{
    partial class KullaniciGirisi
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
            this.kaditxt = new System.Windows.Forms.TextBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.grsyapbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kaditxt
            // 
            this.kaditxt.BackColor = System.Drawing.Color.Turquoise;
            this.kaditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaditxt.Location = new System.Drawing.Point(93, 67);
            this.kaditxt.Name = "kaditxt";
            this.kaditxt.Size = new System.Drawing.Size(324, 40);
            this.kaditxt.TabIndex = 0;
            // 
            // sifretxt
            // 
            this.sifretxt.BackColor = System.Drawing.Color.Turquoise;
            this.sifretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretxt.Location = new System.Drawing.Point(93, 194);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(324, 40);
            this.sifretxt.TabIndex = 1;
            this.sifretxt.UseSystemPasswordChar = true;
            // 
            // grsyapbtn
            // 
            this.grsyapbtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grsyapbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grsyapbtn.Location = new System.Drawing.Point(172, 286);
            this.grsyapbtn.Name = "grsyapbtn";
            this.grsyapbtn.Size = new System.Drawing.Size(168, 78);
            this.grsyapbtn.TabIndex = 2;
            this.grsyapbtn.Text = "GİRİŞ YAP";
            this.grsyapbtn.UseVisualStyleBackColor = false;
            this.grsyapbtn.Click += new System.EventHandler(this.grsyapbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(203, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // KullaniciGirisi
            // 
            this.AcceptButton = this.grsyapbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(508, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grsyapbtn);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kaditxt);
            this.Name = "KullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kaditxt;
        private System.Windows.Forms.TextBox sifretxt;
        private System.Windows.Forms.Button grsyapbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}