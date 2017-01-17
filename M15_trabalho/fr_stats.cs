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
    public partial class fr_stats : Form
    {
        public ComboBox GetComboBox()
        {
            return cbSaves;
        }

        bool isButtonClick = false;

        public fr_stats()
        {
            InitializeComponent();
            BaseDados.Instance.PreencherCBSaves(cbSaves);

            if(cbSaves.Text == "") { }
            else
            {
                int id_save = Convert.ToInt32(cbSaves.Text);
                BaseDados.Instance.MostrarSaves(id_save);
            }
           
            switch (BaseDados.Instance.arma)
            {
                case 1:
                    lblArmas.Text = "Sawed-Off";
                    break;

                case 2:
                    lblArmas.Text = "M4A1-S";
                    break;

                case 3:
                    lblArmas.Text = "M4A4";
                    break;

                case 4:
                    lblArmas.Text = "RPG";
                    break;

                case 5:
                    lblArmas.Text = "AWP";
                    break;
            }

            lblVida.Text = BaseDados.Instance.vida.ToString();
            lblX.Text = BaseDados.Instance.localizacao_x.ToString();
            lblY.Text = BaseDados.Instance.localizacao_y.ToString();
            lblZ.Text = BaseDados.Instance.localizacao_z.ToString();
            lblNivel.Text = BaseDados.Instance.nivel.ToString();
            lblBalas.Text = BaseDados.Instance.balas.ToString();
            lblReserva.Text = BaseDados.Instance.recargas.ToString();
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            fr_map formMap = new fr_map();
            formMap.ShowDialog();
        }

        private void cbSaves_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_save = ((Elementos)cbSaves.SelectedItem).id;
            BaseDados.Instance.MostrarSaves(id_save);

            switch (BaseDados.Instance.arma)
            {
                case 1:
                    lblArmas.Text = "Sawed-Off";
                    break;

                case 2:
                    lblArmas.Text = "M4A1-S";
                    break;

                case 3:
                    lblArmas.Text = "M4A4";
                    break;

                case 4:
                    lblArmas.Text = "RPG";
                    break;

                case 5:
                    lblArmas.Text = "AWP";
                    break;
            }

            lblVida.Text = BaseDados.Instance.vida.ToString();
            lblX.Text = BaseDados.Instance.localizacao_x.ToString();
            lblY.Text = BaseDados.Instance.localizacao_y.ToString();
            lblZ.Text = BaseDados.Instance.localizacao_z.ToString();
            lblNivel.Text = BaseDados.Instance.nivel.ToString();
            lblBalas.Text = BaseDados.Instance.balas.ToString();
            lblReserva.Text = BaseDados.Instance.recargas.ToString();
        }

        private void eliminarSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("Tem a certeza que quer eliminar o seu save?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {
                resultado = MessageBox.Show("Depois de eliminado o seu save não podera ser recuperado. Tem certeza que quer continuar?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.Yes)
                {
                    BaseDados.Instance.EliminarSave(Convert.ToInt32(cbSaves.Text));
                    MessageBox.Show("O seu save foi eliminado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    isButtonClick = true;
                    Close();
                }
            }
        }

        private void fr_stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            fr_painel painelForm = new fr_painel();
            fr_stats statsForm = new fr_stats();
            if (isButtonClick)
            {
                painelForm.ComboBoxEmptyChecker(statsForm.GetComboBox());
                
            }
            else
            {
                painelForm.Show();
            }
        }
    }
}
