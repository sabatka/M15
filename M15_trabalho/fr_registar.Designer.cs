namespace M15_trabalho
{
    partial class fr_registar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_registar));
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.txtPasswordReg = new System.Windows.Forms.TextBox();
            this.txtUsernameReg = new System.Windows.Forms.TextBox();
            this.labelReg2 = new System.Windows.Forms.Label();
            this.labelReg1 = new System.Windows.Forms.Label();
            this.txtEmailReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbWrongEmail = new System.Windows.Forms.PictureBox();
            this.pbWrongPass = new System.Windows.Forms.PictureBox();
            this.pbWrongName = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbWrongEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrongPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrongName)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(95, 171);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(99, 12);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ja tem uma conta?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.Location = new System.Drawing.Point(72, 129);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(145, 26);
            this.btnRegistar.TabIndex = 4;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtPasswordReg
            // 
            this.txtPasswordReg.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordReg.Location = new System.Drawing.Point(110, 61);
            this.txtPasswordReg.Name = "txtPasswordReg";
            this.txtPasswordReg.PasswordChar = '*';
            this.txtPasswordReg.Size = new System.Drawing.Size(145, 20);
            this.txtPasswordReg.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPasswordReg, "Insira password");
            // 
            // txtUsernameReg
            // 
            this.txtUsernameReg.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameReg.Location = new System.Drawing.Point(110, 24);
            this.txtUsernameReg.Name = "txtUsernameReg";
            this.txtUsernameReg.Size = new System.Drawing.Size(145, 20);
            this.txtUsernameReg.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtUsernameReg, "Insira username");
            // 
            // labelReg2
            // 
            this.labelReg2.AutoSize = true;
            this.labelReg2.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReg2.Location = new System.Drawing.Point(32, 64);
            this.labelReg2.Name = "labelReg2";
            this.labelReg2.Size = new System.Drawing.Size(55, 12);
            this.labelReg2.TabIndex = 4;
            this.labelReg2.Text = "Password:";
            // 
            // labelReg1
            // 
            this.labelReg1.AutoSize = true;
            this.labelReg1.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReg1.Location = new System.Drawing.Point(30, 27);
            this.labelReg1.Name = "labelReg1";
            this.labelReg1.Size = new System.Drawing.Size(58, 12);
            this.labelReg1.TabIndex = 5;
            this.labelReg1.Text = "Username:";
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailReg.Location = new System.Drawing.Point(110, 97);
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.Size = new System.Drawing.Size(145, 20);
            this.txtEmailReg.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtEmailReg, "Insira o seu email");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email:";
            // 
            // pbWrongEmail
            // 
            this.pbWrongEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbWrongEmail.Image")));
            this.pbWrongEmail.Location = new System.Drawing.Point(261, 97);
            this.pbWrongEmail.Name = "pbWrongEmail";
            this.pbWrongEmail.Size = new System.Drawing.Size(20, 18);
            this.pbWrongEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWrongEmail.TabIndex = 10;
            this.pbWrongEmail.TabStop = false;
            // 
            // pbWrongPass
            // 
            this.pbWrongPass.Image = ((System.Drawing.Image)(resources.GetObject("pbWrongPass.Image")));
            this.pbWrongPass.Location = new System.Drawing.Point(261, 61);
            this.pbWrongPass.Name = "pbWrongPass";
            this.pbWrongPass.Size = new System.Drawing.Size(20, 18);
            this.pbWrongPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWrongPass.TabIndex = 10;
            this.pbWrongPass.TabStop = false;
            // 
            // pbWrongName
            // 
            this.pbWrongName.Image = ((System.Drawing.Image)(resources.GetObject("pbWrongName.Image")));
            this.pbWrongName.Location = new System.Drawing.Point(261, 24);
            this.pbWrongName.Name = "pbWrongName";
            this.pbWrongName.Size = new System.Drawing.Size(20, 18);
            this.pbWrongName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWrongName.TabIndex = 10;
            this.pbWrongName.TabStop = false;
            // 
            // fr_registar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.Controls.Add(this.pbWrongName);
            this.Controls.Add(this.pbWrongPass);
            this.Controls.Add(this.pbWrongEmail);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtEmailReg);
            this.Controls.Add(this.txtPasswordReg);
            this.Controls.Add(this.txtUsernameReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelReg2);
            this.Controls.Add(this.labelReg1);
            this.Font = new System.Drawing.Font("Play", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fr_registar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fr_registar";
            ((System.ComponentModel.ISupportInitialize)(this.pbWrongEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrongPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrongName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox txtPasswordReg;
        private System.Windows.Forms.TextBox txtUsernameReg;
        private System.Windows.Forms.Label labelReg2;
        private System.Windows.Forms.Label labelReg1;
        private System.Windows.Forms.TextBox txtEmailReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbWrongEmail;
        private System.Windows.Forms.PictureBox pbWrongPass;
        private System.Windows.Forms.PictureBox pbWrongName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}