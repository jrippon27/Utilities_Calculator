using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            double secondTextBoxNumber;
            double thirdTextBoxNumber;
            double fourthTextBoxNumber;
            double fifthTextBoxNumber;
            double sixthTextBoxNumber;
            double total;

            firstTextBoxNumber = double.Parse(textBox1.Text);
            secondTextBoxNumber = double.Parse(textBox2.Text);
            thirdTextBoxNumber = double.Parse(textBox3.Text);
            fourthTextBoxNumber = double.Parse(textBox4.Text);
            fifthTextBoxNumber = double.Parse(textBox5.Text);
            sixthTextBoxNumber = double.Parse(textBox6.Text);
            
            total = (firstTextBoxNumber * secondTextBoxNumber) +
                (thirdTextBoxNumber * fourthTextBoxNumber) +
                (fifthTextBoxNumber * sixthTextBoxNumber);

            MessageBox.Show(total.ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double firstTextBoxNumber;
            
            firstTextBoxNumber = double.Parse(textBox1.Text);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double secondTextBoxNumber;

            secondTextBoxNumber = double.Parse(textBox2.Text);
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double thirdTextBoxNumber;

            thirdTextBoxNumber = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double fourthTextBoxNumber;

            fourthTextBoxNumber = double.Parse(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double fifthTextBoxNumber;

            fifthTextBoxNumber = double.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double sixthTextBoxNumber;

            sixthTextBoxNumber = double.Parse(textBox6.Text);
      }
   }
}

