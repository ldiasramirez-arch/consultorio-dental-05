using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trbajo_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = " saludos texto cambiado";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, suma;
            
            num1 = int.Parse(textBox2.Text);
            num2 = int.Parse(textBox3.Text);
            suma = num1 + num2;
            label4.Text = suma.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label5.Text = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                label5.Text = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                label5.Text = radioButton3.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorSeleccionado = comboBox1.SelectedItem.ToString();

            switch (colorSeleccionado)
            {
                case "Rojo":
                    this.BackColor = Color.Red;
                    break;
                case "Verde":
                    this.BackColor = Color.Green;
                    break;
                case "Azul":
                    this.BackColor = Color.Blue;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string textoingresado = textBox4.Text;
            listBox1.Items.Add(textoingresado);
            textBox4.Clear();
        }
    }       
}
