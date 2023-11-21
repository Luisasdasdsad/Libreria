using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Form1 : Form
    {
        const decimal PRECIO_LIBROS_1_3 = 30;
        const decimal PRECIO_LIBROS_4_6 = 40;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlGeneral.SelectedTab = tabPageInicio;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControlPedido.SelectedTab = tabPageComprar;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            decimal totalPagar = CalcularTotal();

            // Mostrar el total en el label correspondiente
            labelTotalPedido.Text = $"Total a Pagar: {totalPagar.ToString("C")}";
        }
        private decimal CalcularTotal()
        {
            decimal totalPagar = 0;

            // Obtener los libros seleccionados
            foreach (var libro in checkedListBox1.CheckedItems)
            {
                int indiceLibro = checkedListBox1.Items.IndexOf(libro);

                if (indiceLibro >= 0 && indiceLibro <= 2)
                {
                    totalPagar += PRECIO_LIBROS_1_3;
                }
                else if (indiceLibro >= 3 && indiceLibro <= 5)
                {
                    totalPagar += PRECIO_LIBROS_4_6;
                }
            }

            return totalPagar;
        }
    }
}
