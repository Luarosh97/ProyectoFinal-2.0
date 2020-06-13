namespace VeterinariaGUI
{
    partial class MenuServiciosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuServiciosFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.VeterinarioCmb = new System.Windows.Forms.Panel();
            this.AgregarServicioBtn = new System.Windows.Forms.Button();
            this.BuscarServiciosBtn = new System.Windows.Forms.Button();
            this.Servicioscmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serviciosDtg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CANCELARBTN = new System.Windows.Forms.Button();
            this.TotalServiciostxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.VeterinarioCmb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDtg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 41);
            this.panel1.TabIndex = 3;
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
            // VeterinarioCmb
            // 
            this.VeterinarioCmb.BackColor = System.Drawing.Color.DarkOrange;
            this.VeterinarioCmb.Controls.Add(this.AgregarServicioBtn);
            this.VeterinarioCmb.Controls.Add(this.serviciosDtg);
            this.VeterinarioCmb.Controls.Add(this.BuscarServiciosBtn);
            this.VeterinarioCmb.Controls.Add(this.Servicioscmb);
            this.VeterinarioCmb.Controls.Add(this.label2);
            this.VeterinarioCmb.Location = new System.Drawing.Point(0, 38);
            this.VeterinarioCmb.Name = "VeterinarioCmb";
            this.VeterinarioCmb.Size = new System.Drawing.Size(959, 458);
            this.VeterinarioCmb.TabIndex = 5;
            // 
            // AgregarServicioBtn
            // 
            this.AgregarServicioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.AgregarServicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarServicioBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarServicioBtn.Image = ((System.Drawing.Image)(resources.GetObject("AgregarServicioBtn.Image")));
            this.AgregarServicioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarServicioBtn.Location = new System.Drawing.Point(137, 89);
            this.AgregarServicioBtn.Name = "AgregarServicioBtn";
            this.AgregarServicioBtn.Size = new System.Drawing.Size(89, 70);
            this.AgregarServicioBtn.TabIndex = 16;
            this.AgregarServicioBtn.Text = "Agregar Servicio";
            this.AgregarServicioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarServicioBtn.UseVisualStyleBackColor = false;
            this.AgregarServicioBtn.Click += new System.EventHandler(this.AgregarServicioBtn_Click);
            // 
            // BuscarServiciosBtn
            // 
            this.BuscarServiciosBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BuscarServiciosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarServiciosBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarServiciosBtn.Image")));
            this.BuscarServiciosBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarServiciosBtn.Location = new System.Drawing.Point(600, 102);
            this.BuscarServiciosBtn.Name = "BuscarServiciosBtn";
            this.BuscarServiciosBtn.Size = new System.Drawing.Size(75, 57);
            this.BuscarServiciosBtn.TabIndex = 2;
            this.BuscarServiciosBtn.Text = "Consultar";
            this.BuscarServiciosBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarServiciosBtn.UseVisualStyleBackColor = false;
            this.BuscarServiciosBtn.Click += new System.EventHandler(this.BuscarServiciosBtn_Click);
            // 
            // Servicioscmb
            // 
            this.Servicioscmb.FormattingEnabled = true;
            this.Servicioscmb.Items.AddRange(new object[] {
            "Servicios"});
            this.Servicioscmb.Location = new System.Drawing.Point(450, 118);
            this.Servicioscmb.Name = "Servicioscmb";
            this.Servicioscmb.Size = new System.Drawing.Size(121, 21);
            this.Servicioscmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Servicios Activos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // serviciosDtg
            // 
            this.serviciosDtg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.serviciosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviciosDtg.Location = new System.Drawing.Point(180, 178);
            this.serviciosDtg.Name = "serviciosDtg";
            this.serviciosDtg.Size = new System.Drawing.Size(563, 265);
            this.serviciosDtg.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.CANCELARBTN);
            this.panel2.Controls.Add(this.TotalServiciostxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 124);
            this.panel2.TabIndex = 16;
            // 
            // CANCELARBTN
            // 
            this.CANCELARBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.CANCELARBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CANCELARBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CANCELARBTN.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCELARBTN.Image = ((System.Drawing.Image)(resources.GetObject("CANCELARBTN.Image")));
            this.CANCELARBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CANCELARBTN.Location = new System.Drawing.Point(756, 24);
            this.CANCELARBTN.Name = "CANCELARBTN";
            this.CANCELARBTN.Size = new System.Drawing.Size(71, 54);
            this.CANCELARBTN.TabIndex = 22;
            this.CANCELARBTN.Text = "Cancelar";
            this.CANCELARBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CANCELARBTN.UseVisualStyleBackColor = false;
            this.CANCELARBTN.Click += new System.EventHandler(this.CANCELARBTN_Click);
            // 
            // TotalServiciostxt
            // 
            this.TotalServiciostxt.Location = new System.Drawing.Point(234, 38);
            this.TotalServiciostxt.Name = "TotalServiciostxt";
            this.TotalServiciostxt.Size = new System.Drawing.Size(100, 20);
            this.TotalServiciostxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Servicios";
            // 
            // MenuServiciosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(878, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.VeterinarioCmb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuServiciosFrm";
            this.Text = "MenuServiciosFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.VeterinarioCmb.ResumeLayout(false);
            this.VeterinarioCmb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDtg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel VeterinarioCmb;
        private System.Windows.Forms.Button BuscarServiciosBtn;
        private System.Windows.Forms.ComboBox Servicioscmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgregarServicioBtn;
        private System.Windows.Forms.DataGridView serviciosDtg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TotalServiciostxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CANCELARBTN;
    }
}