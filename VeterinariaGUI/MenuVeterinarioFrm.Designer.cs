namespace VeterinariaGUI
{
    partial class MenuVeterinarioFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVeterinarioFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.VeterinarioCmb = new System.Windows.Forms.Panel();
            this.DateFecha = new System.Windows.Forms.DateTimePicker();
            this.AgregarVeterinarioBtn = new System.Windows.Forms.Button();
            this.BuscarVeterinarioBtn = new System.Windows.Forms.Button();
            this.TipoVeterinarioCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VeterinarioDtg = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CANCELARBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.VeterinarioCmb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeterinarioDtg)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(975, 35);
            this.panel1.TabIndex = 2;
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
            this.VeterinarioCmb.Controls.Add(this.DateFecha);
            this.VeterinarioCmb.Controls.Add(this.AgregarVeterinarioBtn);
            this.VeterinarioCmb.Controls.Add(this.BuscarVeterinarioBtn);
            this.VeterinarioCmb.Controls.Add(this.TipoVeterinarioCmb);
            this.VeterinarioCmb.Controls.Add(this.label2);
            this.VeterinarioCmb.Location = new System.Drawing.Point(0, 27);
            this.VeterinarioCmb.Name = "VeterinarioCmb";
            this.VeterinarioCmb.Size = new System.Drawing.Size(1080, 200);
            this.VeterinarioCmb.TabIndex = 4;
            // 
            // DateFecha
            // 
            this.DateFecha.Location = new System.Drawing.Point(350, 113);
            this.DateFecha.Name = "DateFecha";
            this.DateFecha.Size = new System.Drawing.Size(200, 20);
            this.DateFecha.TabIndex = 10;
            // 
            // AgregarVeterinarioBtn
            // 
            this.AgregarVeterinarioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.AgregarVeterinarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AgregarVeterinarioBtn.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarVeterinarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("AgregarVeterinarioBtn.Image")));
            this.AgregarVeterinarioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarVeterinarioBtn.Location = new System.Drawing.Point(176, 84);
            this.AgregarVeterinarioBtn.Name = "AgregarVeterinarioBtn";
            this.AgregarVeterinarioBtn.Size = new System.Drawing.Size(89, 70);
            this.AgregarVeterinarioBtn.TabIndex = 9;
            this.AgregarVeterinarioBtn.Text = "Agregar Veterinario";
            this.AgregarVeterinarioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarVeterinarioBtn.UseVisualStyleBackColor = false;
            this.AgregarVeterinarioBtn.Click += new System.EventHandler(this.AgregarVeterinarioBtn_Click);
            // 
            // BuscarVeterinarioBtn
            // 
            this.BuscarVeterinarioBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.BuscarVeterinarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarVeterinarioBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarVeterinarioBtn.Image")));
            this.BuscarVeterinarioBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarVeterinarioBtn.Location = new System.Drawing.Point(777, 97);
            this.BuscarVeterinarioBtn.Name = "BuscarVeterinarioBtn";
            this.BuscarVeterinarioBtn.Size = new System.Drawing.Size(75, 57);
            this.BuscarVeterinarioBtn.TabIndex = 2;
            this.BuscarVeterinarioBtn.Text = "Buscar";
            this.BuscarVeterinarioBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BuscarVeterinarioBtn.UseVisualStyleBackColor = false;
            this.BuscarVeterinarioBtn.Click += new System.EventHandler(this.BuscarVeterinarioBtn_Click);
            // 
            // TipoVeterinarioCmb
            // 
            this.TipoVeterinarioCmb.FormattingEnabled = true;
            this.TipoVeterinarioCmb.Items.AddRange(new object[] {
            "Veterinarios",
            "ConsultaPorFechaVeterinarios"});
            this.TipoVeterinarioCmb.Location = new System.Drawing.Point(608, 112);
            this.TipoVeterinarioCmb.Name = "TipoVeterinarioCmb";
            this.TipoVeterinarioCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoVeterinarioCmb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Veterinarios Activos";
            // 
            // VeterinarioDtg
            // 
            this.VeterinarioDtg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.VeterinarioDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VeterinarioDtg.Location = new System.Drawing.Point(0, 224);
            this.VeterinarioDtg.Name = "VeterinarioDtg";
            this.VeterinarioDtg.Size = new System.Drawing.Size(975, 278);
            this.VeterinarioDtg.TabIndex = 8;
            this.VeterinarioDtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VeterinarioDtg_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.CANCELARBTN);
            this.panel2.Location = new System.Drawing.Point(0, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 114);
            this.panel2.TabIndex = 9;
            // 
            // CANCELARBTN
            // 
            this.CANCELARBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.CANCELARBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CANCELARBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CANCELARBTN.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCELARBTN.Image = ((System.Drawing.Image)(resources.GetObject("CANCELARBTN.Image")));
            this.CANCELARBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CANCELARBTN.Location = new System.Drawing.Point(853, 33);
            this.CANCELARBTN.Name = "CANCELARBTN";
            this.CANCELARBTN.Size = new System.Drawing.Size(71, 54);
            this.CANCELARBTN.TabIndex = 21;
            this.CANCELARBTN.Text = "Cancelar";
            this.CANCELARBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CANCELARBTN.UseVisualStyleBackColor = false;
            this.CANCELARBTN.Click += new System.EventHandler(this.CANCELARBTN_Click);
            // 
            // MenuVeterinarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(975, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.VeterinarioDtg);
            this.Controls.Add(this.VeterinarioCmb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuVeterinarioFrm";
            this.Text = "MenuVeterinarioFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.VeterinarioCmb.ResumeLayout(false);
            this.VeterinarioCmb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeterinarioDtg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel VeterinarioCmb;
        private System.Windows.Forms.Button BuscarVeterinarioBtn;
        private System.Windows.Forms.ComboBox TipoVeterinarioCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgregarVeterinarioBtn;
        private System.Windows.Forms.DataGridView VeterinarioDtg;
        private System.Windows.Forms.DateTimePicker DateFecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CANCELARBTN;
    }
}