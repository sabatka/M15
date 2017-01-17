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
    public partial class fr_map : Form
    {
        public fr_map()
        {
            InitializeComponent();
            timer1.Start();
            pictureBox1.Controls.Add(pbPlayer);
            pbPlayer.BackColor = Color.Transparent;
            pbPlayer.Location = new Point(BaseDados.Instance.localizacao_x, BaseDados.Instance.localizacao_y);
            Niveis();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbPlayer.Visible = !pbPlayer.Visible;
            timer1.Interval = 500;
        }

        private void Niveis()
        {
            int nivel = BaseDados.Instance.nivel;
            switch (nivel)
            {
                case 1:
                    pictureBox1.Image = M15_trabalho.Properties.Resources.nivel1;
                    break;

                case 2:
                    pictureBox1.Image = M15_trabalho.Properties.Resources.nivel2;
                    break;

                case 3:
                    pictureBox1.Image = M15_trabalho.Properties.Resources.nivel3;
                    break;

                case 4:
                    pictureBox1.Image = M15_trabalho.Properties.Resources.nivel4;
                    break;

                case 5:
                    pictureBox1.Image = M15_trabalho.Properties.Resources.nivel5;
                    break;
                default:
                    break;
            }
           
        }
    }
}
