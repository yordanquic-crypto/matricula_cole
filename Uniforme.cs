using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace matricula_cole
{
    public partial class Uniforme : Form
    {
        public Uniforme()
        {
            InitializeComponent();
        }

        private void Uniforme_Load(object sender, EventArgs e)
        {

        }

        string prenda()
        {
            return comboBox1.Text;
        }

        string talla()
        {
            return comboBox2.Text;
        }

        double precio()
        {
            double precio = double.Parse(textBox1.Text);
            return precio;
        }

        double cantidad()
        {
            double cantidad = double.Parse(textBox2.Text);
            return cantidad;
        }

        double total()
        {
            double total = precio() * cantidad();
            return total;
        }
        void calcularTotales()
        {
            double sumaCantidad = 0;
            double sumaPrecioTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    sumaCantidad += double.Parse(row.Cells[3].Value.ToString());
                }

                if (row.Cells[4].Value != null)
                {
                    sumaPrecioTotal += double.Parse(row.Cells[4].Value.ToString());
                }
            }

            textTotalCantidad.Text = sumaCantidad.ToString();
            textTotalPrecio.Text = sumaPrecioTotal.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                prenda(),
                talla(),
                precio(),
                cantidad(),
                total()
                );

            calcularTotales();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LIBROS libros = new LIBROS();
            libros.Show();
            this.Hide();
        }
    }
}