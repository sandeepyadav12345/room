using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
       // int firstnumber, secondnumber,result;
       // string oper;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
           string firstnumber = Convert.ToString( first.Text);
            int x = 0;
            bool y = int.TryParse(firstnumber, out x);
            if (firstnumber != "")
            {
                while (!y)
                {
                    MessageBox.Show("enter valid integer value", "Error message",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    firstnumber = Convert.ToString(first.Text);
                    y = int.TryParse(firstnumber, out x);


                }
            }
            else
            {
                MessageBox.Show("fields are empty", "Error message",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
           
           string secondnumber = Convert.ToString( second.Text);
            int m = 0;
            bool n= int.TryParse(secondnumber, out m);
            if(secondnumber!= "")
            {
                while (!n)
                {
                    MessageBox.Show("enter valid integer value", "Error message",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    secondnumber = Convert.ToString(second.Text);
                    y = int.TryParse(firstnumber, out m);


                }
            }
            else
            {
                MessageBox.Show("fields are empty", "Error message",
 MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
           

           string oper = Convert.ToString(opr.Text);
            if (oper != "")
            {
                switch (oper)
                {
                    case "+":
                        int result = x + m;
                        res.Text = result.ToString();
                        break;
                    case "-":
                        result = x - m;
                        res.Text = result.ToString();
                        break;
                    case "*":
                        result = x * m;
                        res.Text = result.ToString();
                        break;
                    case "/":
                        result = x / m;
                        res.Text = result.ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("fields are empty", "Error message",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
           
            
           
    }
}
