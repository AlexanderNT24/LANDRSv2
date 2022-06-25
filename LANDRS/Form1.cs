using System.Diagnostics;

namespace LANDRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Registro obj=new Registro();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader obj;
            string ruta = @"D:\Archivos\usuarios.txt";
            obj = new StreamReader(ruta);
            string contenido = obj.ReadToEnd();
            obj.Close();

            string[] arrayContenido = contenido.Trim().Split('\n');

            for (int i = 0; i < arrayContenido.Length; i += 2)
            {

                if (arrayContenido[i].Contains(textBox1.Text))
                {
                   
                    if (arrayContenido[i + 1].Contains(textBox2.Text))
                    {
                        Principal objVentana=new Principal();
                        objVentana.Show();
                        this.Hide();
                        break;
                    }
                }

            }

        }
    }
}