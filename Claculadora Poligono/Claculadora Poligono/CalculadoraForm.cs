using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Poligonos;

namespace Claculadora_Poligono
{
    public partial class CalculadoraForm : Form
    {
        private Poligono poligonoSeleccionado;
        public CalculadoraForm()
        {
            InitializeComponent();
        }

        private void PrincipaltabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrincipaltabControl.SelectedIndex == 0)
            {
                poligonoSeleccionado = new Triangulo();
            }
            if (PrincipaltabControl.SelectedIndex == 1)
            {
                poligonoSeleccionado = new Cuadrado();
            }
            if (PrincipaltabControl.SelectedIndex == 2)
            {
                poligonoSeleccionado = new Circulo();
            }
            if (PrincipaltabControl.SelectedIndex == 3)
            {
                poligonoSeleccionado = new Rectangulo();
            }
            if (PrincipaltabControl.SelectedIndex == 4)
            {
                poligonoSeleccionado = new Pentagono();
            }
        }

        private void TrianguloBaseTextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)poligonoSeleccionado;
            triangulo.Base = Convert.ToDouble(TrianguloBaseTextBox.Text);
         }

        private void TrianguloAlturaTextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo1 = (Triangulo)poligonoSeleccionado;
            triangulo1.Altura = Convert.ToDouble(TrianguloAlturaTextBox.Text);
        }

        private void TrianguloLado3TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo2 = (Triangulo)poligonoSeleccionado;
            triangulo2.Lado3 = Convert.ToDouble(TrianguloLado3TextBox.Text);
        }

        private void TrianguloLado2TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo3 = (Triangulo)poligonoSeleccionado;
            triangulo3.Lado2 = Convert.ToDouble(TrianguloLado2TextBox.Text);
        }

        private void TrianguloLado1TextBox_Leave(object sender, EventArgs e)
        {
            Triangulo triangulo4 = (Triangulo)poligonoSeleccionado;
            triangulo4.Lado1 = Convert.ToDouble(TrianguloLado1TextBox.Text);
        }

        private void CuadradoLadotextBox_Leave(object sender, EventArgs e)
        {
            Cuadrado cuadrado= (Cuadrado)poligonoSeleccionado;
            cuadrado.Lado = Convert.ToDouble(CuadradoLadotextBox.Text);
        }

        private void circuloRadiotextBox_Leave(object sender, EventArgs e)
        {

        }

        private void RectanguloBaseTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void RectanguloAlturaTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void pentagonoLadoTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void pentagonoApotemaTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void pentagononumeroLadoTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void calcularPerimetrobutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El perimetro es: " + poligonoSeleccionado.CalcularPerimetro());
        }

        private void CalculadoraForm_Load(object sender, EventArgs e)
        {
            poligonoSeleccionado = new Triangulo();
        }
    }
}
