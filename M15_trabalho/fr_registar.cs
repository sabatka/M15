using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M15_trabalho
{
    public partial class fr_registar : Form
    {
        public fr_registar()
        {
            InitializeComponent();

            pbWrongEmail.Hide();
            pbWrongName.Hide();
            pbWrongPass.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            if (txtUsernameReg.Text == "")
            {
                pbWrongPass.Hide();
                pbWrongEmail.Hide();
                pbWrongName.Show();
            }
            else if (txtPasswordReg.Text == "")
            {
                pbWrongPass.Show();
                pbWrongEmail.Hide();
                pbWrongName.Hide();
            }
            else if (!IsValidEmail(txtEmailReg.Text))
            {
                pbWrongEmail.Show();
                pbWrongName.Hide();
                pbWrongPass.Hide();
            }
            else if (BaseDados.Instance.VerificarExistenciaEmail(txtEmailReg.Text) || BaseDados.Instance.VerificarExistenciaNome(txtUsernameReg.Text))
            {
                pbWrongEmail.Show();
                pbWrongName.Show();
            }
            else
            {
                BaseDados.Instance.RegistarUtilizador(txtUsernameReg.Text, txtPasswordReg.Text, txtEmailReg.Text);
                pbWrongEmail.Hide();
                pbWrongName.Hide();
                pbWrongPass.Hide();
                txtEmailReg.Text = "";
                txtPasswordReg.Text = "";
                txtUsernameReg.Text = "";
                MessageBox.Show("Utilizador registado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
