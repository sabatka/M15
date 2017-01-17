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
    public partial class fr_painel : Form
    {
        public fr_stats statsForm = new fr_stats();

        public fr_painel()
        {
            InitializeComponent();
            dtgLeaderboard.Refresh();
            dtgLeaderboard.DataSource = BaseDados.Instance.LeaderBoard();
    
            BaseDados.Instance.MostrarDadosEditar(BaseDados.Instance.id_logado);
            txtUserEdit.Text = BaseDados.Instance.username;
            txtPassEdit.Text = BaseDados.Instance.password;
            txtEmailEdit.Text = BaseDados.Instance.email;
            txtEmailEdit.Enabled = false;
            txtPassEdit.Enabled = false;
            txtUserEdit.Enabled = false;
            btnAplicar.Hide();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAplicar.Show();
            btnEditar.Hide();
            txtEmailEdit.Enabled = true;
            txtPassEdit.Enabled = true;
            txtUserEdit.Enabled = true;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            BaseDados.Instance.EditarRegisto(BaseDados.Instance.id_logado, txtUserEdit.Text, txtPassEdit.Text, txtEmailEdit.Text);
            txtEmailEdit.Enabled = false;
            txtPassEdit.Enabled = false;
            txtUserEdit.Enabled = false;
            btnEditar.Show();
            btnAplicar.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_painel.ActiveForm.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        public void ComboBoxEmptyChecker(ComboBox cb)
        {
            if (cb.Text == "")
            {
                MessageBox.Show("Não existem saves disponiveis!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                int id_save = Convert.ToInt32(cb.Text);
                BaseDados.Instance.MostrarSaves(id_save);
                statsForm.Show();
            }
        }

        private void verEstastísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComboBoxEmptyChecker(statsForm.GetComboBox());
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                MessageBox.Show("Insira algo para poder pesquisar!");
            }
            else
            {
                dtgLeaderboard.DataSource = BaseDados.Instance.PesquisarRegistos(txtPesquisar.Text);
                txtPesquisar.Clear();
            }
        }

        private void lblLeaderboard_Click(object sender, EventArgs e)
        {
            dtgLeaderboard.DataSource = BaseDados.Instance.LeaderBoard();
            txtPesquisar.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dtgLeaderboard.DataSource = BaseDados.Instance.SomarLeaderboard();
        }

        private void adicionarSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_addSave saveForm = new fr_addSave();
            saveForm.Show();
            Close();
        }
    }
}
