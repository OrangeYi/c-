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
            if(string.IsNullOrEmpty(guessNumber.Text) || string.IsNullOrEmpty(betBox.Text))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please fill a number between 1-99 or make a bet!!');</script>");
                return;
            }
            if(Convert.ToInt32(betBox.Text) > Convert.ToInt32(amountLabel.Text))
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
                float win = ((100f - guessnumber) / 100f) * (1 + Convert.ToInt32(betBox.Text)) + Convert.ToInt32(amountLabel.Text);
                int winint = (int)win;
                amountLabel.Text = winint.ToString();
                resultLabel.Text = "Your win and the random is " + randomnumber;
            }
            else
            {
                resultLabel.Text = "Your lose and the random is " + randomnumber;
                int resultamount = Convert.ToInt32(amountLabel.Text) - Convert.ToInt32(betBox.Text);
                amountLabel.Text = resultamount.ToString();
            }
        }

        protected void addFund_Click(object sender, EventArgs e)
        {
            int addedfund = Convert.ToInt32(fundBox.Text);

            int resultfund = addedfund + Convert.ToInt32(amountLabel.Text);

            amountLabel.Text = resultfund.ToString();
        }
    }
}