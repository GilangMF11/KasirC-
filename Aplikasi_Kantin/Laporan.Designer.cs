namespace Aplikasi_Kantin
{
    partial class Laporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laporan));
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCariTanggal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPtanggal = new System.Windows.Forms.DateTimePicker();
            this.dgvOmzet = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBeli = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvJual = new System.Windows.Forms.DataGridView();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmzet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJual)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Name = "label7";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel4);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Controls.Add(this.btnMaximize);
            this.panel4.Controls.Add(this.btnClose);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvReport, "dgvReport");
            this.dgvReport.Name = "dgvReport";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCari
            // 
            resources.ApplyResources(this.btnCari, "btnCari");
            this.btnCari.Name = "btnCari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            resources.ApplyResources(this.txtCari, "txtCari");
            this.txtCari.Name = "txtCari";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Name = "label5";
            // 
            // btnCariTanggal
            // 
            resources.ApplyResources(this.btnCariTanggal, "btnCariTanggal");
            this.btnCariTanggal.Name = "btnCariTanggal";
            this.btnCariTanggal.UseVisualStyleBackColor = true;
            this.btnCariTanggal.Click += new System.EventHandler(this.btnCariTanggal_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // DTPtanggal
            // 
            resources.ApplyResources(this.DTPtanggal, "DTPtanggal");
            this.DTPtanggal.Name = "DTPtanggal";
            this.DTPtanggal.ValueChanged += new System.EventHandler(this.DTPtanggal_ValueChanged);
            // 
            // dgvOmzet
            // 
            this.dgvOmzet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvOmzet, "dgvOmzet");
            this.dgvOmzet.Name = "dgvOmzet";
            this.dgvOmzet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOmzet_CellContentClick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // dgvBeli
            // 
            this.dgvBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvBeli, "dgvBeli");
            this.dgvBeli.Name = "dgvBeli";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // dgvJual
            // 
            this.dgvJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvJual, "dgvJual");
            this.dgvJual.Name = "dgvJual";
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMinimize, "btnMinimize");
            this.btnMinimize.Image = global::Aplikasi_Kantin.Properties.Resources.minimize15px;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMaximize, "btnMaximize");
            this.btnMaximize.Image = global::Aplikasi_Kantin.Properties.Resources.maximize15px;
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Image = global::Aplikasi_Kantin.Properties.Resources.close15px;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Laporan
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(48)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvJual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBeli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvOmzet);
            this.Controls.Add(this.DTPtanggal);
            this.Controls.Add(this.btnCariTanggal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Laporan";
            this.Load += new System.EventHandler(this.Laporan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOmzet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCariTanggal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPtanggal;
        private System.Windows.Forms.DataGridView dgvOmzet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvJual;
    }
}