using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPRARR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ir a la pestaña anterior
            int currentIndex = tabControl1.SelectedIndex;
            if (currentIndex > 0)
            {
                tabControl1.SelectedIndex = currentIndex - 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ir a la siguiente pestaña
            int currentIndex = tabControl1.SelectedIndex;
            int tabCount = tabControl1.TabCount;
            if (currentIndex < tabCount - 1)
            {
                tabControl1.SelectedIndex = currentIndex + 1;
            }

        }
    }
}
