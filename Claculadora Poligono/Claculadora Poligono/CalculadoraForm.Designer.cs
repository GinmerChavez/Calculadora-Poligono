namespace Claculadora_Poligono
{
    partial class CalculadoraPoligonosForm1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulolabel = new System.Windows.Forms.Label();
            this.calcularPerimetrobutton = new System.Windows.Forms.Button();
            this.calcularAreabutton = new System.Windows.Forms.Button();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.cuadradoTabPage = new System.Windows.Forms.TabPage();
            this.trianguloTabPage = new System.Windows.Forms.TabPage();
            this.PrincipaltabControl = new System.Windows.Forms.TabControl();
            this.Lado1 = new System.Windows.Forms.Label();
            this.Lado2 = new System.Windows.Forms.Label();
            this.Lado3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Base = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.Lado = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.Radio = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.Altura2 = new System.Windows.Forms.Label();
            this.Base2 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.NumeroLado = new System.Windows.Forms.Label();
            this.Apotema = new System.Windows.Forms.Label();
            this.Lado4 = new System.Windows.Forms.Label();
            this.pentagonoTabPage.SuspendLayout();
            this.rectanguloTabPage.SuspendLayout();
            this.circuloTabPage.SuspendLayout();
            this.cuadradoTabPage.SuspendLayout();
            this.trianguloTabPage.SuspendLayout();
            this.PrincipaltabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulolabel
            // 
            this.titulolabel.AutoSize = true;
            this.titulolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.titulolabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titulolabel.Location = new System.Drawing.Point(205, 29);
            this.titulolabel.Name = "titulolabel";
            this.titulolabel.Size = new System.Drawing.Size(365, 35);
            this.titulolabel.TabIndex = 7;
            this.titulolabel.Text = "Calculadora de Poligonos";
            // 
            // calcularPerimetrobutton
            // 
            this.calcularPerimetrobutton.Location = new System.Drawing.Point(493, 408);
            this.calcularPerimetrobutton.Name = "calcularPerimetrobutton";
            this.calcularPerimetrobutton.Size = new System.Drawing.Size(145, 23);
            this.calcularPerimetrobutton.TabIndex = 9;
            this.calcularPerimetrobutton.Text = "Calcular Perimetro";
            this.calcularPerimetrobutton.UseVisualStyleBackColor = true;
            this.calcularPerimetrobutton.Click += new System.EventHandler(this.calcularPerimetrobutton_Click);
            // 
            // calcularAreabutton
            // 
            this.calcularAreabutton.Location = new System.Drawing.Point(644, 408);
            this.calcularAreabutton.Name = "calcularAreabutton";
            this.calcularAreabutton.Size = new System.Drawing.Size(118, 23);
            this.calcularAreabutton.TabIndex = 10;
            this.calcularAreabutton.Text = "Calcular Area";
            this.calcularAreabutton.UseVisualStyleBackColor = true;
            // 
            // pentagonoTabPage
            // 
            this.pentagonoTabPage.Controls.Add(this.textBox23);
            this.pentagonoTabPage.Controls.Add(this.textBox24);
            this.pentagonoTabPage.Controls.Add(this.textBox25);
            this.pentagonoTabPage.Controls.Add(this.NumeroLado);
            this.pentagonoTabPage.Controls.Add(this.Apotema);
            this.pentagonoTabPage.Controls.Add(this.Lado4);
            this.pentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTabPage.Name = "pentagonoTabPage";
            this.pentagonoTabPage.Size = new System.Drawing.Size(756, 293);
            this.pentagonoTabPage.TabIndex = 4;
            this.pentagonoTabPage.Text = "Pentagono";
            this.pentagonoTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanguloTabPage
            // 
            this.rectanguloTabPage.Controls.Add(this.textBox19);
            this.rectanguloTabPage.Controls.Add(this.textBox20);
            this.rectanguloTabPage.Controls.Add(this.Altura2);
            this.rectanguloTabPage.Controls.Add(this.Base2);
            this.rectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanguloTabPage.Name = "rectanguloTabPage";
            this.rectanguloTabPage.Size = new System.Drawing.Size(756, 293);
            this.rectanguloTabPage.TabIndex = 3;
            this.rectanguloTabPage.Text = "Rectangulo";
            this.rectanguloTabPage.UseVisualStyleBackColor = true;
            // 
            // circuloTabPage
            // 
            this.circuloTabPage.Controls.Add(this.textBox15);
            this.circuloTabPage.Controls.Add(this.Radio);
            this.circuloTabPage.Location = new System.Drawing.Point(4, 22);
            this.circuloTabPage.Name = "circuloTabPage";
            this.circuloTabPage.Size = new System.Drawing.Size(756, 293);
            this.circuloTabPage.TabIndex = 2;
            this.circuloTabPage.Text = "Circulo";
            this.circuloTabPage.UseVisualStyleBackColor = true;
            // 
            // cuadradoTabPage
            // 
            this.cuadradoTabPage.Controls.Add(this.textBox10);
            this.cuadradoTabPage.Controls.Add(this.Lado);
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadradoTabPage.Size = new System.Drawing.Size(756, 293);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
            // 
            // trianguloTabPage
            // 
            this.trianguloTabPage.Controls.Add(this.textBox5);
            this.trianguloTabPage.Controls.Add(this.textBox4);
            this.trianguloTabPage.Controls.Add(this.Altura);
            this.trianguloTabPage.Controls.Add(this.Base);
            this.trianguloTabPage.Controls.Add(this.textBox3);
            this.trianguloTabPage.Controls.Add(this.textBox2);
            this.trianguloTabPage.Controls.Add(this.textBox1);
            this.trianguloTabPage.Controls.Add(this.Lado3);
            this.trianguloTabPage.Controls.Add(this.Lado2);
            this.trianguloTabPage.Controls.Add(this.Lado1);
            this.trianguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.trianguloTabPage.Name = "trianguloTabPage";
            this.trianguloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trianguloTabPage.Size = new System.Drawing.Size(756, 293);
            this.trianguloTabPage.TabIndex = 0;
            this.trianguloTabPage.Text = "Triangulo";
            this.trianguloTabPage.UseVisualStyleBackColor = true;
            this.trianguloTabPage.Click += new System.EventHandler(this.trianguloTabPage_Click);
            // 
            // PrincipaltabControl
            // 
            this.PrincipaltabControl.Controls.Add(this.trianguloTabPage);
            this.PrincipaltabControl.Controls.Add(this.cuadradoTabPage);
            this.PrincipaltabControl.Controls.Add(this.circuloTabPage);
            this.PrincipaltabControl.Controls.Add(this.rectanguloTabPage);
            this.PrincipaltabControl.Controls.Add(this.pentagonoTabPage);
            this.PrincipaltabControl.Location = new System.Drawing.Point(24, 83);
            this.PrincipaltabControl.Name = "PrincipaltabControl";
            this.PrincipaltabControl.SelectedIndex = 0;
            this.PrincipaltabControl.Size = new System.Drawing.Size(764, 319);
            this.PrincipaltabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.PrincipaltabControl.TabIndex = 8;
            // 
            // Lado1
            // 
            this.Lado1.AutoSize = true;
            this.Lado1.Location = new System.Drawing.Point(32, 22);
            this.Lado1.Name = "Lado1";
            this.Lado1.Size = new System.Drawing.Size(37, 13);
            this.Lado1.TabIndex = 0;
            this.Lado1.Text = "Lado1";
            this.Lado1.Click += new System.EventHandler(this.Lado1_Click);
            // 
            // Lado2
            // 
            this.Lado2.AutoSize = true;
            this.Lado2.Location = new System.Drawing.Point(32, 52);
            this.Lado2.Name = "Lado2";
            this.Lado2.Size = new System.Drawing.Size(37, 13);
            this.Lado2.TabIndex = 1;
            this.Lado2.Text = "Lado2";
            // 
            // Lado3
            // 
            this.Lado3.AutoSize = true;
            this.Lado3.Location = new System.Drawing.Point(32, 89);
            this.Lado3.Name = "Lado3";
            this.Lado3.Size = new System.Drawing.Size(37, 13);
            this.Lado3.TabIndex = 2;
            this.Lado3.Text = "Lado3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 5;
            // 
            // Base
            // 
            this.Base.AutoSize = true;
            this.Base.Location = new System.Drawing.Point(32, 128);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(31, 13);
            this.Base.TabIndex = 6;
            this.Base.Text = "Base";
            this.Base.Click += new System.EventHandler(this.Base_Click);
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(29, 166);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(34, 13);
            this.Altura.TabIndex = 7;
            this.Altura.Text = "Altura";
            this.Altura.Click += new System.EventHandler(this.Altura_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(174, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(111, 21);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(174, 20);
            this.textBox10.TabIndex = 13;
            // 
            // Lado
            // 
            this.Lado.AutoSize = true;
            this.Lado.Location = new System.Drawing.Point(25, 28);
            this.Lado.Name = "Lado";
            this.Lado.Size = new System.Drawing.Size(31, 13);
            this.Lado.TabIndex = 10;
            this.Lado.Text = "Lado";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(111, 29);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(174, 20);
            this.textBox15.TabIndex = 13;
            // 
            // Radio
            // 
            this.Radio.AutoSize = true;
            this.Radio.Location = new System.Drawing.Point(25, 36);
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(35, 13);
            this.Radio.TabIndex = 10;
            this.Radio.Text = "Radio";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(131, 55);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(174, 20);
            this.textBox19.TabIndex = 14;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(131, 21);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(174, 20);
            this.textBox20.TabIndex = 13;
            // 
            // Altura2
            // 
            this.Altura2.AutoSize = true;
            this.Altura2.Location = new System.Drawing.Point(45, 58);
            this.Altura2.Name = "Altura2";
            this.Altura2.Size = new System.Drawing.Size(34, 13);
            this.Altura2.TabIndex = 11;
            this.Altura2.Text = "Altura";
            // 
            // Base2
            // 
            this.Base2.AutoSize = true;
            this.Base2.Location = new System.Drawing.Point(45, 28);
            this.Base2.Name = "Base2";
            this.Base2.Size = new System.Drawing.Size(31, 13);
            this.Base2.TabIndex = 10;
            this.Base2.Text = "Base";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(157, 98);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(174, 20);
            this.textBox23.TabIndex = 15;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(157, 65);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(174, 20);
            this.textBox24.TabIndex = 14;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(157, 31);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(174, 20);
            this.textBox25.TabIndex = 13;
            // 
            // NumeroLado
            // 
            this.NumeroLado.AutoSize = true;
            this.NumeroLado.Location = new System.Drawing.Point(28, 98);
            this.NumeroLado.Name = "NumeroLado";
            this.NumeroLado.Size = new System.Drawing.Size(94, 13);
            this.NumeroLado.TabIndex = 12;
            this.NumeroLado.Text = "Numrero de Lados";
            // 
            // Apotema
            // 
            this.Apotema.AutoSize = true;
            this.Apotema.Location = new System.Drawing.Point(28, 61);
            this.Apotema.Name = "Apotema";
            this.Apotema.Size = new System.Drawing.Size(49, 13);
            this.Apotema.TabIndex = 11;
            this.Apotema.Text = "Apotema";
            // 
            // Lado4
            // 
            this.Lado4.AutoSize = true;
            this.Lado4.Location = new System.Drawing.Point(28, 31);
            this.Lado4.Name = "Lado4";
            this.Lado4.Size = new System.Drawing.Size(31, 13);
            this.Lado4.TabIndex = 10;
            this.Lado4.Text = "Lado";
            // 
            // CalculadoraPoligonosForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(792, 433);
            this.Controls.Add(this.PrincipaltabControl);
            this.Controls.Add(this.calcularAreabutton);
            this.Controls.Add(this.calcularPerimetrobutton);
            this.Controls.Add(this.titulolabel);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "CalculadoraPoligonosForm1";
            this.Text = "Calculadora de Poligonos";
            this.Load += new System.EventHandler(this.CalculadoraPoligonosForm1_Load);
            this.pentagonoTabPage.ResumeLayout(false);
            this.pentagonoTabPage.PerformLayout();
            this.rectanguloTabPage.ResumeLayout(false);
            this.rectanguloTabPage.PerformLayout();
            this.circuloTabPage.ResumeLayout(false);
            this.circuloTabPage.PerformLayout();
            this.cuadradoTabPage.ResumeLayout(false);
            this.cuadradoTabPage.PerformLayout();
            this.trianguloTabPage.ResumeLayout(false);
            this.trianguloTabPage.PerformLayout();
            this.PrincipaltabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulolabel;
        private System.Windows.Forms.Button calcularPerimetrobutton;
        private System.Windows.Forms.Button calcularAreabutton;
        private System.Windows.Forms.TabPage pentagonoTabPage;
        private System.Windows.Forms.TabPage rectanguloTabPage;
        private System.Windows.Forms.TabPage circuloTabPage;
        private System.Windows.Forms.TabPage cuadradoTabPage;
        private System.Windows.Forms.TabPage trianguloTabPage;
        private System.Windows.Forms.TabControl PrincipaltabControl;
        private System.Windows.Forms.Label Lado1;
        private System.Windows.Forms.Label Lado3;
        private System.Windows.Forms.Label Lado2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.Label Base;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label NumeroLado;
        private System.Windows.Forms.Label Apotema;
        private System.Windows.Forms.Label Lado4;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label Altura2;
        private System.Windows.Forms.Label Base2;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label Radio;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label Lado;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}

