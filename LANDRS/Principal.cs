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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void abrirFormularioHijo(object formulario)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form formularioHijo = formulario as Form;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Vender());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Comprar());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new Calcular());
        }
    }
}
