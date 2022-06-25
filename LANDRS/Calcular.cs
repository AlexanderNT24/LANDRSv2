using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LANDRS
{
    public partial class Calcular : Form
    {
        public Calcular()
        {
            InitializeComponent();
        }
        double[] intervalos;
        private void button1_Click(object sender, EventArgs e)
        {
            int numeroIntervalos = Convert.ToInt32(cajaIntervalos.Text);
            intervalos = new double[numeroIntervalos];
            for (int i = 0; i < numeroIntervalos; i++)
            {
                TextBox textBox = new TextBox();
                int codigo = i;
                string placeholder = "Intervalo N°" + (i + 1).ToString();
                textBox.PlaceholderText = placeholder;
                textBox.Width = 100;
                textBox.Height = 20;
                textBox.Top = 0;
                textBox.Font = new System.Drawing.Font("Century Gothic", 8, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                textBox.Left = 0;
                textBox.TextChanged += (sender, e) => vector(sender, e, codigo);
                panelScr.Controls.Add(textBox);
            }
            button1.Enabled = false;
            button2.Visible = true;
        }
        private void vector(object sender, EventArgs e, int numero)
        {

            intervalos[numero] = Convert.ToDouble(sender.ToString().Replace("System.Windows.Forms.TextBox, Text:", ""));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numeroIntervalos = Convert.ToInt32(cajaIntervalos.Text);
            double distanciaIntervalos = Convert.ToDouble(cajaDistancia.Text);
            double areaAproximada = 0;

            for (int i = 0; i < numeroIntervalos; i++)
            {
                areaAproximada = (2 * intervalos[i]) + areaAproximada;
            }
            areaAproximada = areaAproximada * (distanciaIntervalos / 2);


            label3.Text = "El area aproximada es:" + areaAproximada;
            label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

        }
    }
}
