using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoopinWebSite
{
    public partial class ProductInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Image"] != null)
            {
                Image1.ImageUrl = Session["Image"].ToString();
                Label3.Text = Session["Fiyat"].ToString();
                Label4.Text = Session["Desc"].ToString();
                Label5.Text = Session["Kategori"].ToString();
            }

            HttpCookie cookie = Request.Cookies["userInfo"];

            if (Request.Cookies["userInfo"] != null)
            {
                Label6.Text = "";

                Label6.Text += cookie["userName"].ToUpper();
                Label6.Text += " ";
                Label6.Text += cookie["Pwd"].ToUpper();
            }
        }

        protected void ImageButton46_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");

        }
    }
}