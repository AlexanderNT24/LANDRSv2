using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LANDRS
{
    public partial class Comprar : Form
    {
        public Comprar()
        {
            InitializeComponent();
        }
        ArrayList arrList = new ArrayList();
        private void Comprar_Load(object sender, EventArgs e)
        {

            

            StreamReader obj;
            string ruta = @"D:\Archivos\terrenos.txt";
            obj = new StreamReader(ruta);
            string contenido = obj.ReadToEnd();
            obj.Close();
            string[] arrayContenido = contenido.Trim().Split('\n');
            for (int i = 0; i < arrayContenido.Length; i += 3)
            {
                Terrenos ob=new Terrenos();
                ob.Area =double.Parse(arrayContenido[i]);
                ob.Ubicacion = arrayContenido[i+1];
                ob.Precio = double.Parse(arrayContenido[i+2]);
                
                arrList.Add(ob);
            }

            foreach (Terrenos item in arrList)
            {
                Panel panel = new Panel();
                panel.Width = 900;
                panel.Height = 250;
                panel.Top = 0;
                panel.Left = 0;
                panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
                panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                panelScr1.Controls.Add(panel);

                Label labelUbicacion = new Label();
                labelUbicacion.Text = "Ubicacion: " + item.Ubicacion;
                labelUbicacion.Width = 800;
                labelUbicacion.Height = 30;
                labelUbicacion.Top = 10;
                labelUbicacion.Left = 0;
                labelUbicacion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                panel.Controls.Add(labelUbicacion);
                Label labelPrecio = new Label();
                labelPrecio.Text = "Precio: S/" + item.Precio;
                labelPrecio.Width = 800;
                labelPrecio.Height = 30;
                labelPrecio.Top = 60;
                labelPrecio.Left = 0;
                labelPrecio.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                panel.Controls.Add(labelPrecio);
                Label labelArea = new Label();
                labelArea.Text = "Area: " + item.Area + " km";
                labelArea.Width = 800;
                labelArea.Height = 30;
                labelArea.Top = 110;
                labelArea.Left = 0;
                labelArea.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                panel.Controls.Add(labelArea);
            
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprar));
                Button button = new Button();
                button.Text = "Comprar ";
                button.Width = 100;
                button.Height = 50;
                button.Top = 200;
                button.Left = 800;
                button.Click += (sender, e) => comprar(sender, e, item);
                panel.Controls.Add(button);
                

            }
        }
        private void comprar(object sender, EventArgs e, object obj)
        {
            arrList.Remove(obj);
            
            StreamWriter fichero;
            string ruta = @"D:\Archivos\terrenos.txt";
            fichero = File.CreateText(ruta);
            foreach (Terrenos item in arrList)
            {
                fichero.WriteLine(item.Precio);
                fichero.WriteLine(item.Ubicacion);
                fichero.WriteLine(item.Area);
                


            }
            arrList.Clear();
            fichero.Close();
            this.Controls.Clear();
            InitializeComponent();
            
            Comprar_Load(sender, e);
        }

    }
    }

