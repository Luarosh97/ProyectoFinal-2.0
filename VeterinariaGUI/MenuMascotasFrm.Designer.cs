namespace VeterinariaGUI
{
    partial class MenuMascotasFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMascotasFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AgregarMascotaBtn = new System.Windows.Forms.Button();
            this.BuscarMascotaBtn = new System.Windows.Forms.Button();
            this.Mascotacmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MascotaDtg = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalPerrostxt = new System.Windows.Forms.TextBox();
            this.TotalGatostxt = new System.Windows.Forms.TextBox();
            this.TotalLorostxt = new System.Windows.Forms.TextBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.CANCELARBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MascotaDtg)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 35);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu Mascotas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.AgregarMascotaBtn);
            this.panel2.Controls.Add(this.BuscarMascotaBtn);
            this.panel2.Controls.Add(this.Mascotacmb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 182);
            this.panel2.TabIndex = 3;
            // 
            // AgregarMascotaBtn
            // 
            this.AgregarMascotaBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.AgregarMascotaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarMascotaBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarMascotaBtn.Image = ((System.Drawing.Image)(resources.GetObject("AgregarMascotaBtn.Image")));
            this.AgregarMascotaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarMascotaBtn.Location = new System.Drawing.Point(30, 87);
            this.AgregarMascotaBtn.Name = "AgregarMascotaBtn";
            this.AgregarMascotaBtn.Size = new System.Drawing.Size(75, 70);
            this.AgregarMascotaBtn.TabIndex = 16;
            this.AgregarMascotaBtn.Text = "Agregar Mascota";
            this.AgregarMascotaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarMascotaBtn.UseVisualStyleBackColor = false;
            this.AgregarMascotaBtn.Click += new System.EventHandler(this.AgregarMascotaBtn_Click);
            // 
            // BuscarMascotaBtn
            // 
            this.BuscarMascotaBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BuscarMascotaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarMascotaBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarMascotaBtn.Image")));
            this.BuscarMascotaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarMascotaBtn.Location = new System.Drawing.Point(613, 87);
            this.BuscarMascotaBtn.Name = "BuscarMascotaBtn";
            this.BuscarMascotaBtn.Size = new System.Drawing.Size(75, 57);
            this.BuscarMascotaBtn.TabIndex = 2;
            this.BuscarMascotaBtn.Text = "Consultar";
            this.BuscarMascotaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarMascotaBtn.UseVisualStyleBackColor = false;
            this.BuscarMascotaBtn.Click += new System.EventHandler(this.BuscarMascotaBtn_Click);
            // 
            // Mascotacmb
            // 
            this.Mascotacmb.FormattingEnabled = true;
            this.Mascotacmb.Items.AddRange(new object[] {
            "Mascotas",
            "Perros",
            "Loros",
            "Gatos"});
            this.Mascotacmb.Location = new System.Drawing.Point(415, 123);
            this.Mascotacmb.Name = "Mascotacmb";
            this.Mascotacmb.Size = new System.Drawing.Size(121, 21);
            this.Mascotacmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mascotas Activos";
            // 
            // MascotaDtg
            // 
            this.MascotaDtg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MascotaDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MascotaDtg.Location = new System.Drawing.Point(0, 200);
            this.MascotaDtg.Name = "MascotaDtg";
            this.MascotaDtg.Size = new System.Drawing.Size(857, 265);
            this.MascotaDtg.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.CANCELARBTN);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TotalPerrostxt);
            this.panel3.Controls.Add(this.TotalGatostxt);
            this.panel3.Controls.Add(this.TotalLorostxt);
            this.panel3.Controls.Add(this.totaltxt);
            this.panel3.Location = new System.Drawing.Point(0, 462);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 132);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Perros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Gatos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Loros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total ";
            // 
            // TotalPerrostxt
            // 
            this.TotalPerrostxt.Location = new System.Drawing.Point(543, 43);
            this.TotalPerrostxt.Name = "TotalPerrostxt";
            this.TotalPerrostxt.Size = new System.Drawing.Size(100, 20);
            this.TotalPerrostxt.TabIndex = 11;
            // 
            // TotalGatostxt
            // 
            this.TotalGatostxt.Location = new System.Drawing.Point(379, 43);
            this.TotalGatostxt.Name = "TotalGatostxt";
            this.TotalGatostxt.Size = new System.Drawing.Size(100, 20);
            this.TotalGatostxt.TabIndex = 10;
            // 
            // TotalLorostxt
            // 
            this.TotalLorostxt.Location = new System.Drawing.Point(230, 43);
            this.TotalLorostxt.Name = "TotalLorostxt";
            this.TotalLorostxt.Size = new System.Drawing.Size(100, 20);
            this.TotalLorostxt.TabIndex = 9;
            // 
            // totaltxt
            // 
            this.totaltxt.Location = new System.Drawing.Point(67, 43);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(100, 20);
            this.totaltxt.TabIndex = 8;
            // 
            // CANCELARBTN
            // 
            this.CANCELARBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.CANCELARBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CANCELARBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CANCELARBTN.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCELARBTN.Image = ((System.Drawing.Image)(resources.GetObject("CANCELARBTN.Image")));
            this.CANCELARBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CANCELARBTN.Location = new System.Drawing.Point(700, 27);
            this.CANCELARBTN.Name = "CANCELARBTN";
            this.CANCELARBTN.Size = new System.Drawing.Size(71, 54);
            this.CANCELARBTN.TabIndex = 22;
            this.CANCELARBTN.Text = "Cancelar";
            this.CANCELARBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CANCELARBTN.UseVisualStyleBackColor = false;
            this.CANCELARBTN.Click += new System.EventHandler(this.CANCELARBTN_Click);
            // 
            // MenuMascotasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(857, 593);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.MascotaDtg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuMascotasFrm";
            this.Text = "MenuMascotasFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MascotaDtg)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BuscarMascotaBtn;
        private System.Windows.Forms.ComboBox Mascotacmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MascotaDtg;
        private System.Windows.Forms.Button AgregarMascotaBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalPerrostxt;
        private System.Windows.Forms.TextBox TotalGatostxt;
        private System.Windows.Forms.TextBox TotalLorostxt;
        private System.Windows.Forms.TextBox totaltxt;
        private System.Windows.Forms.Button CANCELARBTN;
    }
}