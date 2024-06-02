using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjArraySimples
{
    public partial class FrmArraySimples : MetroFramework.Forms.MetroForm
    {
        //Criando uma constante
        const int MAX = 3;

        //Criando ARRAY
        int[] x = new int[MAX];


        public FrmArraySimples()
        {
            InitializeComponent();
        }

        private void FrmArraySimples_Load(object sender, EventArgs e)
        {
            x[0] = 99;
            x[1] = 73;
            x[2] = 27;
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Som_da_moeda_do_Super_Mario);
            simpleSound.Play();
        }

        private void btnVarrer_Click(object sender, EventArgs e)
        {
            try
            { 
                int pos = -1;

                int valor1 = Convert.ToInt32(txtValor.Text);

                    for (int i = 0; i < MAX; i++)
                    {
                        if (valor1 == x[i])
                        {
                            pos = i;
                            MessageBox.Show("ARRAY = Posição 1 -> " + x[0]);
                            playSimpleSound();
                            txtValor.Clear();
                        }
                        else
                        {
                            txtValor.Clear();
                            MessageBox.Show("Errou!");
                            break;
                        }
                    }
            }catch(Exception erro)
            {
            }

        }
    }
}
