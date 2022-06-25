namespace LANDRS
{
    partial class Calcular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cajaIntervalos = new System.Windows.Forms.TextBox();
            this.cajaDistancia = new System.Windows.Forms.TextBox();
            this.panelScr = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cajaIntervalos
            // 
            this.cajaIntervalos.Location = new System.Drawing.Point(279, 71);
            this.cajaIntervalos.Name = "cajaIntervalos";
            this.cajaIntervalos.Size = new System.Drawing.Size(125, 27);
            this.cajaIntervalos.TabIndex = 0;
            // 
            // cajaDistancia
            // 
            this.cajaDistancia.Location = new System.Drawing.Point(279, 144);
            this.cajaDistancia.Name = "cajaDistancia";
            this.cajaDistancia.Size = new System.Drawing.Size(125, 27);
            this.cajaDistancia.TabIndex = 1;
            // 
            // panelScr
            // 
            this.panelScr.AutoScroll = true;
            this.panelScr.Location = new System.Drawing.Point(101, 231);
            this.panelScr.Name = "panelScr";
            this.panelScr.Size = new System.Drawing.Size(469, 243);
            this.panelScr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresa Numero Intervalos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresa Distancia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(595, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 576);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelScr);
            this.Controls.Add(this.cajaDistancia);
            this.Controls.Add(this.cajaIntervalos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calcular";
            this.Text = "Calcular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox cajaIntervalos;
        private TextBox cajaDistancia;
        private FlowLayoutPanel panelScr;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}