using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_44
{
    public partial class windows_nuevo : Form
    {
        public windows_nuevo()
        {
            InitializeComponent();
        }

        private void windows_nuevo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                MessageBox.Show("es pajaro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 segundo = new Form1();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int recibe;
            recibe = comboBox1.SelectedIndex;
            if (recibe == 0)
            {
                MessageBox.Show("azul");
            }
            else if (recibe == 1)
            {
                MessageBox.Show("rojo");
            }
            else if (recibe == 2)
            {
                MessageBox.Show("verde");
            }
            else if (recibe == 3)
            {
                MessageBox.Show("blanco");
            }
            else if (recibe == 4)
            {
                MessageBox.Show("amarillo");
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                MessageBox.Show("azul");
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                MessageBox.Show("rojo");
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
             if (checkBox8.Checked)
            {
                MessageBox.Show("verde");
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                MessageBox.Show("blanco");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("amarillo");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("es casado"); 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("soltero");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int recibe;
            recibe = listBox1.SelectedIndex;
            if (recibe == 0)
            {
                MessageBox.Show("azul");
            }
            else if (recibe == 1)
            {
                MessageBox.Show("rojo");
            }
            else if (recibe == 2)
            {
                MessageBox.Show("verde");
            }
            else if (recibe == 3)
            {
                MessageBox.Show("blanco");
            }
            else if (recibe == 4)
            {
                MessageBox.Show("amarillo");
            }
        }
    }
}
