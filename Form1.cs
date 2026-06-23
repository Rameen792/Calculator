using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        decimal firstNumber = 0;
        string operation = "";
        bool newEntry = true;
        public Form1()
        {
            InitializeComponent();
        }
        void EnterDigit(string digit)
        {
            if (newEntry)
            {
                txtDisplay.Text = digit;
                newEntry = false;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + digit;
            }
        }
        void SetOperation(string op)
        {
            firstNumber = Convert.ToDecimal(txtDisplay.Text);
            operation = op;

            lblExpression.Text = txtDisplay.Text + " " + op;

            newEntry = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EnterDigit("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EnterDigit("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            EnterDigit("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EnterDigit("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EnterDigit("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EnterDigit("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EnterDigit("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EnterDigit("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EnterDigit("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            EnterDigit("0");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text = txtDisplay.Text + ".";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperation("+");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            SetOperation("-");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            SetOperation("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            SetOperation("/");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            SetOperation("%");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            decimal secondNumber = Convert.ToDecimal(txtDisplay.Text);
            decimal result = 0;

            if (operation == "+")
                result = firstNumber + secondNumber;

            else if (operation == "-")
                result = firstNumber - secondNumber;

            else if (operation == "*")
                result = firstNumber * secondNumber;

            else if (operation == "/")
                result = firstNumber / secondNumber;

            else if (operation == "%")
                result = firstNumber % secondNumber;

            lblExpression.Text = firstNumber + " " + operation + " " + secondNumber + " = " + result;

            txtDisplay.Text = result.ToString();

            newEntry = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblExpression.Text = "";
            firstNumber = 0;
            operation = "";
            newEntry = true;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
    }
}
