namespace Aplikasi_Kantin
{
    partial class Transaksi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIdTrans = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.DTPtanggal = new System.Windows.Forms.DateTimePicker();
            this.txtPetugas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHargaBeli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdMenu = new System.Windows.Forms.TextBox();
            this.txtIdCus = new System.Windows.Forms.TextBox();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtjml = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 48);
            this.panel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(400, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Transaksi";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Controls.Add(this.btnMaximize);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(815, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 48);
            this.panel4.TabIndex = 0;
            // 
            // txtIdTrans
            // 
            this.txtIdTrans.Location = new System.Drawing.Point(518, 103);
            this.txtIdTrans.Name = "txtIdTrans";
            this.txtIdTrans.Size = new System.Drawing.Size(166, 20);
            this.txtIdTrans.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(386, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "No Transaksi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(386, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tanggal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(386, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Id Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(386, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "Petugas";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(51, 274);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(118, 27);
            this.btnSimpan.TabIndex = 46;
            this.btnSimpan.Text = "OK";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // DTPtanggal
            // 
            this.DTPtanggal.Location = new System.Drawing.Point(518, 144);
            this.DTPtanggal.Name = "DTPtanggal";
            this.DTPtanggal.Size = new System.Drawing.Size(166, 20);
            this.DTPtanggal.TabIndex = 50;
            // 
            // txtPetugas
            // 
            this.txtPetugas.Location = new System.Drawing.Point(518, 225);
            this.txtPetugas.Name = "txtPetugas";
            this.txtPetugas.Size = new System.Drawing.Size(166, 20);
            this.txtPetugas.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(48, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Nama Menu";
            // 
            // txtHargaBeli
            // 
            this.txtHargaBeli.Location = new System.Drawing.Point(180, 148);
            this.txtHargaBeli.Name = "txtHargaBeli";
            this.txtHargaBeli.Size = new System.Drawing.Size(166, 20);
            this.txtHargaBeli.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(48, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Harga Beli";
            // 
            // txtIdMenu
            // 
            this.txtIdMenu.Location = new System.Drawing.Point(292, 113);
            this.txtIdMenu.Name = "txtIdMenu";
            this.txtIdMenu.Size = new System.Drawing.Size(54, 20);
            this.txtIdMenu.TabIndex = 57;
            // 
            // txtIdCus
            // 
            this.txtIdCus.Location = new System.Drawing.Point(518, 184);
            this.txtIdCus.Name = "txtIdCus";
            this.txtIdCus.Size = new System.Drawing.Size(166, 20);
            this.txtIdCus.TabIndex = 58;
            // 
            // cbMenu
            // 
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(180, 113);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(106, 21);
            this.cbMenu.TabIndex = 59;
            this.cbMenu.SelectedIndexChanged += new System.EventHandler(this.cbMenu_SelectedIndexChanged);
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Location = new System.Drawing.Point(180, 184);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(166, 20);
            this.txtHargaJual.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(48, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 60;
            this.label9.Text = "Harga Jual";
            // 
            // txtjml
            // 
            this.txtjml.Location = new System.Drawing.Point(180, 219);
            this.txtjml.Name = "txtjml";
            this.txtjml.Size = new System.Drawing.Size(166, 20);
            this.txtjml.TabIndex = 63;
            this.txtjml.TextChanged += new System.EventHandler(this.txtjml_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(48, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 15);
            this.label10.TabIndex = 62;
            this.label10.Text = "Jumlah";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(518, 321);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(137, 33);
            this.txtTotal.TabIndex = 65;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(402, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "Total Harga";
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Aplikasi_Kantin.Properties.Resources.minimize15px;
            this.btnMinimize.Location = new System.Drawing.Point(12, 15);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Aplikasi_Kantin.Properties.Resources.maximize15px;
            this.btnMaximize.Location = new System.Drawing.Point(50, 15);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(18, 18);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Aplikasi_Kantin.Properties.Resources.close15px;
            this.btnClose.Location = new System.Drawing.Point(89, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(48)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtjml);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHargaJual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMenu);
            this.Controls.Add(this.txtIdCus);
            this.Controls.Add(this.txtIdMenu);
            this.Controls.Add(this.txtHargaBeli);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPetugas);
            this.Controls.Add(this.DTPtanggal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdTrans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtIdTrans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DateTimePicker DTPtanggal;
        private System.Windows.Forms.TextBox txtPetugas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHargaBeli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdMenu;
        private System.Windows.Forms.TextBox txtIdCus;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtjml;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
    }
}