using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorSire
{
    public partial class Form1 : Form
    {

        public double a, b, result;
        public string operation;
        public int check = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            lblScreen.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            a = int.Parse(lblScreen.Text);
            lblScreen.Text = "";
            operation = btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblScreen.Text += btn.Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            a = double.Parse(lblScreen.Text);
            operation = btn.Text;
            lblScreen.Text = " ";
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            a = double.Parse(lblScreen.Text);
            operation = btn.Text;
            lblScreen.Text = " ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            a = double.Parse(lblScreen.Text);
            operation = btn.Text;
            lblScreen.Text = " ";
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
          
            {
                try
                {
                    b = double.Parse(lblScreen.Text);
                    switch (operation)
                    {
                        case "+":
                            result = a + b;
                            break;
                        case "-":
                            result = a - b;
                            break;
                        case "X":
                            result = a * b;
                            break;
                        case "/":
                            if (b == 0)
                            {
                                lblScreen.Text = "";
                                MessageBox.Show("Null");
                            }
                            else
                            {
                                result = a / b;
                            }
                            break;
                    }
                    lblScreen.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        
    }
}





