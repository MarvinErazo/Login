using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "marvin" && textBox2.Text == "1234")
            {
                MessageBox.Show("Logueado con éxito");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }

        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "marvin" && textBox2.Text == "1234")
            {
                MessageBox.Show("Logueado con éxito");
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
        }
    }
}
