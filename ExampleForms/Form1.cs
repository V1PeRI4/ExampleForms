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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxValidate(textBox1, textBox2)) {

                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);

                double z = Math.Pow(x, 3) - (2.5 * x * y) + 1.78 * Math.Pow(x, 2) - (2.5 * y) + 1;  

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
    }
}
