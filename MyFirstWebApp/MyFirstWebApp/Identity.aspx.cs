using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Identity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //int i = 0;
            if (!(int.TryParse(guessNumber.Text, out int i)))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please enter an integer!');</script>");
                return;
            }
            if(string.IsNullOrEmpty(guessNumber.Text) || string.IsNullOrEmpty(betBox.Text))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please fill a number between 1-99 or make a bet!!');</script>");
                return;
            }
            if(Convert.ToInt32(betBox.Text) > (float)Convert.ToDouble(amountLabel.Text))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Your bet is over your amount!!!');</script>");
                return;
            }
            if(amountLabel.Text.CompareTo("0") == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Not enough money please add fund!!!');</script>");
                return;
            }
            int guessnumber = Convert.ToInt32(guessNumber.Text);

            Random ran = new Random();
            int randomnumber = ran.Next(1, 99);
            if(guessnumber > randomnumber)
            {
                float win = ((100f - guessnumber) / 100f) * (1 + (float)Convert.ToDouble(betBox.Text)) + (float)Convert.ToDouble(amountLabel.Text);
                amountLabel.Text = win.ToString();
                resultLabel.Text = "Your win and the random is " + randomnumber;
            }
            else
            {
                resultLabel.Text = "Your lose and the random is " + randomnumber;
                float resultamount = (float) Convert.ToDouble(amountLabel.Text) - (float) Convert.ToDouble(betBox.Text);
                amountLabel.Text = resultamount.ToString();
            }
        }

        protected void addFund_Click(object sender, EventArgs e)
        {
            float addedfund = (float) Convert.ToDouble(fundBox.Text);

            float resultfund = addedfund + (float) Convert.ToDouble(amountLabel.Text);

            amountLabel.Text = resultfund.ToString();
        }
    }
}