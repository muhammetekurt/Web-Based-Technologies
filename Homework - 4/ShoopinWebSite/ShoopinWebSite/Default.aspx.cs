using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.UI.HtmlControls;
namespace ShoopinWebSite
{
    public partial class Default : System.Web.UI.Page
    {
        private bool HasButtonBeenClicked(string controlId)
        {
            if (Request.Cookies["hasclicked" + controlId] != null)
            {
                return true;
            }
            var cookie = new HttpCookie("hasclicked" + controlId);
            Response.Cookies.Add(cookie);
            return false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            /*Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;*/

            HttpCookie cookie = Request.Cookies["userInfo"];
            if (Request.Cookies["userInfo"] != null)
            {
                Label2.Text = "";

                Label2.Text += cookie["userName"].ToUpper();
                Label2.Text += " ";
                Label2.Text += cookie["Pwd"].ToUpper();
            }

            /*ArrayList ArrayProduct = new ArrayList();

            Product Product1 = new Product(1, "Sudo Cream", 9.5, "images/5234583.png", "Baby care cream 250g", "Sudocrem", 5, "Care");
            Product Product2 = new Product(2, "Olive Oil Cream", 2.5, "images/59565.jpg", "Olive Oil Cream 500g", "Eyup Sabri Tuncer", 10, "Care");
            Product Product3 = new Product(3, "Pink Comb", 5.0, "images/Nivea Deo Roll-On Fresh Erkek 50 ml.jpg", "Pink comb", "Nacita", 3, "Care");
            //Product Product4 = new Product(4, "Black Mask", 6.5, "images/maske.jpg", "Black mask 100 piece", "Evony", 5, "Health");
            //Product Product5 = new Product(5, "Sudo Cream", 9.5, "images/krem.jpg", "Baby care cream 250g", "Sudocrem", 5, "Health");

            ArrayProduct.Add(Product1);
            ArrayProduct.Add(Product2);
            ArrayProduct.Add(Product3);
            //ArrayProduct.Add(Product4);
            
            /*Session["Info_Product"] = ArrayProduct;


            Add_Product_Cart(Product1);
            Add_Product_Cart(Product2);
            Add_Product_Cart(Product3);*/
        }
        public void Add_Product_Cart(Product product)
        {
            HtmlGenericControl div_card = new HtmlGenericControl("div");
            div_card.Attributes.Add("class", "card bg-light text-center");

            HtmlGenericControl div_card_body = new HtmlGenericControl("div");
            div_card_body.Attributes.Add("class", "card-body");

            ImageButton btn_product = new ImageButton();
            btn_product.ID = "ImageButton" + product.ProductID.ToString();
            btn_product.CssClass = "card-img-top";
            //btn_product.Click += movie_Click;
            btn_product.Width = 100;
            btn_product.Height = 100;
            btn_product.ImageUrl = product.Productlmage;

            div_card_body.Controls.Add(btn_product);

            div_card.Controls.Add(div_card_body);

            //Panel2.Controls.Add(div_card);
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;

            Panel2.Visible = true;
        }

        protected void ImageButton45_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");

        }
        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {


            Response.Redirect("Cart.aspx");

        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("Cart.aspx");
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "29.00 TL";
            Session["Kategori"] = "Kişisel Bakım";
            Session["Desc"] = "Nivea Sun Karoten";

            Response.Redirect("ProductInfo.aspx");

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl; 
            Session["Image"] = image;

            Session["Fiyat"] = "22.75 TL";
            Session["Kategori"] = "Kişisel Bakım";
            Session["Desc"] = "Nivea Men Active Fresh";

            Response.Redirect("ProductInfo.aspx");
        }
     
        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "14.99.00 TL";
            Session["Kategori"] = "Elektronik";
            Session["Desc"] = "HP Pavilion Gaming";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "4.899.00 TL";
            Session["Kategori"] = "Elektronik";
            Session["Desc"] = "Oppo Reno 5 Lite ";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "9.900.00 TL";
            Session["Kategori"] = "Elektronik";
            Session["Desc"] = "Samsung 50Q67A 50";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "72.00 TL";
            Session["Kategori"] = "Kişisel Bakım";
            Session["Desc"] = "Perwoll Hassas Bakım";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "12.681.00 TL";
            Session["Kategori"] = "Elektronik";
            Session["Desc"] = "iPhone 11 128 GB";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton27_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "1.600.00 TL";
            Session["Kategori"] = "Kişisel Bakım";
            Session["Desc"] = "Burberry The Beat";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton28_Click(object sender, ImageClickEventArgs e)
        {
            
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "44.25 TL";
            Session["Kategori"] = "Kitap";
            Session["Desc"] = "Yalnızız";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton29_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "41.00 TL";
            Session["Kategori"] = "Kitap";
            Session["Desc"] = "Normal İnsanlar";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton30_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "12.420.00 TL";
            Session["Kategori"] = "Kişisel Bakım";
            Session["Desc"] = "Maison Francis Kurkdjian";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton31_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "49.90 TL";
            Session["Kategori"] = "Ev/Ofis";
            Session["Desc"] = "Duracell Kalem Pil";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton32_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "1.200.00 TL";
            Session["Kategori"] = "Ev/Ofis";
            Session["Desc"] = "Yemek Masası";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton33_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "299.99 TL";
            Session["Kategori"] = "Ev/Ofis";
            Session["Desc"] = "Nevresim Takımı";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton34_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "164.00 TL";
            Session["Kategori"] = "Kişisel Bakım";
            Session["Desc"] = "Oral-B Diş Fırçası";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton35_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "33.00 TL";
            Session["Kategori"] = "Kitap";
            Session["Desc"] = "Doğu'nun Limanları";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton36_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "4.300.00 TL";
            Session["Kategori"] = "Ev/Ofis";
            Session["Desc"] = "Lambader";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton37_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "5.285.99 TL";
            Session["Kategori"] = "Elektronik";
            Session["Desc"] = "Beko Bulaşık Makinesi";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton38_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "21.450.00 TL";
            Session["Kategori"] = "Elektronik";
            Session["Desc"] = "Apple iPad Pro 5. Nesil";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void ImageButton39_Click(object sender, ImageClickEventArgs e)
        {
            string image = (sender as ImageButton).ImageUrl;
            Session["Image"] = image;

            Session["Fiyat"] = "174.00 TL";
            Session["Kategori"] = "Kişisel Bakım";
            Session["Desc"] = "Head & Shoulders Clinical Strength";

            Response.Redirect("ProductInfo.aspx");
        }

        protected void Button60_Click(object sender, EventArgs e)
        {
            Session["Image"] = ImageButton1.ImageUrl;
            Session["ucret"] = 29;

            Session["Fiyat"] = "29.00 TL";
            Session["Desc"] = "Nivea Sun Karoten";
        }
        protected void Button35_Click(object sender, EventArgs e)
        {
            Session["Image1"] = ImageButton2.ImageUrl;
            Session["ucret1"] = 22.75;
            Session["Fiyat1"] = "22.75 TL";
            Session["Desc1"] = "Nivea Men Active Fresh";
        }

        protected void Button37_Click(object sender, EventArgs e)
        {
            Session["Image2"] = ImageButton22.ImageUrl;
            Session["ucret2"] = 14999;

            Session["Fiyat2"] = "14.999.00 TL";
            Session["Desc2"] = "HP Pavilion Gaming";
        }


        protected void Button58_Click(object sender, EventArgs e)
        {
            Session["Image3"] = ImageButton23.ImageUrl;
            Session["ucret3"] = 4899;

            Session["Fiyat3"] = "4.899.00 TL";
            Session["Desc3"] = "Oppo Reno 5 Lite";
        }

        protected void Button59_Click(object sender, EventArgs e)
        {
            Session["Image4"] = ImageButton24.ImageUrl;
            Session["ucret4"] = 9900;

            Session["Fiyat4"] = "9.900.00 TL";
            Session["Desc4"] = "Samsung 50Q67A 50";
        }

        protected void Button43_Click(object sender, EventArgs e)
        {
            Session["Image5"] = ImageButton25.ImageUrl;
            Session["ucret5"] = 72;

            Session["Fiyat5"] = "72.00 TL";
            Session["Desc5"] = "Perwoll Hassas Bakım";
        }

        protected void Button44_Click(object sender, EventArgs e)
        {
            Session["Image6"] = ImageButton26.ImageUrl;
            Session["ucret6"] = 12681;

            Session["Fiyat6"] = "12.681.00 TL";
            Session["Desc6"] = "iPhone 11 128 GB";
        }

        protected void Button45_Click(object sender, EventArgs e)
        {
            Session["Image7"] = ImageButton27.ImageUrl;
            Session["ucret7"] = 1600;

            Session["Fiyat7"] = "1.600.00 TL";
            Session["Desc7"] = "Buberry The Beat";
        }

        protected void Button46_Click(object sender, EventArgs e)
        {
            Session["Image8"] = ImageButton28.ImageUrl;
            Session["ucret8"] = 41;

            Session["Fiyat8"] = "41.00 TL";
            Session["Desc8"] = "Yalnızız";
        }

        protected void Button47_Click(object sender, EventArgs e)
        {
            Session["Image9"] = ImageButton29.ImageUrl;
            Session["ucret9"] = 44.25;

            Session["Fiyat9"] = "44.25 TL";
            Session["Desc9"] = "Normal İnsanlar";
        }

        protected void Button48_Click(object sender, EventArgs e)
        {
            Session["Image10"] = ImageButton30.ImageUrl;
            Session["ucret10"] = 12420;

            Session["Fiyat10"] = "12.420.00 TL";
            Session["Desc10"] = "Maison Francis Kurkdjianr";
        }

        protected void Button49_Click(object sender, EventArgs e)
        {
            Session["Image11"] = ImageButton31.ImageUrl;
            Session["ucret11"] = 49;

            Session["Fiyat11"] = "49.00 TL";
            Session["Desc11"] = "Duracell Kalem Pil";
        }

        protected void Button50_Click(object sender, EventArgs e)
        {
            Session["Image12"] = ImageButton32.ImageUrl;
            Session["ucret12"] = 1200;

            Session["Fiyat12"] = "1.200.00 TL";
            Session["Desc12"] = "Yemek Masası";
        }

        protected void Button51_Click(object sender, EventArgs e)
        {
            Session["Image13"] = ImageButton33.ImageUrl;
            Session["ucret13"] = 299.99;

            Session["Fiyat13"] = "299.99 TL";
            Session["Desc13"] = "Nevresim Takımı";
        }

        protected void Button52_Click(object sender, EventArgs e)
        {
            Session["Image14"] = ImageButton34.ImageUrl;
            Session["ucret14"] = 164;

            Session["Fiyat14"] = "164.00 TL";
            Session["Desc14"] = "Oral-B Diş Fırçası";
        }

        protected void Button53_Click(object sender, EventArgs e)
        {
            Session["Image15"] = ImageButton35.ImageUrl;
            Session["ucret15"] = 33;

            Session["Fiyat15"] = "33.00 TL";
            Session["Desc15"] = "Doğu'nun Limanları";
        }

        protected void Button54_Click(object sender, EventArgs e)
        {
            Session["Image16"] = ImageButton36.ImageUrl;
            Session["ucret16"] = 4300;

            Session["Fiyat16"] = "4.300.00 TL";
            Session["Desc16"] = "Lambader";
        }

        protected void Button55_Click(object sender, EventArgs e)
        {
            Session["Image17"] = ImageButton37.ImageUrl;
            Session["ucret17"] = 5285.99;

            Session["Fiyat17"] = "5.285.99 TL";
            Session["Desc17"] = "Beko Bulaşık Makinesi";
        
        }

        protected void Button56_Click(object sender, EventArgs e)
        {
            Session["Image18"] = ImageButton38.ImageUrl;
            Session["ucret18"] = 21450;

            Session["Fiyat18"] = "21.450.00 TL";
            Session["Desc18"] = "Apple iPad Pro 5. Nesil";
        }

        protected void Button57_Click(object sender, EventArgs e)
        {
            
            Session["Image19"] = ImageButton39.ImageUrl;
            Session["ucret19"] = 174;

            Session["Fiyat19"] = "174.00 TL";
            Session["Desc19"] = "Head & Shoulders Clinical";
        }

        protected void Button61_Click(object sender, EventArgs e)
        {
            Response.Redirect("Error.aspx");
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;

            Panel3.Visible = true;
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel5.Visible = false;

            Panel4.Visible = true;
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;

            Panel5.Visible = true;
        }
    }
}