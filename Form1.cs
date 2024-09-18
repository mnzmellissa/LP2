using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // recebe valor de altura e raio
            if (!double.TryParse(txtRaio.Text, out double raio) || !double.TryParse(txtAltura.Text, out double altura))
            {
                MessageBox.Show("insira valores numéricos para o raio e altura.");
                return;
            }

            //  volume
            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            //  resultado
            txtVolume.Text = volume.ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

