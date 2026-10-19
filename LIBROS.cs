using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace matricula_cole
{
    public partial class LIBROS : Form
    {
        public LIBROS()
        {
            InitializeComponent();
        }

        string libro()
        {
            return textlibro.Text;
        }

        double precio()
        {
            double precio = double.Parse(textprecio.Text);
            return precio;
        }

        double canidad()
        {
            double cantidad = double.Parse(textcantidad.Text);
            return cantidad;
        }

        double total()
        {
            double total = precio() * canidad();
            return total;
        }

        // Método nuevo para sumar toda la cuarta columna (índice 3)
        void calcularTotalGeneral()
        {
            double sumaTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Verifica que la celda no esté vacía (ignora la última fila en blanco)
                if (row.Cells[3].Value != null)
                {
                    sumaTotal += double.Parse(row.Cells[3].Value.ToString());
                }
            }

            // Muestra el resultado en el TextBox de abajo (con formato de 2 decimales)
            textTotalGeneral.Text = sumaTotal.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                libro(),
                precio(),
                canidad(),
                total());

            // Actualiza la suma total automáticamente al registrar un libro
            calcularTotalGeneral();
        }

        private void LIBROS_Load(object sender, EventArgs e)
        {

        }
    }
}
