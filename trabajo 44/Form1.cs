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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Double resultado = 0, valor1, valor2;
                valor1 = Convert.ToDouble(textBox1.Text);
                valor2 = Convert.ToDouble(textBox2.Text);

                resultado = (valor1 + valor2);
                textBox3.Text = resultado.ToString();
            }
            catch (Exception)
            {

                 MessageBox.Show("dato incorrecto");
            }
            
            
            
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Double resultado = 0, valor1, valor2;
                valor1 = Convert.ToDouble(textBox1.Text);
                valor2 = Convert.ToDouble(textBox2.Text);

                resultado = (valor1 - valor2);
                textBox3.Text = resultado.ToString();
            }

            catch (Exception)
            {


                MessageBox.Show("dato incorrecto");

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                Double resultado = 0, valor1, valor2;
                valor1 = Convert.ToDouble(textBox1.Text);
                valor2 = Convert.ToDouble(textBox2.Text);

                resultado = (valor1 * valor2);
                textBox3.Text = resultado.ToString();
            
            }
            catch (Exception)
            {

                MessageBox.Show("dato incorrecto");
             }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {



                Double resultado = 0, valor1, valor2;
                valor1 = Convert.ToDouble(textBox1.Text);
                valor2 = Convert.ToDouble(textBox2.Text);

                resultado = (valor1 / valor2);
                textBox3.Text = resultado.ToString();
            }

            catch (Exception)
            {

                MessageBox.Show("dato incorrecto");

            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            windows_nuevo segundo = new windows_nuevo();
            segundo.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
