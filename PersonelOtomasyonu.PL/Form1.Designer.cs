namespace PersonelOtomasyonu.PL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guncbtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.eklebtn = new System.Windows.Forms.Button();
            this.resimsecbutton = new System.Windows.Forms.Button();
            this.fotopicturebox = new System.Windows.Forms.PictureBox();
            this.dogumtarihipicker = new System.Windows.Forms.DateTimePicker();
            this.ısegirispicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.unvantxt = new System.Windows.Forms.TextBox();
            this.adrestxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailtxt = new System.Windows.Forms.TextBox();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.tcnotxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotopicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncbtn);
            this.groupBox1.Controls.Add(this.silbtn);
            this.groupBox1.Controls.Add(this.eklebtn);
            this.groupBox1.Controls.Add(this.resimsecbutton);
            this.groupBox1.Controls.Add(this.fotopicturebox);
            this.groupBox1.Controls.Add(this.dogumtarihipicker);
            this.groupBox1.Controls.Add(this.ısegirispicker);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.unvantxt);
            this.groupBox1.Controls.Add(this.adrestxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mailtxt);
            this.groupBox1.Controls.Add(this.teltxt);
            this.groupBox1.Controls.Add(this.soyadtxt);
            this.groupBox1.Controls.Add(this.adtxt);
            this.groupBox1.Controls.Add(this.tcnotxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1329, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PersonelBilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // guncbtn
            // 
            this.guncbtn.BackColor = System.Drawing.Color.Gray;
            this.guncbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guncbtn.Location = new System.Drawing.Point(1171, 238);
            this.guncbtn.Name = "guncbtn";
            this.guncbtn.Size = new System.Drawing.Size(132, 79);
            this.guncbtn.TabIndex = 12;
            this.guncbtn.Text = "Personel GÜNCELLE";
            this.guncbtn.UseVisualStyleBackColor = false;
            this.guncbtn.Click += new System.EventHandler(this.guncbtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.BackColor = System.Drawing.Color.Gray;
            this.silbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.silbtn.Location = new System.Drawing.Point(1171, 141);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(132, 79);
            this.silbtn.TabIndex = 11;
            this.silbtn.Text = "Personel SİL";
            this.silbtn.UseVisualStyleBackColor = false;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // eklebtn
            // 
            this.eklebtn.BackColor = System.Drawing.Color.Gray;
            this.eklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eklebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eklebtn.Location = new System.Drawing.Point(1171, 41);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(132, 79);
            this.eklebtn.TabIndex = 10;
            this.eklebtn.Text = "Personel EKLE";
            this.eklebtn.UseVisualStyleBackColor = false;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // resimsecbutton
            // 
            this.resimsecbutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.resimsecbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimsecbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resimsecbutton.Location = new System.Drawing.Point(933, 271);
            this.resimsecbutton.Name = "resimsecbutton";
            this.resimsecbutton.Size = new System.Drawing.Size(118, 56);
            this.resimsecbutton.TabIndex = 9;
            this.resimsecbutton.Text = "Resim Seç";
            this.resimsecbutton.UseVisualStyleBackColor = false;
            this.resimsecbutton.Click += new System.EventHandler(this.resimsecbutton_Click);
            // 
            // fotopicturebox
            // 
            this.fotopicturebox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fotopicturebox.Location = new System.Drawing.Point(885, 19);
            this.fotopicturebox.Name = "fotopicturebox";
            this.fotopicturebox.Size = new System.Drawing.Size(206, 234);
            this.fotopicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotopicturebox.TabIndex = 6;
            this.fotopicturebox.TabStop = false;
            // 
            // dogumtarihipicker
            // 
            this.dogumtarihipicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogumtarihipicker.Location = new System.Drawing.Point(126, 213);
            this.dogumtarihipicker.Name = "dogumtarihipicker";
            this.dogumtarihipicker.Size = new System.Drawing.Size(263, 26);
            this.dogumtarihipicker.TabIndex = 3;
            // 
            // ısegirispicker
            // 
            this.ısegirispicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ısegirispicker.Location = new System.Drawing.Point(549, 281);
            this.ısegirispicker.Name = "ısegirispicker";
            this.ısegirispicker.Size = new System.Drawing.Size(269, 26);
            this.ısegirispicker.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(443, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ünvan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(407, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "İşe Giriş Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(448, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Adres:";
            // 
            // unvantxt
            // 
            this.unvantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unvantxt.Location = new System.Drawing.Point(549, 50);
            this.unvantxt.Name = "unvantxt";
            this.unvantxt.Size = new System.Drawing.Size(261, 26);
            this.unvantxt.TabIndex = 6;
            // 
            // adrestxt
            // 
            this.adrestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adrestxt.Location = new System.Drawing.Point(549, 129);
            this.adrestxt.Multiline = true;
            this.adrestxt.Name = "adrestxt";
            this.adrestxt.Size = new System.Drawing.Size(261, 102);
            this.adrestxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dogum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC Kimlik No:";
            // 
            // mailtxt
            // 
            this.mailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailtxt.Location = new System.Drawing.Point(126, 333);
            this.mailtxt.Name = "mailtxt";
            this.mailtxt.Size = new System.Drawing.Size(263, 26);
            this.mailtxt.TabIndex = 5;
            // 
            // teltxt
            // 
            this.teltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teltxt.Location = new System.Drawing.Point(126, 271);
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(263, 26);
            this.teltxt.TabIndex = 4;
            // 
            // soyadtxt
            // 
            this.soyadtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadtxt.Location = new System.Drawing.Point(126, 139);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(263, 26);
            this.soyadtxt.TabIndex = 2;
            // 
            // adtxt
            // 
            this.adtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adtxt.Location = new System.Drawing.Point(126, 74);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(263, 26);
            this.adtxt.TabIndex = 1;
            // 
            // tcnotxt
            // 
            this.tcnotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcnotxt.Location = new System.Drawing.Point(126, 24);
            this.tcnotxt.Name = "tcnotxt";
            this.tcnotxt.Size = new System.Drawing.Size(263, 26);
            this.tcnotxt.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 435);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 60;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1168, 220);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(441, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Personel Ara";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(559, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 661);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Kayıt Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotopicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button guncbtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.Button resimsecbutton;
        private System.Windows.Forms.PictureBox fotopicturebox;
        private System.Windows.Forms.DateTimePicker dogumtarihipicker;
        private System.Windows.Forms.DateTimePicker ısegirispicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox unvantxt;
        private System.Windows.Forms.TextBox adrestxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailtxt;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.TextBox tcnotxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
    }
}

