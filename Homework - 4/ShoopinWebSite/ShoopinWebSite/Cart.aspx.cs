using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoopinWebSite
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double totalPrice = 0.0;
            string aradeger ;
            int counter = 0;
            if (Session["Image"] != null)
            {
                Image2.ImageUrl = Session["Image"].ToString();
                Label7.Text = Session["Desc"].ToString();
                Label8.Text = Session["Fiyat"].ToString();
                aradeger = Session["ucret"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel3.Visible = true;
                counter++;
            }
            else
                Panel3.Visible = false;

            if (Session["Image1"] != null)
            {
                Image3.ImageUrl = Session["Image1"].ToString();
                Label9.Text = Session["Desc1"].ToString();
                Label10.Text = Session["Fiyat1"].ToString();
                aradeger = Session["ucret1"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel4.Visible = true;
                counter++;

            }
            else
                Panel4.Visible = false;


            if (Session["Image2"] != null)
            {
                Image4.ImageUrl = Session["Image2"].ToString();
                Label11.Text = Session["Desc2"].ToString();
                Label12.Text = Session["Fiyat2"].ToString();
                aradeger = Session["ucret2"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                counter++;

                Panel5.Visible = true;
            }
            else
                Panel5.Visible = false;


            if (Session["Image3"] != null)
            {
                Image5.ImageUrl = Session["Image3"].ToString();
                Label13.Text = Session["Desc3"].ToString();
                Label14.Text = Session["Fiyat3"].ToString();
                aradeger = Session["ucret3"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                counter++;

                Panel6.Visible = true;

            }
            else
                Panel6.Visible = false;

            if (Session["Image4"] != null)
            {
                Image6.ImageUrl = Session["Image4"].ToString();
                Label15.Text = Session["Desc4"].ToString();
                Label16.Text = Session["Fiyat4"].ToString();
                aradeger = Session["ucret4"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                counter++;

                Panel7.Visible = true;

            }
            else
                Panel7.Visible = false;

            if (Session["Image5"] != null)
            {
                Image7.ImageUrl = Session["Image5"].ToString();
                Label17.Text = Session["Desc5"].ToString();
                Label18.Text = Session["Fiyat5"].ToString();
                aradeger = Session["ucret5"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                counter++;

                Panel8.Visible = true;

            }
            else
                Panel8.Visible = false;

            if (Session["Image6"] != null)
            {
                Image8.ImageUrl = Session["Image6"].ToString();
                Label19.Text = Session["Desc6"].ToString();
                Label20.Text = Session["Fiyat6"].ToString();
                aradeger = Session["ucret6"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                counter++;

                Panel9.Visible = true;

            }
            else
                Panel9.Visible = false;

            if (Session["Image7"] != null)
            {
                Image9.ImageUrl = Session["Image7"].ToString();
                Label21.Text = Session["Desc7"].ToString();
                Label22.Text = Session["Fiyat7"].ToString();
                aradeger = Session["ucret7"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel10.Visible = true;
                counter++;

            }
            else
                Panel10.Visible = false;
            
            if (Session["Image8"] != null)
            {
                Image10.ImageUrl = Session["Image8"].ToString();
                Label23.Text = Session["Desc8"].ToString();
                Label24.Text = Session["Fiyat8"].ToString();
                aradeger = Session["ucret8"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel11.Visible = true;
                counter++;

            }
            else
                Panel11.Visible = false;

            if (Session["Image9"] != null)
            {
                Image11.ImageUrl = Session["Image9"].ToString();
                Label25.Text = Session["Desc9"].ToString();
                Label26.Text = Session["Fiyat9"].ToString();
                aradeger = Session["ucret9"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel12.Visible = true;
                counter++;

            }
            else
                Panel12.Visible = false;

            if (Session["Image10"] != null)
            {
                Image12.ImageUrl = Session["Image10"].ToString();
                Label27.Text = Session["Desc10"].ToString();
                Label28.Text = Session["Fiyat10"].ToString();
                aradeger = Session["ucret10"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel13.Visible = true;
                counter++;

            }
            else
                Panel13.Visible = false;

            if (Session["Image11"] != null)
            {
                Image13.ImageUrl = Session["Image11"].ToString();
                Label29.Text = Session["Desc11"].ToString();
                Label30.Text = Session["Fiyat11"].ToString();
                aradeger = Session["ucret11"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel14.Visible = true;
                counter++;

            }
            else
                Panel14.Visible = false;

            if (Session["Image12"] != null)
            {
                Image14.ImageUrl = Session["Image12"].ToString();
                Label31.Text = Session["Desc12"].ToString();
                Label32.Text = Session["Fiyat12"].ToString();
                aradeger = Session["ucret12"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel15.Visible = true;
                counter++;

            }
            else
                Panel15.Visible = false;

            if (Session["Image13"] != null)
            {
                Image15.ImageUrl = Session["Image13"].ToString();
                Label33.Text = Session["Desc13"].ToString();
                Label34.Text = Session["Fiyat13"].ToString();
                aradeger = Session["ucret13"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel16.Visible = true;
                counter++;

            }
            else
                Panel16.Visible = false;

            if (Session["Image14"] != null)
            {
                Image16.ImageUrl = Session["Image14"].ToString();
                Label35.Text = Session["Desc14"].ToString();
                Label36.Text = Session["Fiyat14"].ToString();
                aradeger = Session["ucret14"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel17.Visible = true;
                counter++;

            }
            else
                Panel17.Visible = false;

            if (Session["Image15"] != null)
            {
                Image17.ImageUrl = Session["Image15"].ToString();
                Label37.Text = Session["Desc15"].ToString();
                Label38.Text = Session["Fiyat15"].ToString();
                aradeger = Session["ucret15"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel18.Visible = true;
                counter++;

            }
            else
                Panel18.Visible = false;
            if (Session["Image16"] != null)
            {
                Image18.ImageUrl = Session["Image16"].ToString();
                Label39.Text = Session["Desc16"].ToString();
                Label40.Text = Session["Fiyat16"].ToString();
                aradeger = Session["ucret16"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel19.Visible = true;
                counter++;

            }
            else
                Panel19.Visible = false;

            if (Session["Image17"] != null)
            {
                Image19.ImageUrl = Session["Image17"].ToString();
                Label41.Text = Session["Desc17"].ToString();
                Label42.Text = Session["Fiyat17"].ToString();
                aradeger = Session["ucret17"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel20.Visible = true;
                counter++;

            }
            else
                Panel20.Visible = false;

            if (Session["Image18"] != null)
            {
                Image20.ImageUrl = Session["Image18"].ToString();
                Label43.Text = Session["Desc18"].ToString();
                Label44.Text = Session["Fiyat18"].ToString();
                aradeger = Session["ucret18"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel21.Visible = true;
                counter++;

            }
            else
                Panel21.Visible = false;

            if (Session["Image19"] != null)
            {
                Image21.ImageUrl = Session["Image19"].ToString();
                Label45.Text = Session["Desc19"].ToString();
                Label46.Text = Session["Fiyat19"].ToString();
                aradeger = Session["ucret19"].ToString();
                double deger = Convert.ToDouble(aradeger);
                totalPrice += deger;
                Panel22.Visible = true;
                counter++;

            }
            else
                Panel22.Visible = false;
         
            HttpCookie cookie = Request.Cookies["userInfo"];

            if (Request.Cookies["userInfo"] != null)
            {
                Label6.Text = "";

                Label6.Text += cookie["userName"].ToUpper();
                Label6.Text += " ";
                Label6.Text += cookie["Pwd"].ToUpper();
            }

            Label47.Text = totalPrice.ToString() + " TL";
            Label48.Text = "Sepetinizde " + counter + " ürün bulunmaktadır.";

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
