namespace Claculadora_Poligono
{
    partial class CalculadoraForm
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
            this.components = new System.ComponentModel.Container();
            this.CalculadoraPoligonoText = new System.Windows.Forms.Label();
            this.calcularPerimetrobutton = new System.Windows.Forms.Button();
            this.calcularAreabutton = new System.Windows.Forms.Button();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.pentagononumeroLadoTextBox = new System.Windows.Forms.TextBox();
            this.pentagonoApotemaTextBox = new System.Windows.Forms.TextBox();
            this.pentagonoLadoTextBox = new System.Windows.Forms.TextBox();
            this.PentagonoNumeroLado = new System.Windows.Forms.Label();
            this.PentagonoApotema = new System.Windows.Forms.Label();
            this.PentagonoLado = new System.Windows.Forms.Label();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.RectanguloAlturaTextBox = new System.Windows.Forms.TextBox();
            this.RectanguloBaseTextBox = new System.Windows.Forms.TextBox();
            this.RectanguloAltura = new System.Windows.Forms.Label();
            this.RectanguloBase = new System.Windows.Forms.Label();
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.circuloRadiotextBox = new System.Windows.Forms.TextBox();
            this.CirculoRadio = new System.Windows.Forms.Label();
            this.cuadradoTabPage = new System.Windows.Forms.TabPage();
            this.CuadradoLadotextBox = new System.Windows.Forms.TextBox();
            this.CuadradoLado = new System.Windows.Forms.Label();
            this.trianguloTabPage = new System.Windows.Forms.TabPage();
            this.TrianguloAlturaTextBox = new System.Windows.Forms.TextBox();
            this.TrianguloBaseTextBox = new System.Windows.Forms.TextBox();
            this.TrianguloAltura = new System.Windows.Forms.Label();
            this.TrianguloBase = new System.Windows.Forms.Label();
            this.TrianguloLado3TextBox = new System.Windows.Forms.TextBox();
            this.TrianguloLado2TextBox = new System.Windows.Forms.TextBox();
            this.TrianguloLado1TextBox = new System.Windows.Forms.TextBox();
            this.TrianguloLado3 = new System.Windows.Forms.Label();
            this.TrianguloLado2 = new System.Windows.Forms.Label();
            this.TrianguloLado1 = new System.Windows.Forms.Label();
            this.PrincipaltabControl = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pentagonoTabPage.SuspendLayout();
            this.rectanguloTabPage.SuspendLayout();
            this.circuloTabPage.SuspendLayout();
            this.cuadradoTabPage.SuspendLayout();
            this.trianguloTabPage.SuspendLayout();
            this.PrincipaltabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculadoraPoligonoText
            // 
            this.CalculadoraPoligonoText.AutoSize = true;
            this.CalculadoraPoligonoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F);
            this.CalculadoraPoligonoText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculadoraPoligonoText.Location = new System.Drawing.Point(205, 29);
            this.CalculadoraPoligonoText.Name = "CalculadoraPoligonoText";
            this.CalculadoraPoligonoText.Size = new System.Drawing.Size(365, 35);
            this.CalculadoraPoligonoText.TabIndex = 7;
            this.CalculadoraPoligonoText.Text = "Calculadora de Poligonos";
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
            this.pentagonoTabPage.Controls.Add(this.pentagononumeroLadoTextBox);
            this.pentagonoTabPage.Controls.Add(this.pentagonoApotemaTextBox);
            this.pentagonoTabPage.Controls.Add(this.pentagonoLadoTextBox);
            this.pentagonoTabPage.Controls.Add(this.PentagonoNumeroLado);
            this.pentagonoTabPage.Controls.Add(this.PentagonoApotema);
            this.pentagonoTabPage.Controls.Add(this.PentagonoLado);
            this.pentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTabPage.Name = "pentagonoTabPage";
            this.pentagonoTabPage.Size = new System.Drawing.Size(756, 293);
            this.pentagonoTabPage.TabIndex = 4;
            this.pentagonoTabPage.Text = "Pentagono";
            this.pentagonoTabPage.UseVisualStyleBackColor = true;
            // 
            // pentagononumeroLadoTextBox
            // 
            this.pentagononumeroLadoTextBox.Location = new System.Drawing.Point(157, 98);
            this.pentagononumeroLadoTextBox.Name = "pentagononumeroLadoTextBox";
            this.pentagononumeroLadoTextBox.Size = new System.Drawing.Size(174, 20);
            this.pentagononumeroLadoTextBox.TabIndex = 15;
            this.pentagononumeroLadoTextBox.Leave += new System.EventHandler(this.pentagononumeroLadoTextBox_Leave);
            // 
            // pentagonoApotemaTextBox
            // 
            this.pentagonoApotemaTextBox.Location = new System.Drawing.Point(157, 65);
            this.pentagonoApotemaTextBox.Name = "pentagonoApotemaTextBox";
            this.pentagonoApotemaTextBox.Size = new System.Drawing.Size(174, 20);
            this.pentagonoApotemaTextBox.TabIndex = 14;
            this.pentagonoApotemaTextBox.Leave += new System.EventHandler(this.pentagonoApotemaTextBox_Leave);
            // 
            // pentagonoLadoTextBox
            // 
            this.pentagonoLadoTextBox.Location = new System.Drawing.Point(157, 31);
            this.pentagonoLadoTextBox.Name = "pentagonoLadoTextBox";
            this.pentagonoLadoTextBox.Size = new System.Drawing.Size(174, 20);
            this.pentagonoLadoTextBox.TabIndex = 13;
            this.pentagonoLadoTextBox.Leave += new System.EventHandler(this.pentagonoLadoTextBox_Leave);
            // 
            // PentagonoNumeroLado
            // 
            this.PentagonoNumeroLado.AutoSize = true;
            this.PentagonoNumeroLado.Location = new System.Drawing.Point(28, 98);
            this.PentagonoNumeroLado.Name = "PentagonoNumeroLado";
            this.PentagonoNumeroLado.Size = new System.Drawing.Size(94, 13);
            this.PentagonoNumeroLado.TabIndex = 12;
            this.PentagonoNumeroLado.Text = "Numrero de Lados";
            // 
            // PentagonoApotema
            // 
            this.PentagonoApotema.AutoSize = true;
            this.PentagonoApotema.Location = new System.Drawing.Point(28, 61);
            this.PentagonoApotema.Name = "PentagonoApotema";
            this.PentagonoApotema.Size = new System.Drawing.Size(49, 13);
            this.PentagonoApotema.TabIndex = 11;
            this.PentagonoApotema.Text = "Apotema";
            // 
            // PentagonoLado
            // 
            this.PentagonoLado.AutoSize = true;
            this.PentagonoLado.Location = new System.Drawing.Point(28, 31);
            this.PentagonoLado.Name = "PentagonoLado";
            this.PentagonoLado.Size = new System.Drawing.Size(31, 13);
            this.PentagonoLado.TabIndex = 10;
            this.PentagonoLado.Text = "Lado";
            // 
            // rectanguloTabPage
            // 
            this.rectanguloTabPage.Controls.Add(this.RectanguloAlturaTextBox);
            this.rectanguloTabPage.Controls.Add(this.RectanguloBaseTextBox);
            this.rectanguloTabPage.Controls.Add(this.RectanguloAltura);
            this.rectanguloTabPage.Controls.Add(this.RectanguloBase);
            this.rectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanguloTabPage.Name = "rectanguloTabPage";
            this.rectanguloTabPage.Size = new System.Drawing.Size(756, 293);
            this.rectanguloTabPage.TabIndex = 3;
            this.rectanguloTabPage.Text = "Rectangulo";
            this.rectanguloTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanguloAlturaTextBox
            // 
            this.RectanguloAlturaTextBox.Location = new System.Drawing.Point(131, 55);
            this.RectanguloAlturaTextBox.Name = "RectanguloAlturaTextBox";
            this.RectanguloAlturaTextBox.Size = new System.Drawing.Size(174, 20);
            this.RectanguloAlturaTextBox.TabIndex = 14;
            this.RectanguloAlturaTextBox.Leave += new System.EventHandler(this.RectanguloAlturaTextBox_Leave);
            // 
            // RectanguloBaseTextBox
            // 
            this.RectanguloBaseTextBox.Location = new System.Drawing.Point(131, 21);
            this.RectanguloBaseTextBox.Name = "RectanguloBaseTextBox";
            this.RectanguloBaseTextBox.Size = new System.Drawing.Size(174, 20);
            this.RectanguloBaseTextBox.TabIndex = 13;
            this.RectanguloBaseTextBox.Leave += new System.EventHandler(this.RectanguloBaseTextBox_Leave);
            // 
            // RectanguloAltura
            // 
            this.RectanguloAltura.AutoSize = true;
            this.RectanguloAltura.Location = new System.Drawing.Point(45, 58);
            this.RectanguloAltura.Name = "RectanguloAltura";
            this.RectanguloAltura.Size = new System.Drawing.Size(34, 13);
            this.RectanguloAltura.TabIndex = 11;
            this.RectanguloAltura.Text = "Altura";
            // 
            // RectanguloBase
            // 
            this.RectanguloBase.AutoSize = true;
            this.RectanguloBase.Location = new System.Drawing.Point(45, 28);
            this.RectanguloBase.Name = "RectanguloBase";
            this.RectanguloBase.Size = new System.Drawing.Size(31, 13);
            this.RectanguloBase.TabIndex = 10;
            this.RectanguloBase.Text = "Base";
            // 
            // circuloTabPage
            // 
            this.circuloTabPage.Controls.Add(this.circuloRadiotextBox);
            this.circuloTabPage.Controls.Add(this.CirculoRadio);
            this.circuloTabPage.Location = new System.Drawing.Point(4, 22);
            this.circuloTabPage.Name = "circuloTabPage";
            this.circuloTabPage.Size = new System.Drawing.Size(756, 293);
            this.circuloTabPage.TabIndex = 2;
            this.circuloTabPage.Text = "Circulo";
            this.circuloTabPage.UseVisualStyleBackColor = true;
            // 
            // circuloRadiotextBox
            // 
            this.circuloRadiotextBox.Location = new System.Drawing.Point(111, 29);
            this.circuloRadiotextBox.Name = "circuloRadiotextBox";
            this.circuloRadiotextBox.Size = new System.Drawing.Size(174, 20);
            this.circuloRadiotextBox.TabIndex = 13;
            this.circuloRadiotextBox.Leave += new System.EventHandler(this.circuloRadiotextBox_Leave);
            // 
            // CirculoRadio
            // 
            this.CirculoRadio.AutoSize = true;
            this.CirculoRadio.Location = new System.Drawing.Point(25, 36);
            this.CirculoRadio.Name = "CirculoRadio";
            this.CirculoRadio.Size = new System.Drawing.Size(35, 13);
            this.CirculoRadio.TabIndex = 10;
            this.CirculoRadio.Text = "Radio";
            // 
            // cuadradoTabPage
            // 
            this.cuadradoTabPage.Controls.Add(this.CuadradoLadotextBox);
            this.cuadradoTabPage.Controls.Add(this.CuadradoLado);
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadradoTabPage.Size = new System.Drawing.Size(756, 293);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
            // 
            // CuadradoLadotextBox
            // 
            this.CuadradoLadotextBox.Location = new System.Drawing.Point(111, 21);
            this.CuadradoLadotextBox.Name = "CuadradoLadotextBox";
            this.CuadradoLadotextBox.Size = new System.Drawing.Size(174, 20);
            this.CuadradoLadotextBox.TabIndex = 13;
            this.CuadradoLadotextBox.Leave += new System.EventHandler(this.CuadradoLadotextBox_Leave);
            // 
            // CuadradoLado
            // 
            this.CuadradoLado.AutoSize = true;
            this.CuadradoLado.Location = new System.Drawing.Point(25, 28);
            this.CuadradoLado.Name = "CuadradoLado";
            this.CuadradoLado.Size = new System.Drawing.Size(31, 13);
            this.CuadradoLado.TabIndex = 10;
            this.CuadradoLado.Text = "Lado";
            // 
            // trianguloTabPage
            // 
            this.trianguloTabPage.Controls.Add(this.TrianguloAlturaTextBox);
            this.trianguloTabPage.Controls.Add(this.TrianguloBaseTextBox);
            this.trianguloTabPage.Controls.Add(this.TrianguloAltura);
            this.trianguloTabPage.Controls.Add(this.TrianguloBase);
            this.trianguloTabPage.Controls.Add(this.TrianguloLado3TextBox);
            this.trianguloTabPage.Controls.Add(this.TrianguloLado2TextBox);
            this.trianguloTabPage.Controls.Add(this.TrianguloLado1TextBox);
            this.trianguloTabPage.Controls.Add(this.TrianguloLado3);
            this.trianguloTabPage.Controls.Add(this.TrianguloLado2);
            this.trianguloTabPage.Controls.Add(this.TrianguloLado1);
            this.trianguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.trianguloTabPage.Name = "trianguloTabPage";
            this.trianguloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trianguloTabPage.Size = new System.Drawing.Size(756, 293);
            this.trianguloTabPage.TabIndex = 0;
            this.trianguloTabPage.Text = "Triangulo";
            this.trianguloTabPage.UseVisualStyleBackColor = true;
            // 
            // TrianguloAlturaTextBox
            // 
            this.TrianguloAlturaTextBox.Location = new System.Drawing.Point(118, 166);
            this.TrianguloAlturaTextBox.Name = "TrianguloAlturaTextBox";
            this.TrianguloAlturaTextBox.Size = new System.Drawing.Size(174, 20);
            this.TrianguloAlturaTextBox.TabIndex = 9;
            this.TrianguloAlturaTextBox.Leave += new System.EventHandler(this.TrianguloAlturaTextBox_Leave);
            // 
            // TrianguloBaseTextBox
            // 
            this.TrianguloBaseTextBox.Location = new System.Drawing.Point(118, 125);
            this.TrianguloBaseTextBox.Name = "TrianguloBaseTextBox";
            this.TrianguloBaseTextBox.Size = new System.Drawing.Size(174, 20);
            this.TrianguloBaseTextBox.TabIndex = 8;
            this.TrianguloBaseTextBox.Leave += new System.EventHandler(this.TrianguloBaseTextBox_Leave);
            // 
            // TrianguloAltura
            // 
            this.TrianguloAltura.AutoSize = true;
            this.TrianguloAltura.Location = new System.Drawing.Point(29, 166);
            this.TrianguloAltura.Name = "TrianguloAltura";
            this.TrianguloAltura.Size = new System.Drawing.Size(34, 13);
            this.TrianguloAltura.TabIndex = 7;
            this.TrianguloAltura.Text = "Altura";
            // 
            // TrianguloBase
            // 
            this.TrianguloBase.AutoSize = true;
            this.TrianguloBase.Location = new System.Drawing.Point(32, 128);
            this.TrianguloBase.Name = "TrianguloBase";
            this.TrianguloBase.Size = new System.Drawing.Size(31, 13);
            this.TrianguloBase.TabIndex = 6;
            this.TrianguloBase.Text = "Base";
            // 
            // TrianguloLado3TextBox
            // 
            this.TrianguloLado3TextBox.Location = new System.Drawing.Point(118, 82);
            this.TrianguloLado3TextBox.Name = "TrianguloLado3TextBox";
            this.TrianguloLado3TextBox.Size = new System.Drawing.Size(174, 20);
            this.TrianguloLado3TextBox.TabIndex = 5;
            this.TrianguloLado3TextBox.Leave += new System.EventHandler(this.TrianguloLado3TextBox_Leave);
            // 
            // TrianguloLado2TextBox
            // 
            this.TrianguloLado2TextBox.Location = new System.Drawing.Point(118, 49);
            this.TrianguloLado2TextBox.Name = "TrianguloLado2TextBox";
            this.TrianguloLado2TextBox.Size = new System.Drawing.Size(174, 20);
            this.TrianguloLado2TextBox.TabIndex = 4;
            this.TrianguloLado2TextBox.Leave += new System.EventHandler(this.TrianguloLado2TextBox_Leave);
            // 
            // TrianguloLado1TextBox
            // 
            this.TrianguloLado1TextBox.Location = new System.Drawing.Point(118, 15);
            this.TrianguloLado1TextBox.Name = "TrianguloLado1TextBox";
            this.TrianguloLado1TextBox.Size = new System.Drawing.Size(174, 20);
            this.TrianguloLado1TextBox.TabIndex = 3;
            this.TrianguloLado1TextBox.Leave += new System.EventHandler(this.TrianguloLado1TextBox_Leave);
            // 
            // TrianguloLado3
            // 
            this.TrianguloLado3.AutoSize = true;
            this.TrianguloLado3.Location = new System.Drawing.Point(32, 89);
            this.TrianguloLado3.Name = "TrianguloLado3";
            this.TrianguloLado3.Size = new System.Drawing.Size(37, 13);
            this.TrianguloLado3.TabIndex = 2;
            this.TrianguloLado3.Text = "Lado3";
            // 
            // TrianguloLado2
            // 
            this.TrianguloLado2.AutoSize = true;
            this.TrianguloLado2.Location = new System.Drawing.Point(32, 52);
            this.TrianguloLado2.Name = "TrianguloLado2";
            this.TrianguloLado2.Size = new System.Drawing.Size(37, 13);
            this.TrianguloLado2.TabIndex = 1;
            this.TrianguloLado2.Text = "Lado2";
            // 
            // TrianguloLado1
            // 
            this.TrianguloLado1.AutoSize = true;
            this.TrianguloLado1.Location = new System.Drawing.Point(32, 22);
            this.TrianguloLado1.Name = "TrianguloLado1";
            this.TrianguloLado1.Size = new System.Drawing.Size(37, 13);
            this.TrianguloLado1.TabIndex = 0;
            this.TrianguloLado1.Text = "Lado1";
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
            this.PrincipaltabControl.SelectedIndexChanged += new System.EventHandler(this.PrincipaltabControl_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CalculadoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(792, 433);
            this.Controls.Add(this.PrincipaltabControl);
            this.Controls.Add(this.calcularAreabutton);
            this.Controls.Add(this.calcularPerimetrobutton);
            this.Controls.Add(this.CalculadoraPoligonoText);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "CalculadoraForm";
            this.Text = "Calculadora de Poligonos";
            this.Load += new System.EventHandler(this.CalculadoraForm_Load);
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
        private System.Windows.Forms.Label CalculadoraPoligonoText;
        private System.Windows.Forms.Button calcularPerimetrobutton;
        private System.Windows.Forms.Button calcularAreabutton;
        private System.Windows.Forms.TabPage pentagonoTabPage;
        private System.Windows.Forms.TabPage rectanguloTabPage;
        private System.Windows.Forms.TabPage circuloTabPage;
        private System.Windows.Forms.TabPage cuadradoTabPage;
        private System.Windows.Forms.TabPage trianguloTabPage;
        private System.Windows.Forms.TabControl PrincipaltabControl;
        private System.Windows.Forms.Label TrianguloLado1;
        private System.Windows.Forms.Label TrianguloLado3;
        private System.Windows.Forms.Label TrianguloLado2;
        private System.Windows.Forms.TextBox TrianguloLado3TextBox;
        private System.Windows.Forms.TextBox TrianguloLado2TextBox;
        private System.Windows.Forms.TextBox TrianguloLado1TextBox;
        private System.Windows.Forms.Label TrianguloAltura;
        private System.Windows.Forms.Label TrianguloBase;
        private System.Windows.Forms.TextBox pentagononumeroLadoTextBox;
        private System.Windows.Forms.TextBox pentagonoApotemaTextBox;
        private System.Windows.Forms.TextBox pentagonoLadoTextBox;
        private System.Windows.Forms.Label PentagonoNumeroLado;
        private System.Windows.Forms.Label PentagonoApotema;
        private System.Windows.Forms.Label PentagonoLado;
        private System.Windows.Forms.TextBox RectanguloAlturaTextBox;
        private System.Windows.Forms.TextBox RectanguloBaseTextBox;
        private System.Windows.Forms.Label RectanguloAltura;
        private System.Windows.Forms.Label RectanguloBase;
        private System.Windows.Forms.TextBox circuloRadiotextBox;
        private System.Windows.Forms.Label CirculoRadio;
        private System.Windows.Forms.TextBox CuadradoLadotextBox;
        private System.Windows.Forms.Label CuadradoLado;
        private System.Windows.Forms.TextBox TrianguloAlturaTextBox;
        private System.Windows.Forms.TextBox TrianguloBaseTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

