using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int totalSegundos;
        private bool temporizadorIniciado = false;
        public Form1()
        {
            InitializeComponent();
            lblTiempo.Text = "00:00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();


            if (int.TryParse(textBox1.Text, out int numero))
            {

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;

                    string itemTabla = $"{numero} x {i} = {resultado}";

                    listBox1.Items.Add(itemTabla);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!temporizadorIniciado)
            {

                totalSegundos = (int)nudMinutos.Value * 60 + (int)nudSegundos.Value;
                if (totalSegundos > 0)
                {
                    tmrTemporizador.Start();
                    tmrTemporizador.Enabled = true;
                    btnIniciar.Text = "Detener";
                    temporizadorIniciado = true;

                    nudMinutos.Enabled = false;
                    nudSegundos.Enabled = false;

                }
            }
        }

        private void cmbUnidadEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUnidadEntrada.Items.Add("Metros");
            cmbUnidadEntrada.Items.Add("Centímetros");
            cmbUnidadEntrada.Items.Add("Pulgadas");
            
            cmbUnidadEntrada.SelectedIndex = 0; 
        }

        private void cmbUnidadSalida_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUnidadSalida.Items.Add("Metros");
            cmbUnidadSalida.Items.Add("Centímetros");
            cmbUnidadSalida.Items.Add("Pulgadas");
            cmbUnidadSalida.SelectedIndex = 1; 
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValor.Text, out double valor)) 
            {
                string unidadEntrada = cmbUnidadEntrada.SelectedItem.ToString();
                string unidadSalida = cmbUnidadSalida.SelectedItem.ToString();
                double resultado = 0;

                
                switch (unidadEntrada)
                {
                    case "Metros": valor = valor; break;
                    case "Centímetros": valor = valor / 100; break;
                    case "Pulgadas": valor = valor * 0.0254; break; 
                }

               
                switch (unidadSalida)
                {
                    case "Metros": resultado = valor; break;
                    case "Centímetros": resultado = valor * 100; break;
                    case "Pulgadas": resultado = valor / 0.0254; break;
                }

                txtResultado.Text = resultado.ToString("F4"); 
            }
            else
            {
                MessageBox.Show("Por favor, introduce un número válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string texto = txtPalabra.Text;
            if (EsPalindromo(texto))
            {
                MessageBox.Show($"'{texto}' ¡SÍ es un palíndromo!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"'{texto}' NO es un palíndromo.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
        private bool EsPalindromo(string palabra)
        {
           
            string palabraLimpia = new string(palabra.ToLower().Where(char.IsLetterOrDigit).ToArray());
           
            
            char[] charArray = palabraLimpia.ToCharArray();
            Array.Reverse(charArray);
            string palabraInvertida = new string(charArray);

           
            return palabraLimpia == palabraInvertida;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
          
            string oracion = txtOracion.Text;

         
            string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            
            int numeroDePalabras = palabras.Length;

           
            lblResultado.Text = $"Número de palabras: {numeroDePalabras}";
        

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
