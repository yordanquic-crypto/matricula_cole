using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace matricula_cole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nombre()
        {
            return textnombre.Text;
        }

        string dni()
        {
            return textdni.Text;
        }

        string apoderado()
        {
            return textapoderado.Text;
        }

        string grado()
        {
            return comboBox1.Text;
        }

        double monto()
        {
            double monto = double.Parse(textMONTO.Text);
            return monto;
        }

        void calcularTotalMatricula()
        {
            double sumaMonto = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    sumaMonto += double.Parse(row.Cells[4].Value.ToString());
                }
            }

            textTotalMonto.Text = sumaMonto.ToString("0.00");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        void limpiar()
        {
            textapoderado.Clear();
            textdni.Clear();
            textnombre.Clear();
            textMONTO.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                nombre(),
                dni(),
                grado(),
                apoderado(),
                monto());

            calcularTotalMatricula();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uniforme siguiente = new Uniforme();
            siguiente.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}