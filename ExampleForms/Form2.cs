using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxValidate(textBox1, textBox2))
            {

                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);

                double z = 3.56 * a + Math.Pow(b, 3) - (5.8 * Math.Pow(b, 2)) + 3.8 * a - 1.5;

                resultLabel.Text = z.ToString();
            }

        }

        private bool textBoxValidate(params TextBox[] textBox)
        {

            bool result = true;

            foreach (TextBox t in textBox)
            {
                if (t.Text == "")
                {
                    errorProvider1.SetError(t, "Заполните поле");
                    result = false;
                }
                else errorProvider1.SetError(t, "");
            }

            return result;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
