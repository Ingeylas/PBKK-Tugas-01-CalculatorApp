using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {}
        private void textBoxDisplayResult_TextChanged(object sender, EventArgs e) {}

        private void button_click(object sender, EventArgs e)
        {
            if (textBoxDisplayResult.Text == "0" || (isOperationPerformed))
                textBoxDisplayResult.Clear();

            isOperationPerformed = false;

            Button button = (Button)sender;

            //Validation on deciamls more than 1
            if (button.Text == ".")
            {
                if (!textBoxDisplayResult.Text.Contains("."))
                    textBoxDisplayResult.Text += button.Text;

            }
            else
            {
                textBoxDisplayResult.Text += button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBoxDisplayResult.Text);
            labelCurrentOp.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
         
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(textBoxDisplayResult.Text.Length > 0)
                textBoxDisplayResult.Text = textBoxDisplayResult.Text.Remove(textBoxDisplayResult.Text.Length - 1, 1);
            if(textBoxDisplayResult.Text == "")
                textBoxDisplayResult .Text = "0";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBoxDisplayResult.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxDisplayResult.Text = "0";
            resultValue = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                textBoxDisplayResult.Text = (resultValue + double.Parse(textBoxDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                textBoxDisplayResult.Text = (resultValue - double.Parse(textBoxDisplayResult.Text)).ToString();
            }
            else if (operationPerformed == "x")
            {
                textBoxDisplayResult.Text = (resultValue * double.Parse(textBoxDisplayResult.Text)).ToString();
            }
            else
            {
                textBoxDisplayResult.Text = (resultValue / double.Parse(textBoxDisplayResult.Text)).ToString();
            }
        }
    }
}
