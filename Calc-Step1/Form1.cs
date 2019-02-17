using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 11/12/18 */
/* Max Rochefort-Shugar - USW HND COMPUTING - Computer Programming 2 - Assignment 1 - Calculator */

namespace Calc_Step1
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        
        double memoryValue = 0.0;/* Value held in memory. */
        bool clearDisplay = true;/* Used to flag whether the display is to be cleared. */
        bool isFirstValue = true;/* Flags whether the number entered is the first value. */
        bool isAfterEqual = false;/* Has the equals sign been pressed? */
        double currentAnswer; /* The current answer to be displayed to the screen. */
        double lastValueEntered; /* The last value entered by the user. */
        char lastOp = ' ';/* The last operation performed. */
        char sign = '+';/* The sign of the number - positive by default. */

        /* Calculates the current answer based on the input arithmetic operation. */
        private void Calculate(char OP)
        {
            switch (OP)
            {
                case '+':
                    currentAnswer += lastValueEntered;
                    lastOp = '+';
                    break;
                case '-':
                    currentAnswer -= lastValueEntered;
                    lastOp = '-';
                    break;
                case '*':
                    currentAnswer *= lastValueEntered;
                    lastOp = '*';
                    break;
                case '÷':
                    currentAnswer /= lastValueEntered;
                    lastOp = '÷';
                    break;
            }
        }
        /* Event listener for the equals button. */
        private void btnEquals_Click(object sender, EventArgs e)
        {
            /* it this the first value? */
            if (isFirstValue == true && isAfterEqual == false)
            {
                /* Make the current answer equal to the value entered. */
                currentAnswer = double.Parse(txtDisplay.Text);
            }
            else
            {
                /* If the user has not pressed the equals button yet. */
                if (isAfterEqual == false)
                {
                    /* Store the last value entered. */
                    lastValueEntered = double.Parse(txtDisplay.Text);
                }

                /* Calculate the current answer. */
                Calculate(lastOp);

            }

            /* Display the current answer. */
            txtDisplay.Text = currentAnswer.ToString();

            /* Flag that the equal button has been pressed. */
            isAfterEqual = true;

            /* Flag that is is the first value of an arithmetic operation. */
            isFirstValue = true;

            /* Enable the decimal point button. */
            btnDP.Enabled = true;

            /* Clear the display when the user enters a number. */
            clearDisplay = true;

        }

        private void OP_Click(object sender, EventArgs e){

            //Access the properties of the pressed button
            Button btn = sender as Button;

            //Clear the display when user enteres the next operand
            clearDisplay = true;

            //Enable the decimal point button
            btnDP.Enabled = true;

            //set the current answer equal to the value entered
            if (isFirstValue)
            {
                //Get the last value entered
                currentAnswer = double.Parse(txtDisplay.Text);

                //The next number is not the first value
                isFirstValue = false;

                //The equals button has not just been pressed
                isAfterEqual = false;

                //Set the last operation as the pressed buttons text
                lastOp = Convert.ToChar(btn.Text);
            }
            else
            {
                //Get the last value entered
                lastValueEntered = double.Parse(txtDisplay.Text);

                //Calculate current answer
                Calculate(Convert.ToChar(btn.Text));

                //the equals button has not been pressed
                isAfterEqual = false;

                //Display the current answer
                txtDisplay.Text = currentAnswer.ToString();
            }
        }

        //Render numbers to the display
        private void BtnClick(object sender, EventArgs e)
        {

            //Access the properties of the pressed button
            Button btn = sender as Button;

            /* If the equals button has already been pressed, reset. */
            if (isAfterEqual)
            {
                currentAnswer = 0.0;
                lastOp = ' ';
                isAfterEqual = false;
            }

            /* Reset the display */
            if (clearDisplay)
            {
                txtDisplay.Text = btn.Text;
                clearDisplay = false;
            }
            /* Append text to the display */
            else
            {
                /* Limit of 26 characters. */
                if (txtDisplay.Text.Length < 26)
                {
                    txtDisplay.AppendText(btn.Text);
                }
            }
        }

        //appends a decimal point to the display
        private void btnDP_Click(object sender, EventArgs e)
        {
            /* If the equals button has already been pressed, reset. */
            if (isAfterEqual)
            {
                currentAnswer = 0.0;
                lastOp = ' ';
                isAfterEqual = false;
            }
            /* Reset the display by adding a decimal point. */
            if (clearDisplay)
            {
                txtDisplay.Text = "0.";
                /* Stop the display being cleared when the user enters a number after .0 */
                clearDisplay = false;
            }
            else /* For a number that has already been typed, append a decimal point. */
            {
                txtDisplay.AppendText(".");
            }

            /*Disable the button. */
            btnDP.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset the display to 0
            txtDisplay.Text = "0";

            //Reset the current answer to 0
            currentAnswer = 0.0;

            //Enable the decimal point button
            btnDP.Enabled = true;

            //Clear the display on next operand input
            clearDisplay = true;

            //The next value entered is the first operand
            isFirstValue = true;

            //The equals button has not been pressed
            isAfterEqual = false;

            //Clear the last operation;
            lastOp = ' ';
        }

        private void MBtnClick(object sender, EventArgs e)
        {
            /* Access the properties of the clicked button. */
            Button btn = sender as Button;
            /* Split the text of the string at M to get the operation. */
            string[] OP = btn.Text.Split('M');
            /* Add to the memory value. */
            if (OP[1] == "+")
            {
                memoryValue += Convert.ToDouble(txtDisplay.Text);
            }
            /* Subtract from the memory value. */
            else if (OP[1] == "-")
            {
                memoryValue -= Convert.ToDouble(txtDisplay.Text);
            }
            /* Recall the memory value. */
            else if (OP[1] == "R")
            {
                txtDisplay.Text = Convert.ToString(memoryValue);
            }
            /* Clear the memory value. */
            else if (OP[1] == "C")
            {
                memoryValue = 0.0;
            }
        }

        /* Remove the last entered number from the display. */
        private void btnBksp_Click(object sender, EventArgs e)
        {
            /* If there are already numbers in the text box. */
            if (txtDisplay.Text.Length > 1)
            {
                /* If there is a decimal point at the end of the number. */
                if (txtDisplay.Text.EndsWith("."))
                {
                    /* Re-enable the decimal point button. */
                    btnDP.Enabled = true;
                }
                /* Remove the last character from the text box. */
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else /* If there was only one number in the text box, make its value equal to 0. */
            {
                txtDisplay.Text = "0";
            }
        }
        /* Event handler for the sign button. */
        private void btnSign_Click(object sender, EventArgs e)
        {
            /* If the display text box is not empty. */
            if (txtDisplay.Text != "0")
            {
                /* Toggle between signs. */
                if (sign == '+')
                {
                    sign = '-';
                }
                else if (sign == '-')
                {
                    sign = '+';
                }

                /* Convert display value to double, invert and convert back to string. */
                txtDisplay.Text = Convert.ToString(Convert.ToDouble(txtDisplay.Text) * -1);
            }
        }
    }
}
