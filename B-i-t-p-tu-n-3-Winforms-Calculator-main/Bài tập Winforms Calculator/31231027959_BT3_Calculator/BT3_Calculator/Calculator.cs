using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3_Calculator
{
    public partial class frmCalculator : Form
    {
        private Engine _calculatorEngine = new Engine();
        public frmCalculator()
        {
            InitializeComponent();
        }

        
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string digit = button.Text;
            txtDisplay.Text = _calculatorEngine.ProcessDigit(txtDisplay.Text, digit);
        }

        
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operation = button.Text;
            txtDisplay.Text = _calculatorEngine.ProcessOperator(txtDisplay.Text, operation);
        }

        
        private void ControlButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            switch (buttonText)
            {
                case "CE":
                    txtDisplay.Text = _calculatorEngine.ProcessClearEntry();
                    break;
                case "C":
                    txtDisplay.Text = _calculatorEngine.ProcessClear();
                    break;
                case "=":
                    txtDisplay.Text = _calculatorEngine.ProcessEquals(txtDisplay.Text);
                    break;
            }
        }

        
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = _calculatorEngine.ProcessDecimalPoint(txtDisplay.Text);
        }

        

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;


            btnPlus.Click += OperatorButton_Click;
            btnMinus.Click += OperatorButton_Click;
            btnMultiply.Click += OperatorButton_Click;
            btnDivide.Click += OperatorButton_Click;


            btnClear.Click += ControlButton_Click;
            btnClearEntry.Click += ControlButton_Click;
            btnEquals.Click += ControlButton_Click;


            btnDecimal.Click += DecimalButton_Click;
        }
    }
}
