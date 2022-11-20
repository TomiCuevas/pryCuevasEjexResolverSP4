using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryCuevasEjxResolverSP4
{
    public partial class frmVentasDiarias : Form
    {
        float[,] matriz = new float[5, 5];

        public frmVentasDiarias()
        {
            InitializeComponent();
        }
        public void CompletarMatriz()
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1) - 1; c++)
                {
                    matriz[f, c] = Convert.ToSingle(dgvImportes.Rows[f].Cells[c + 1].Value);
                }
            }
        }
        private void frmVentasDiarias_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                dgvImportes.Rows.Add(i.ToString());
            }
            dgvImportes.Rows[0].Cells[0].Value = "Julio";
            dgvImportes.Rows[1].Cells[0].Value = "Esteban";
            dgvImportes.Rows[2].Cells[0].Value = "Javier";
            dgvImportes.Rows[3].Cells[0].Value = "Gonzalo";
            dgvImportes.Rows[4].Cells[0].Value = "Alberto";
            dgvImportes.Columns[0].ReadOnly = true;

            for (int f = 0; f < 5; f++)
            {
                for (int c = 1; c < 5; c++)
                {
                    //agrega 0 a todas las casillas
                    dgvImportes.Rows[f].Cells[c].Value = 0;
                }
            }
        }

        private void btnValidarDatos_Click(object sender, EventArgs e)
        {
            txtBebidascon.Clear();
            txtBebidassin.Clear();
            txtComidas.Clear();
            txtPostres.Clear();
            txtTotal.Clear();
            txtMozodelDia.Clear();

            bool validacion = true;
            for (int c = 1; c < dgvImportes.ColumnCount; c++)
            {
                for (int f = 0; f < dgvImportes.RowCount; f++)
                {
                    if (dgvImportes.Rows[f].Cells[c].Value == null)
                    {
                        validacion = false;
                        MessageBox.Show("Ingrese digitos en todas las celdas porfavor", "Error", MessageBoxButtons.OK);
                    }                                                                                                   
                }
            }
            if (validacion == true)
            {
                CompletarMatriz();
                MessageBox.Show("Los datos fueron ingresados correctamente", "Ingreso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    for (int c = 0; c < matriz.GetLength(1) - 1; c++)
                    {
                        matriz[f, 4] = matriz[f, c] + matriz[f, 4];
                    }
                }
                btnMozoDelDia.Enabled = true;
                btnTotales.Enabled = true;
            }
        }
        private void btnTotales_Click(object sender, EventArgs e)
        {

            double comidas = 0;
            double bebidassin = 0;
            double bebidascon = 0;
            double postre = 0;
            double total = 0;

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1) - 1; c++)
                {
                    total = total + matriz[f, c];
                }
            }


            for (int f = 0; f <= matriz.GetUpperBound(0); f++)
            {
                comidas = comidas + matriz[f, 0];
                bebidassin = bebidassin + matriz[f, 1];
                bebidascon = bebidascon + matriz[f, 2];
                postre = postre + matriz[f, 3];


            }
            txtComidas.Text = "La suma total de ventas de comidas es de $ " + comidas.ToString();
            txtBebidassin.Text = "La suma total de ventas de bebidas sin alcohol es de: $ " + bebidassin.ToString();
            txtBebidascon.Text = "La suma total de ventas de bebidas con alcohol es de: $ " + bebidascon.ToString();
            txtPostres.Text = "La suma total de ventas de postres es de: $ " + postre.ToString();
            txtTotal.Text = "La suma total de ventas de los vendedores es de: " + " $" + total.ToString();

        }
        private void btnMozoDelDia_Click(object sender, EventArgs e)
        {
            float varTotal = matriz[0, 4];
            int indice = 0;
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                if (varTotal < matriz[f, 4])
                {
                    varTotal = matriz[f, 4];
                    indice = f;
                }
            }

            //hacer case
            switch (indice)
            {
                case 0:
                    txtMozodelDia.Text = ("Julio");
                    break;
                case 1:
                    txtMozodelDia.Text = ("Esteban");
                    break;
                case 2:
                    txtMozodelDia.Text = ("Javier");
                    break;
                case 3:
                    txtMozodelDia.Text = ("Gonzalo");
                    break;
                case 4:
                    txtMozodelDia.Text = ("Alberto");
                    break;

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
       
    }
}
