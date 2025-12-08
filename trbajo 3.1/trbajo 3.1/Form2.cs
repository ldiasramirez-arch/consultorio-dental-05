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
    public partial class Form2 : Form
    {
        private int contador = 0;
        public Form2()
        {
            InitializeComponent();
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            label1.Text = contador.ToString();
        }
    }
}
