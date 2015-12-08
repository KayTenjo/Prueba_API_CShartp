using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_API_CShartp
{
    public partial class Form1 : Form
    {
        private MessagesGenerator guante = new MessagesGenerator();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonInicializar_Click(object sender, EventArgs e)
        {
            string[] pines_string = textBoxPines.Text.Split(',');
            int[] pines = new int[pines_string.Length];

            for (var i = 0; i < pines_string.Length; i++)
            {
                pines[i] = Int32.Parse(pines_string[i]);
            }

            labelResultado.Text = "Resultado: " + guante.InitializeActuators(pines);


        }

        private void buttonActivar_Click(object sender, EventArgs e)
        {
            string[] pines_string = textBoxPines.Text.Split(',');
            int[] pines = new int[pines_string.Length];

            for (var i = 0; i < pines_string.Length; i++)
            {
                pines[i] = Int32.Parse(pines_string[i]);
            }

            string[] valores_string = textBoxValores.Text.Split(',');




            labelResultado.Text = "Resultado: " + guante.ActivateActuators(pines, valores_string);
        }
    }
}
