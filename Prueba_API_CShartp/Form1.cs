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
        private Glove guante = new Glove();
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

            //labelResultado.Text = "Resultado: " + guante.InitializeActuators(pines);
            guante.InitializeActuators(pines);


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




            //labelResultado.Text = "Resultado: " + guante.ActivateActuators(pines, valores_string);
            guante.ActivateActuators(pines, valores_string);
        }

        private void buttonListaPuertos_Click(object sender, EventArgs e)
        {
            string[] puertos = guante.GetPortNames();

            listBoxPuertosDisponibles.Items.AddRange(puertos);

        }

        private void buttonInicializarSerial_Click(object sender, EventArgs e)
        {
            string puerto = listBoxPuertosDisponibles.SelectedItem.ToString();
            int baudRate = Int32.Parse(textBoxBaudRate.Text);

            guante.OpenPort(puerto, baudRate);

        }

      

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            string mensaje = textBoxEnviarDatos.Text;
            guante.Write(mensaje);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string pin = textBoxPines.Text;
            int pin_int = Int32.Parse(pin);
            textBoxRecibirDatos.Text = guante.AnalogRead(pin_int).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guante.ClosePort();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
