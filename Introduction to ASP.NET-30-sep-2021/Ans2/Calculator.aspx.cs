using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.Text;

namespace Ans2
{
    public partial class Calculator : System.Web.UI.Page
    {
        StringBuilder sbr = new StringBuilder();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 1;
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 2;
        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 3;
        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 4;

        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 5;
        }

        protected void Btn6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 6;
        }

        protected void Btn7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 7;
        }

        protected void Btn8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 8;
        }

        protected void Btn9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 9;
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
        }

        protected void BtnZero_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 0;
        }

        protected void BtnEqual_Click(object sender, EventArgs e)
        {
            char[] arr = new char[5];
            arr[0] = '+';
            arr[0] = '-';
            arr[0] = '*';
            arr[0] = '/';
            string cal = TextBox1.Text;    //12+14
            // ViewState["val1"] =
            string[] digits = Regex.Split(cal, @"\D+");

            foreach (string value in digits)
            {
                int number;
                int temp = 1;
                if (int.TryParse(value, out number))
                {
                    ViewState["val" + temp] = value;
                }
            }

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "+";
        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "-";
        }

        protected void BtnMul_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "*";
        }

        protected void BtnDiv_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "/";
        }
    }
}