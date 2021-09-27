using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //  MessageBox.Show("Código malicioso instalado....");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse parado....");

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Formulário clicado.");

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Botão clicado.");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
