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
    public partial class deneme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                ArrayList ArrayProduct = new ArrayList();


                HttpCookie cookie = Request.Cookies["userInfo"];
                

                    Product Product1 = new Product(1, "Sudo Cream", 9.5, "images/5234583.png", "Baby care cream 250g", "Sudocrem", 5, "Care");
                    Product Product2 = new Product(2, "Olive Oil Cream", 2.5, "59565.jpg", "Olive Oil Cream 500g", "Eyup Sabri Tuncer", 10, "Care");
                    Product Product3 = new Product(3, "Pink Comb", 5.0, "images/Nivea Deo Roll-On Fresh Erkek 50 ml.jpg", "Pink comb", "Nacita", 3, "Care");
                    //Product Product4 = new Product(4, "Black Mask", 6.5, "images/maske.jpg", "Black mask 100 piece", "Evony", 5, "Health");
                    //Product Product5 = new Product(5, "Sudo Cream", 9.5, "images/krem.jpg", "Baby care cream 250g", "Sudocrem", 5, "Health");

                    ArrayProduct.Add(Product1);
                    ArrayProduct.Add(Product2);
                    ArrayProduct.Add(Product3);
                    //ArrayProduct.Add(Product4);

                    Session["Info_Product"] = ArrayProduct;


                    Add_Product_Cart(Product1);
                    Add_Product_Cart(Product2);
                    Add_Product_Cart(Product3);
                    //Add_Product_Cart(Product4);



                
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
                //   btn_product.Click += movie_Click;
                btn_product.Width = 300;
                btn_product.Height = 400;
                btn_product.ImageUrl = product.Productlmage;

                div_card_body.Controls.Add(btn_product);

                div_card.Controls.Add(div_card_body);

                //Panel2.Controls.Add(div_card);
            }

            protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
            {
                Response.Redirect("Cart.aspx");
            }

            protected void search_button_Click(object sender, ImageClickEventArgs e)
            {
                /* string value = search_textbox.Text.Trim();
                 // Your Ado.Net code to get data from DB
                 string[] itemsGotFromDB = { "aaaa", "bbbb", "etc" };
                 bltLstSearchItems.DataSource = itemsGotFromDB;
                 bltLstSearchItems.DataBind();*/

            }
        }
    }
