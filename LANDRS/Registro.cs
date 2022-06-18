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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;
            string ruta = @"D:\Archivos\usuarios.txt";
            fichero = File.AppendText(ruta);
            fichero.WriteLine(textBox1.Text);
            fichero.WriteLine(textBox2.Text);
            fichero.Close();

            Form1 obj=new Form1();
            obj.Show();
            this.Hide();

        }
    }
}
