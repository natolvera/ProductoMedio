using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductoMedio.algoritmos;

namespace ProductoMedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // si no se ingresa algo en alguna de las textbox
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") ||
                textBox3.Text.Equals("")) {
                MessageBox.Show("No pueden haber casillas vacias");
                return;
            }

            int seed1 = Convert.ToInt32(textBox1.Text);
            int seed2 = Convert.ToInt32(textBox2.Text);
            int puntosTotales = Convert.ToInt32(textBox3.Text);


            GeneradorProductoMedio generador = new GeneradorProductoMedio();
            List<List<int>> listaSalida = generador.crearListas(seed1, seed2, puntosTotales);
            llenarGrid(listaSalida, puntosTotales);

        }

        public void llenarGrid(List<List<int>> listaDeListas, int puntosTotales){

            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";
            string numeroColumna5 = "5";
            string numeroColumna6 = "6";
            string numeroColumna7 = "7";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "n");
            dataGridView1.Columns.Add(numeroColumna2, "Seed1");
            dataGridView1.Columns.Add(numeroColumna3, "Seed2");
            dataGridView1.Columns.Add(numeroColumna4, "Producto");
            dataGridView1.Columns.Add(numeroColumna5, "Medio");
            dataGridView1.Columns.Add(numeroColumna6, "Valor1");
            dataGridView1.Columns.Add(numeroColumna7, "Valor2");

            for (int i = 0; i < puntosTotales; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = i.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = listaDeListas[0][i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = listaDeListas[1][i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = listaDeListas[2][i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna5) - 1].Value = listaDeListas[3][i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna6) - 1].Value = listaDeListas[4][i].ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna7) - 1].Value = listaDeListas[5][i].ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
