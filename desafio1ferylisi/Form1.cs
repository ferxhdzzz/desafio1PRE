using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio1ferylisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Electrónica");
            cmbCategoria.Items.Add("Ropa");
            cmbCategoria.Items.Add("Alimentos");
            cmbCategoria.Items.Add("Hogar");
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double precioProducto;
            double montoTotal;
            double descuento = 0;
            double precioFinal = 0;

            // 🔹 VALIDACIONES

            // Validar que el precio del producto sea número válido
            if (!double.TryParse(txtprecioProducto.Text, out precioProducto) || precioProducto <= 0)
            {
                MessageBox.Show("Ingrese un precio de producto válido (número positivo).", "Error");
                return;
            }

            // Validar que el monto total sea número válido
            if (!double.TryParse(txtmontoTotal.Text, out montoTotal) || montoTotal <= 0)
            {
                MessageBox.Show("Ingrese un monto total válido (número positivo).", "Error");
                return;
            }

            // Validar que haya seleccionado una categoría
            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.", "Error");
                return;
            }

            string categoria = cmbCategoria.SelectedItem.ToString();

            // 🔹 SWITCH PARA LAS CATEGORÍAS
            switch (categoria)
            {
                case "Electrónica":
                    if (montoTotal > 500)
                    {
                        descuento = montoTotal * 0.10;
                    }
                    break;

                case "Ropa":
                    if (montoTotal > 300)
                    {
                        descuento = montoTotal * 0.15;
                    }
                    break;

                case "Alimentos":
                    if (montoTotal > 200)
                    {
                        descuento = montoTotal * 0.05;
                    }
                    break;

                case "Hogar":
                    if (montoTotal > 400)
                    {
                        descuento = montoTotal * 0.20;
                    }
                    break;
            }

            // 🔹 IF-ELSE PARA MENSAJE DE DESCUENTO
            if (descuento > 0)
            {
                precioFinal = montoTotal - descuento;
                Descuento.Text = $"Se aplicó un descuento de ${descuento:F2}";
            }
            else
            {
                precioFinal = montoTotal;
                Descuento.Text = "No se aplicó ningún descuento.";
            }

            // Mostrar precio final
            lbPrecioTotal.Text = $"Precio final a pagar: ${precioFinal:F2}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbPrecioTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
