using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCalculator : Form
    {
        bool isNewEntry = false, isInfinityException = false, isRepeatLastOperation = false;
        double dblResult = 0, dblOperand = 0;
        char chPreviousOperator = new char();
        public frmCalculator()
        {
            InitializeComponent();
        }
        private void UpdateOperand(object sender, EventArgs e)
        {
            if (!isInfinityException)
            {
                if (isNewEntry)
                {
                    txtResult.Text = "0";
                    isNewEntry = false;
                }
                if (isRepeatLastOperation)
                {
                    chPreviousOperator = '\0';
                    dblResult = 0;
                }
                if (!(txtResult.Text == "0" && (Button)sender == btn0) && !(((Button)sender) == btnDecimalPoint && txtResult.Text.Contains(".")))
                    txtResult.Text = (txtResult.Text == "0" && ((Button)sender) == btnDecimalPoint) ? "0." : ((txtResult.Text == "0") ? ((Button)sender).Text : txtResult.Text + ((Button)sender).Text);
            }
        }
        private void ClearOperator(object sender, EventArgs e)
        {
            isInfinityException = false;
            txtResult.Text = "0";
        }
        private void ChangeSign(object sender, EventArgs e)
        {
            if (!isInfinityException)
                txtResult.Text = (double.Parse(txtResult.Text) * -1).ToString();
        }

        private void OperatorFound(object sender, EventArgs e)
        {
            if (!isInfinityException)
            {
                if (chPreviousOperator == '\0')
                {
                    chPreviousOperator = ((Button)sender).Text[0];
                    dblResult = double.Parse(txtResult.Text);
                }
                else if (isNewEntry)
                    chPreviousOperator = ((Button)sender).Text[0];
                else
                {
                    Operate(dblResult, chPreviousOperator, double.Parse(txtResult.Text));
                    chPreviousOperator = ((Button)sender).Text[0];
                }
                isNewEntry = true;
                isRepeatLastOperation = false;
            }
        }
        void Operate(double dblPreviousResult, char chPreviousOperator, double dblOperand)
        {
            switch (chPreviousOperator)
            {
                case '+':
                    txtResult.Text = (dblResult = (dblPreviousResult + dblOperand)).ToString();
                    break;
                case '-':
                    txtResult.Text = (dblResult = (dblPreviousResult - dblOperand)).ToString();
                    break;
                case '*':
                    txtResult.Text = (dblResult = (dblPreviousResult * dblOperand)).ToString();
                    break;
                case '/':
                    if (dblOperand == 0)
                    {
                        txtResult.Text = "Cannot divide by zero";
                        isInfinityException = true;
                    }
                    else
                        txtResult.Text = (dblResult = (dblPreviousResult / dblOperand)).ToString();
                    break;
            }
        }
        private void Equals(object sender, EventArgs e)
        {
            if (!isInfinityException)
            {
                if (!isRepeatLastOperation)
                {
                    dblOperand = double.Parse(txtResult.Text);
                    isRepeatLastOperation = true;
                }
                Operate(dblResult, chPreviousOperator, dblOperand);
                isNewEntry = true;
            }
        }
        private void ClearAll(object sender, EventArgs e)
        {
            isInfinityException = isRepeatLastOperation = false;
            dblOperand = dblResult = 0; txtResult.Text = "0";
            isNewEntry = true;
            chPreviousOperator = '\0';
        }
    }
}
