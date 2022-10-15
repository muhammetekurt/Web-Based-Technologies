using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Homework_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        private void showPics()
        {
            visa.Visible = true;
            american.Visible = true;
            mastercard.Visible = true;
            discover.Visible = true;
            maestro.Visible = true;
        }
        protected void enter_Click1(object sender, EventArgs e)
        {
            string strConfirmPass = cvvnumber.Text;
            string strCardNumberr = cardNumber.Text;
            string strCardOwner = cardOwner.Text;
            bool result = strCardOwner.All(c => char.IsWhiteSpace(c) || char.IsLetter(c));

            bool continuee = true;

            if (cardNumber.Text == "" || cvvnumber.Text == "" || cardOwner.Text == "")
            {
                Label8.Text = "No field cannot be left blank";

                Label8.ForeColor = System.Drawing.Color.Red;
                enter.BackColor = System.Drawing.Color.Red;

                showPics();
            }
            else
            {
                if (result == true && long.TryParse(cardNumber.Text, out long varr) && int.TryParse(cvvnumber.Text, out int cvv))
                {
                    if (Regex.Match(strCardNumberr, @"^4[0-9]{12}(?:[0-9]{3})?$").Success)
                    {
                        visa.Visible = true;

                        maestro.Visible = false;
                        discover.Visible = false;
                        mastercard.Visible = false;
                        american.Visible = false;
                    }

                    else if (Regex.Match(strCardNumberr, @"^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$").Success)
                    {
                        mastercard.Visible = true;

                        visa.Visible = false;
                        discover.Visible = false;
                        maestro.Visible = false;
                        american.Visible = false;
                    }

                    else if (Regex.Match(strCardNumberr, @"^6(?:011|5[0-9]{2})[0-9]{12}$").Success)
                    {
                        discover.Visible = true;

                        visa.Visible = false;
                        maestro.Visible = false;
                        mastercard.Visible = false;
                        american.Visible = false;
                    }

                    else if (Regex.Match(strCardNumberr, @"^3[47][0-9]{13}$").Success)
                    {
                        american.Visible = true;

                        visa.Visible = false;
                        maestro.Visible = false;
                        mastercard.Visible = false;
                        discover.Visible = false;
                    }

                    else if (Regex.Match(strCardNumberr, @"^(5018|5020|5038|6304|6759|6761|6763)[0-9]{8,15}$").Success)
                    {
                        maestro.Visible = true;

                        visa.Visible = false;
                        american.Visible = false;
                        mastercard.Visible = false;
                        discover.Visible = false;
                    }
                    else{ 
                        Label8.Text = "Unknown card type";

                        Label8.ForeColor = System.Drawing.Color.Red;
                        enter.BackColor = System.Drawing.Color.Red;
                        showPics();
                        continuee = false;
                    }
                    if (continuee)
                    {
                        if (check(strCardNumberr))
                        {
                            enter.BackColor = System.Drawing.Color.Green;

                            Label8.Text = "This is a valid card";
                            Label8.ForeColor = System.Drawing.Color.Green;
                        }

                        else
                        {

                            showPics();

                            Label8.Text = "This is not a valid card";
                            Label8.ForeColor = System.Drawing.Color.Red;
                            enter.BackColor = System.Drawing.Color.Red;
                        }
                    }
                    
                }
                else
                {
                    if (result == false)
                        Label8.Text = "Card name can only consist of letters";
                    if (!(long.TryParse(cardNumber.Text, out long aa)))
                        Label8.Text = "Card number can only consist of numbers";
                    if (!(int.TryParse(cvvnumber.Text, out int aaa)))
                        Label8.Text = "Cvv number can only consist of numbers";

                    enter.BackColor = System.Drawing.Color.Red;
                    Label8.ForeColor = System.Drawing.Color.Red;

                    showPics();
                }
            }
        }
        public static bool check(string ccNumber)
        {
            int sum = 0;
            bool alternate = false;

            for (int i = ccNumber.Length - 1; i >= 0; i--)
            {
                char[] nx = ccNumber.ToArray();
                int n = int.Parse(nx[i].ToString());

                if (alternate)
                {
                    n *= 2;
                    if (n > 9)
                        n = (n % 10) + 1;
                }
                sum += n;
                alternate = !alternate;
            }
            return (sum % 10 == 0);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label8.Text = "";
            cvvnumber.Text = "";
            cardNumber.Text = "";
            cardOwner.Text = "";
            monthList.SelectedIndex = 0;
            yearList.SelectedIndex = 0;

            enter.BackColor = System.Drawing.Color.Gainsboro; //default button color
            Label8.ForeColor = System.Drawing.Color.Gainsboro;

            showPics();
        }
    }
}