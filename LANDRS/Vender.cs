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
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(textBox1.Text);
            string direccion = textBox2.Text;
            double area = double.Parse(textBox3.Text);
            StreamWriter fichero;
            string ruta = @"D:\Archivos\terrenos.txt";
            fichero = File.AppendText(ruta);
            fichero.WriteLine(precio);
            fichero.WriteLine(direccion);
            fichero.WriteLine(area);
            fichero.Close();
        }
    }
}
