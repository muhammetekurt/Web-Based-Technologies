using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoopinWebSite
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSurname.Text == "")
            {
                Response.Redirect("Error.aspx");

            }
            else
            {
                //create a cookie by using HttpCookie class and add the name of the cookie that is Democookie  
                HttpCookie cookie = new HttpCookie("userInfo");
                //assign the textBoxes Value on introduction-of-cookies  
                cookie["UserName"] = txtName.Text;
                cookie["Pwd"] = txtSurname.Text;
                //Write the Cookies on the client machine  
                Response.Cookies.Add(cookie);
                //add the Expiration Time That is 30 days  
                cookie.Expires = DateTime.Now.AddDays(30);
                //Redirect the page to other page  
                Response.Redirect("Default.aspx");
            }
            


        }
    }
}