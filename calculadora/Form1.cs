using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operacion;
        double num1, num2, resultado;
        bool reiniciar = false;
        bool punto = true;


        private void Form1_Load(object sender, EventArgs e)
        {
            DibujarTecladoNumerico();

        }

        private void DibujarTecladoNumerico()
        {
            char[] numeros;

            numeros = "7894563210.".ToCharArray();
            flPanelNumerico.Controls.Clear();

            foreach (char numero in numeros)
            {

                Button btnnumero = new Button();
                btnnumero.Text = numero.ToString();
                btnnumero.Size = new Size(55, 55);
                btnnumero.FlatStyle = FlatStyle.Flat;
                btnnumero.ForeColor = Color.White;
                btnnumero.BackColor = Color.Transparent;
                btnnumero.BackgroundImage = Properties.Resources.circulo_2_;
                btnnumero.BackgroundImageLayout = ImageLayout.Stretch;
                btnnumero.FlatAppearance.BorderSize = 0;
                btnnumero.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnnumero.FlatAppearance.MouseOverBackColor = Color.Transparent;
                flPanelNumerico.Controls.Add(btnnumero);
                btnnumero.Click += Btnnumero_Click;
            }
        }

        private void Btnnumero_Click(object sender, EventArgs e)
        {
            ReiniciarProceso();
            string numerostring = ((Button)sender).Text;
            if (numerostring == ".")
            {
                punto = true;
                if (txtPantalla.Text.Contains("."))
                {
                    punto = false;
                }
                if (punto == true)
                {
                    if (txtPantalla.Text != "")
                    {
                        txtPantalla.Text += ".";
                    }
                }
            }
            else
            {
                if (txtPantalla.Text == "0")
                {
                    txtPantalla.Clear();
                }

                txtPantalla.Text += numerostring;
            }
        }

        private void ReiniciarProceso()
        {
            if (reiniciar == true)
            {
                txtPantalla.Text = "0";
                reiniciar = false;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = btnDiv.Text;
            definiroperacion();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            calcular();
        }
        private void calcular()
        {
            asignacion();
            if (lblOperacion.Text == btnDiv.Text)
            {
                dividir();

            }
            if (lblOperacion.Text == btnMulti.Text)
            {
                multiplicacion();
            }
            if (lblOperacion.Text == btnResta.Text)
            {
                resta();
            }
            if (lblOperacion.Text == btnSuma.Text)
            {
                suma();
            }
            if (lblOperacion.Text == btnPorcen.Text)
            {
                porcentaje();
            }
        }
        private void porcentaje()
        {
            resultado = num1 * num2 / 100;
            txtPantalla.Text = resultado.ToString();
            Limpiar();

        }


        private void suma()
        {
            resultado = num1 + num2;
            txtPantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void resta()
        {
            resultado = num1 - num2;
            txtPantalla.Text = resultado.ToString();
            Limpiar();

        }
        private void multiplicacion()
        {
            resultado = num1 * num2;
            txtPantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void Limpiar()
        {
            reiniciar = true;
            lblOperacion.Text = "0";
            lblNum1.Text = "0";

        }
        private void dividir()
        {
            resultado = num1 / num2;
            txtPantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void definiroperacion()
        {
            asignacion();
            if (num2 > 0)
            {
                lblNum1.Text = txtPantalla.Text;
                lblOperacion.Text = operacion;
                txtPantalla.Text = "0";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = btnResta.Text;
            definiroperacion();
        }



        private void btnMulti_Click_1(object sender, EventArgs e)
        {
            operacion = btnMulti.Text;
            definiroperacion();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = btnSuma.Text;
            definiroperacion();
        }

        private void btnPorcen_Click_1(object sender, EventArgs e)
        {
            operacion = btnPorcen.Text;
            definiroperacion();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResta_Click_1(object sender, EventArgs e)
        {
            operacion = btnSuma.Text;
            definiroperacion();
        }

        private void asignacion()
        {
            num1 = Convert.ToDouble(lblNum1.Text);
            num2 = Convert.ToDouble(txtPantalla.Text);
        }




    }
}
