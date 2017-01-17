namespace M15_trabalho
{
    partial class fr_stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_stats));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_mapa = new System.Windows.Forms.GroupBox();
            this.btnMapa = new System.Windows.Forms.Button();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.gbArmas = new System.Windows.Forms.GroupBox();
            this.lblReserva = new System.Windows.Forms.Label();
            this.lblBalas = new System.Windows.Forms.Label();
            this.lblArmas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblArma = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblVida = new System.Windows.Forms.Label();
            this.cbSaves = new System.Windows.Forms.ComboBox();
            this.bD_NWTR_M15_GPSIDataSet = new M15_trabalho.BD_NWTR_M15_GPSIDataSet();
            this.utilizadoresSavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizadores_SavesTableAdapter = new M15_trabalho.BD_NWTR_M15_GPSIDataSetTableAdapters.Utilizadores_SavesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eliminarSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_mapa.SuspendLayout();
            this.gbArmas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_NWTR_M15_GPSIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresSavesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Z:";
            // 
            // gb_mapa
            // 
            this.gb_mapa.Controls.Add(this.btnMapa);
            this.gb_mapa.Controls.Add(this.lblZ);
            this.gb_mapa.Controls.Add(this.lblY);
            this.gb_mapa.Controls.Add(this.lblX);
            this.gb_mapa.Controls.Add(this.label1);
            this.gb_mapa.Controls.Add(this.label3);
            this.gb_mapa.Controls.Add(this.label2);
            this.gb_mapa.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_mapa.Location = new System.Drawing.Point(18, 55);
            this.gb_mapa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_mapa.Name = "gb_mapa";
            this.gb_mapa.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_mapa.Size = new System.Drawing.Size(300, 209);
            this.gb_mapa.TabIndex = 1;
            this.gb_mapa.TabStop = false;
            this.gb_mapa.Text = "Localização no mapa";
            // 
            // btnMapa
            // 
            this.btnMapa.Location = new System.Drawing.Point(80, 163);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(96, 28);
            this.btnMapa.TabIndex = 5;
            this.btnMapa.Text = "Ver Mapa";
            this.btnMapa.UseVisualStyleBackColor = true;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(123, 128);
            this.lblZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(53, 19);
            this.lblZ.TabIndex = 1;
            this.lblZ.Text = "label4";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(123, 80);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(53, 19);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "label4";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(123, 34);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(53, 19);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "label4";
            // 
            // gbArmas
            // 
            this.gbArmas.Controls.Add(this.lblReserva);
            this.gbArmas.Controls.Add(this.lblBalas);
            this.gbArmas.Controls.Add(this.lblArmas);
            this.gbArmas.Controls.Add(this.label5);
            this.gbArmas.Controls.Add(this.label4);
            this.gbArmas.Controls.Add(this.label6);
            this.gbArmas.Controls.Add(this.lblArma);
            this.gbArmas.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbArmas.Location = new System.Drawing.Point(370, 55);
            this.gbArmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbArmas.Name = "gbArmas";
            this.gbArmas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbArmas.Size = new System.Drawing.Size(300, 209);
            this.gbArmas.TabIndex = 2;
            this.gbArmas.TabStop = false;
            this.gbArmas.Text = "Armas";
            // 
            // lblReserva
            // 
            this.lblReserva.AutoSize = true;
            this.lblReserva.Location = new System.Drawing.Point(159, 128);
            this.lblReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReserva.Name = "lblReserva";
            this.lblReserva.Size = new System.Drawing.Size(53, 19);
            this.lblReserva.TabIndex = 1;
            this.lblReserva.Text = "label7";
            // 
            // lblBalas
            // 
            this.lblBalas.AutoSize = true;
            this.lblBalas.Location = new System.Drawing.Point(159, 80);
            this.lblBalas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalas.Name = "lblBalas";
            this.lblBalas.Size = new System.Drawing.Size(53, 19);
            this.lblBalas.TabIndex = 1;
            this.lblBalas.Text = "label7";
            // 
            // lblArmas
            // 
            this.lblArmas.AutoSize = true;
            this.lblArmas.Location = new System.Drawing.Point(159, 34);
            this.lblArmas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArmas.Name = "lblArmas";
            this.lblArmas.Size = new System.Drawing.Size(53, 19);
            this.lblArmas.TabIndex = 1;
            this.lblArmas.Text = "label7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reserva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Balas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Arma:";
            // 
            // lblArma
            // 
            this.lblArma.AutoSize = true;
            this.lblArma.Location = new System.Drawing.Point(30, 34);
            this.lblArma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArma.Name = "lblArma";
            this.lblArma.Size = new System.Drawing.Size(52, 19);
            this.lblArma.TabIndex = 0;
            this.lblArma.Text = "Arma:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Play", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(362, 283);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 31);
            this.label10.TabIndex = 3;
            this.label10.Text = "VIDA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Play", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(9, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "NÍVEL:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Play", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(178, 283);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(92, 31);
            this.lblNivel.TabIndex = 4;
            this.lblNivel.Text = "label8";
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Font = new System.Drawing.Font("Play", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.Location = new System.Drawing.Point(507, 283);
            this.lblVida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(92, 31);
            this.lblVida.TabIndex = 4;
            this.lblVida.Text = "label8";
            // 
            // cbSaves
            // 
            this.cbSaves.FormattingEnabled = true;
            this.cbSaves.Location = new System.Drawing.Point(276, 14);
            this.cbSaves.Name = "cbSaves";
            this.cbSaves.Size = new System.Drawing.Size(121, 28);
            this.cbSaves.Sorted = true;
            this.cbSaves.TabIndex = 5;
            this.cbSaves.SelectedIndexChanged += new System.EventHandler(this.cbSaves_SelectedIndexChanged);
            // 
            // bD_NWTR_M15_GPSIDataSet
            // 
            this.bD_NWTR_M15_GPSIDataSet.DataSetName = "BD_NWTR_M15_GPSIDataSet";
            this.bD_NWTR_M15_GPSIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizadoresSavesBindingSource
            // 
            this.utilizadoresSavesBindingSource.DataMember = "Utilizadores_Saves";
            this.utilizadoresSavesBindingSource.DataSource = this.bD_NWTR_M15_GPSIDataSet;
            // 
            // utilizadores_SavesTableAdapter
            // 
            this.utilizadores_SavesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarSaveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eliminarSaveToolStripMenuItem
            // 
            this.eliminarSaveToolStripMenuItem.Name = "eliminarSaveToolStripMenuItem";
            this.eliminarSaveToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.eliminarSaveToolStripMenuItem.Text = "Eliminar Save";
            this.eliminarSaveToolStripMenuItem.Click += new System.EventHandler(this.eliminarSaveToolStripMenuItem_Click);
            // 
            // fr_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 374);
            this.Controls.Add(this.cbSaves);
            this.Controls.Add(this.lblVida);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbArmas);
            this.Controls.Add(this.gb_mapa);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "fr_stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fr_stats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_stats_FormClosing);
            this.gb_mapa.ResumeLayout(false);
            this.gb_mapa.PerformLayout();
            this.gbArmas.ResumeLayout(false);
            this.gbArmas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bD_NWTR_M15_GPSIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizadoresSavesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_mapa;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox gbArmas;
        private System.Windows.Forms.Label lblArma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReserva;
        private System.Windows.Forms.Label lblBalas;
        private System.Windows.Forms.Label lblArmas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.ComboBox cbSaves;
        private BD_NWTR_M15_GPSIDataSet bD_NWTR_M15_GPSIDataSet;
        private System.Windows.Forms.BindingSource utilizadoresSavesBindingSource;
        private BD_NWTR_M15_GPSIDataSetTableAdapters.Utilizadores_SavesTableAdapter utilizadores_SavesTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarSaveToolStripMenuItem;
    }
}