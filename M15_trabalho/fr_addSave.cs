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
    public partial class fr_addSave : Form
    {
        public fr_addSave()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(mtxtVida.Text == "" && mtxtX.Text == "" && mtxtY.Text == "" && mtxtZ.Text == "" && cbNivel.SelectedIndex == -1 && cbArma.SelectedIndex == -1 && mtxtBalas.Text == "" && mtxtRecargas.Text == "" && mtxtScore.Text == "")
            {
                Elementos.ErrorProvider(mtxtVida, errorProvider1, "Insira a sua vida");
                Elementos.ErrorProvider(mtxtX, errorProvider1, "Insira a sua localização no eixo dos X");
                Elementos.ErrorProvider(mtxtY, errorProvider1, "Insira a sua localização no eixo dos Y");
                Elementos.ErrorProvider(mtxtZ, errorProvider1, "Insira a sua localização no eixo dos Z");
                Elementos.ErrorProviderComboBox(cbNivel, errorProvider1, "Escolha o nível em que se encontra");
                Elementos.ErrorProviderComboBox(cbArma, errorProvider1, "Escolha a arma que possui");
                Elementos.ErrorProvider(mtxtBalas, errorProvider1, "Insira o seu número de balas");
                Elementos.ErrorProvider(mtxtRecargas, errorProvider1, "Insira o seu número de balas de recarga");
                Elementos.ErrorProvider(mtxtScore, errorProvider1, "Insira o seu score");
            }
            else if (mtxtVida.Text == "")
            {
                Elementos.ErrorProvider(mtxtVida, errorProvider1, "Insira a sua vida");
            }
            else if(mtxtX.Text == "")
            {
                Elementos.ErrorProvider(mtxtX, errorProvider1, "Insira a sua localização no eixo dos X");
            }
            else if(mtxtY.Text == "")
            {
                Elementos.ErrorProvider(mtxtY, errorProvider1, "Insira a sua localização no eixo dos Y");
            }
            else if(mtxtZ.Text == "")
            {
                Elementos.ErrorProvider(mtxtZ, errorProvider1, "Insira a sua localização no eixo dos Z");
            }
            else if(cbNivel.SelectedIndex == -1)
            {
                Elementos.ErrorProviderComboBox(cbNivel, errorProvider1, "Escolha o nível em que se encontra");
            }
            else if(cbArma.SelectedIndex == -1)
            {
                Elementos.ErrorProviderComboBox(cbArma, errorProvider1, "Escolha a arma que possui");
            }
            else if(mtxtBalas.Text == "")
            {
                Elementos.ErrorProvider(mtxtBalas, errorProvider1, "Insira o seu número de balas");
            }
            else if(mtxtRecargas.Text == "")
            {
                Elementos.ErrorProvider(mtxtRecargas, errorProvider1, "Insira o seu número de balas de recarga");
            }
            else if(mtxtScore.Text == "")
            {
                Elementos.ErrorProvider(mtxtScore, errorProvider1, "Insira o seu score");
            }
            else
            {
                BaseDados.Instance.AdicionarSave(mtxtVida.Text, mtxtX.Text, mtxtY.Text, mtxtZ.Text, cbNivel.SelectedIndex + 1, cbArma.SelectedIndex + 1, mtxtBalas.Text, mtxtRecargas.Text, mtxtScore.Text);
                BaseDados.Instance.LinkUserSave(BaseDados.Instance.id_logado);
                MessageBox.Show("Utilizador registado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    
        private void mtxtZ_Validating(object sender, CancelEventArgs e)
        {
            Elementos.ErrorProvider(mtxtZ, errorProvider1, "Insira a sua localização no eixo dos Z");
        }

        private void mtxtY_Validating(object sender, CancelEventArgs e)
        {
            Elementos.ErrorProvider(mtxtY, errorProvider1, "Insira a sua localização no eixo dos Y");
        }

        private void mtxtX_Validating(object sender, CancelEventArgs e)
        {
            Elementos.ErrorProvider(mtxtX, errorProvider1, "Insira a sua localização no eixo dos X");
        }

        private void cbNivel_Validating(object sender, CancelEventArgs e)
        {
            Elementos.ErrorProviderComboBox(cbNivel, errorProvider1, "Escolha o nível em que se encontra");
        }

        private void cbArma_Validating(object sender, CancelEventArgs e)
        {
            Elementos.ErrorProviderComboBox(cbArma, errorProvider1, "Escolha a arma que possui");
        }

        private void mtxtBalas_Validating(object sender, CancelEventArgs e)
        {
            Elementos.ErrorProvider(mtxtBalas, errorProvider1, "Insira o seu número de balas");
        }

        private void mtxtRecargas_Validating(object sender, CancelEventArgs e)
        {
            Elementos.ErrorProvider(mtxtRecargas, errorProvider1, "Insira o seu número de balas de recarga");
        }

        private void mtxtScore_Validating(object sender, CancelEventArgs e)
        {
            Elementos.ErrorProvider(mtxtScore, errorProvider1, "Insira o seu score");
        }

        private void mtxtVida_Validating(object sender, CancelEventArgs e)
        {
            Elementos.ErrorProvider(mtxtVida, errorProvider1, "Insira a sua vida");
        }

        private void fr_addSave_FormClosing(object sender, FormClosingEventArgs e)
        {
            fr_painel painelForm = new fr_painel();
            painelForm.Show();
        }
    }
}
