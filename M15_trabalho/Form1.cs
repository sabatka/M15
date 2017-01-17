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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            pbWrongPassword.Hide();
            pbWrongUser.Hide();

            if (System.IO.File.Exists(@"C:\Users\gab_s\Documents\BD_NWTR_M15_GPSI.mdf") == false)
            {
                BaseDados.criarBD(@"C:\Users\gab_s\Documents\BD_NWTR_M15_GPSI.mdf");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fr_registar registarForm = new fr_registar();
            registarForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pbWrongPassword.Hide();
            pbWrongUser.Hide();

            if (txtUsername.Text == "")
            {
                pbWrongUser.Show();
                pbWrongPassword.Hide();
            }
            else if (txtPassword.Text == "")
            {
                pbWrongPassword.Show();
                pbWrongUser.Hide();
            }
            else
            {
                BaseDados.Instance.LoginUtilizador(txtUsername.Text, txtPassword.Text);
            }
        }
    }
}
