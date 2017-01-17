namespace M15_trabalho
{
    partial class fr_addSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_addSave));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.cbArma = new System.Windows.Forms.ComboBox();
            this.mtxtVida = new System.Windows.Forms.MaskedTextBox();
            this.mtxtX = new System.Windows.Forms.MaskedTextBox();
            this.mtxtY = new System.Windows.Forms.MaskedTextBox();
            this.mtxtZ = new System.Windows.Forms.MaskedTextBox();
            this.mtxtBalas = new System.Windows.Forms.MaskedTextBox();
            this.mtxtRecargas = new System.Windows.Forms.MaskedTextBox();
            this.mtxtScore = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Z:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nível:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Arma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Balas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Recargas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Score:";
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbNivel.Location = new System.Drawing.Point(119, 194);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(131, 21);
            this.cbNivel.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cbNivel, "Escolha um nivel");
            this.cbNivel.Validating += new System.ComponentModel.CancelEventHandler(this.cbNivel_Validating);
            // 
            // cbArma
            // 
            this.cbArma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArma.FormattingEnabled = true;
            this.cbArma.Items.AddRange(new object[] {
            "Sawed-Off",
            "M4A1-S",
            "M4A4",
            "RPG",
            "AWP"});
            this.cbArma.Location = new System.Drawing.Point(119, 235);
            this.cbArma.Name = "cbArma";
            this.cbArma.Size = new System.Drawing.Size(131, 21);
            this.cbArma.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cbArma, "Escolha uma arma");
            this.cbArma.Validating += new System.ComponentModel.CancelEventHandler(this.cbArma_Validating);
            // 
            // mtxtVida
            // 
            this.mtxtVida.Location = new System.Drawing.Point(119, 35);
            this.mtxtVida.Mask = "000";
            this.mtxtVida.Name = "mtxtVida";
            this.mtxtVida.Size = new System.Drawing.Size(131, 20);
            this.mtxtVida.TabIndex = 0;
            this.toolTip1.SetToolTip(this.mtxtVida, "Insira a quantidade de vida\r\n");
            this.mtxtVida.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtVida_Validating);
            // 
            // mtxtX
            // 
            this.mtxtX.Location = new System.Drawing.Point(119, 75);
            this.mtxtX.Mask = "000";
            this.mtxtX.Name = "mtxtX";
            this.mtxtX.Size = new System.Drawing.Size(131, 20);
            this.mtxtX.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mtxtX, "Insira a posição X");
            this.mtxtX.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtX_Validating);
            // 
            // mtxtY
            // 
            this.mtxtY.Location = new System.Drawing.Point(119, 116);
            this.mtxtY.Mask = "000";
            this.mtxtY.Name = "mtxtY";
            this.mtxtY.Size = new System.Drawing.Size(131, 20);
            this.mtxtY.TabIndex = 2;
            this.toolTip1.SetToolTip(this.mtxtY, "Insira a posição Y");
            this.mtxtY.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtY_Validating);
            // 
            // mtxtZ
            // 
            this.mtxtZ.Location = new System.Drawing.Point(119, 155);
            this.mtxtZ.Mask = "000";
            this.mtxtZ.Name = "mtxtZ";
            this.mtxtZ.Size = new System.Drawing.Size(131, 20);
            this.mtxtZ.TabIndex = 3;
            this.toolTip1.SetToolTip(this.mtxtZ, "Insira a posição Z\r\n");
            this.mtxtZ.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtZ_Validating);
            // 
            // mtxtBalas
            // 
            this.mtxtBalas.Location = new System.Drawing.Point(119, 275);
            this.mtxtBalas.Mask = "00";
            this.mtxtBalas.Name = "mtxtBalas";
            this.mtxtBalas.Size = new System.Drawing.Size(131, 20);
            this.mtxtBalas.TabIndex = 6;
            this.toolTip1.SetToolTip(this.mtxtBalas, "Insira a quantidade de balas no clip");
            this.mtxtBalas.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtBalas_Validating);
            // 
            // mtxtRecargas
            // 
            this.mtxtRecargas.Location = new System.Drawing.Point(119, 315);
            this.mtxtRecargas.Mask = "000";
            this.mtxtRecargas.Name = "mtxtRecargas";
            this.mtxtRecargas.Size = new System.Drawing.Size(131, 20);
            this.mtxtRecargas.TabIndex = 7;
            this.toolTip1.SetToolTip(this.mtxtRecargas, "Insira  as balas de recarga");
            this.mtxtRecargas.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtRecargas_Validating);
            // 
            // mtxtScore
            // 
            this.mtxtScore.Location = new System.Drawing.Point(119, 355);
            this.mtxtScore.Mask = "000000";
            this.mtxtScore.Name = "mtxtScore";
            this.mtxtScore.Size = new System.Drawing.Size(131, 20);
            this.mtxtScore.TabIndex = 8;
            this.toolTip1.SetToolTip(this.mtxtScore, "Insira o seu score");
            this.mtxtScore.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtScore_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(104, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 32);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Adicionar Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // fr_addSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 439);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mtxtScore);
            this.Controls.Add(this.mtxtRecargas);
            this.Controls.Add(this.mtxtBalas);
            this.Controls.Add(this.mtxtZ);
            this.Controls.Add(this.mtxtY);
            this.Controls.Add(this.mtxtX);
            this.Controls.Add(this.mtxtVida);
            this.Controls.Add(this.cbArma);
            this.Controls.Add(this.cbNivel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_addSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fr_addSave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_addSave_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.ComboBox cbArma;
        private System.Windows.Forms.MaskedTextBox mtxtVida;
        private System.Windows.Forms.MaskedTextBox mtxtX;
        private System.Windows.Forms.MaskedTextBox mtxtY;
        private System.Windows.Forms.MaskedTextBox mtxtZ;
        private System.Windows.Forms.MaskedTextBox mtxtBalas;
        private System.Windows.Forms.MaskedTextBox mtxtRecargas;
        private System.Windows.Forms.MaskedTextBox mtxtScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}