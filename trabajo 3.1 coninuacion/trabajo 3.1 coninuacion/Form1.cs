using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_3._1_coninuacion
{
    public partial class Form1 : Form
    {
        private int progreso = 0;
        private int incremento = 10;
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0; progressBar1.Maximum = 100; progressBar1.Value = 0; timer1.Interval = 100;
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            label1.Text = contador.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string entrada = textBox1.Text;
            if (int.TryParse(entrada, out int numeroComvertido))
            {
                label2.Text = $"correcto el numero es: {numeroComvertido}";
                label2.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show($"Entrada válida. Número: {numeroComvertido}", "validacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label2.Text = " Error";
                label2. ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("esto no es un numero", "Por favor, introduce solo caracteres numéricos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola mi nombre es Luis Alberto Diaz Ramirez LR-2024-01939");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            string fechaFormateada = fecha.ToString("yyyy-MM-dd");
            label3.Text = "Fecha seleccionada: " + fechaFormateada;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            double celcius;
            double fahrenheit;
            if (double.TryParse(textBox2.Text, out celcius))
            {
                fahrenheit = (celcius * 9.0 / 5.0) + 32;
                label6.Text = fahrenheit.ToString("n1");
            }
            else
            {
                label4.Text = "entrada valida";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
                progreso = 0;
            }
            timer1.Start();
            button6.Enabled = false; button7.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
              button6.Enabled = true; button7.Enabled = false; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progreso += incremento;
            progressBar1.Value = progreso;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
