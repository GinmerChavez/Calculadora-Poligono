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
            this.PrincipaltabControl = new System.Windows.Forms.TabControl();
            this.trianguloTabPage = new System.Windows.Forms.TabPage();
            this.cuadradoTabPage = new System.Windows.Forms.TabPage();
            this.circuloTabPage = new System.Windows.Forms.TabPage();
            this.rectanguloTabPage = new System.Windows.Forms.TabPage();
            this.pentagonoTabPage = new System.Windows.Forms.TabPage();
            this.calcularPerimetrobutton = new System.Windows.Forms.Button();
            this.calcularAreabutton = new System.Windows.Forms.Button();
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
            // trianguloTabPage
            // 
            this.trianguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.trianguloTabPage.Name = "trianguloTabPage";
            this.trianguloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trianguloTabPage.Size = new System.Drawing.Size(756, 293);
            this.trianguloTabPage.TabIndex = 0;
            this.trianguloTabPage.Text = "Triangulo";
            this.trianguloTabPage.UseVisualStyleBackColor = true;
            // 
            // cuadradoTabPage
            // 
            this.cuadradoTabPage.Location = new System.Drawing.Point(4, 22);
            this.cuadradoTabPage.Name = "cuadradoTabPage";
            this.cuadradoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cuadradoTabPage.Size = new System.Drawing.Size(756, 293);
            this.cuadradoTabPage.TabIndex = 1;
            this.cuadradoTabPage.Text = "Cuadrado";
            this.cuadradoTabPage.UseVisualStyleBackColor = true;
            // 
            // circuloTabPage
            // 
            this.circuloTabPage.Location = new System.Drawing.Point(4, 22);
            this.circuloTabPage.Name = "circuloTabPage";
            this.circuloTabPage.Size = new System.Drawing.Size(756, 293);
            this.circuloTabPage.TabIndex = 2;
            this.circuloTabPage.Text = "Circulo";
            this.circuloTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanguloTabPage
            // 
            this.rectanguloTabPage.Location = new System.Drawing.Point(4, 22);
            this.rectanguloTabPage.Name = "rectanguloTabPage";
            this.rectanguloTabPage.Size = new System.Drawing.Size(756, 293);
            this.rectanguloTabPage.TabIndex = 3;
            this.rectanguloTabPage.Text = "Rectangulo";
            this.rectanguloTabPage.UseVisualStyleBackColor = true;
            // 
            // pentagonoTabPage
            // 
            this.pentagonoTabPage.Location = new System.Drawing.Point(4, 22);
            this.pentagonoTabPage.Name = "pentagonoTabPage";
            this.pentagonoTabPage.Size = new System.Drawing.Size(756, 293);
            this.pentagonoTabPage.TabIndex = 4;
            this.pentagonoTabPage.Text = "Pentagono";
            this.pentagonoTabPage.UseVisualStyleBackColor = true;
            // 
            // calcularPerimetrobutton
            // 
            this.calcularPerimetrobutton.Location = new System.Drawing.Point(493, 408);
            this.calcularPerimetrobutton.Name = "calcularPerimetrobutton";
            this.calcularPerimetrobutton.Size = new System.Drawing.Size(145, 23);
            this.calcularPerimetrobutton.TabIndex = 9;
            this.calcularPerimetrobutton.Text = "Calcular Perimetro";
            this.calcularPerimetrobutton.UseVisualStyleBackColor = true;
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
            // CalculadoraPoligonosForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 433);
            this.Controls.Add(this.calcularAreabutton);
            this.Controls.Add(this.calcularPerimetrobutton);
            this.Controls.Add(this.PrincipaltabControl);
            this.Controls.Add(this.titulolabel);
            this.Name = "CalculadoraPoligonosForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CalculadoraPoligonosForm1_Load);
            this.PrincipaltabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulolabel;
        private System.Windows.Forms.TabControl PrincipaltabControl;
        private System.Windows.Forms.TabPage trianguloTabPage;
        private System.Windows.Forms.TabPage cuadradoTabPage;
        private System.Windows.Forms.TabPage circuloTabPage;
        private System.Windows.Forms.TabPage rectanguloTabPage;
        private System.Windows.Forms.TabPage pentagonoTabPage;
        private System.Windows.Forms.Button calcularPerimetrobutton;
        private System.Windows.Forms.Button calcularAreabutton;
    }
}

