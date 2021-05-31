using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogSitesiDenemesi.Entity;

namespace BlogSitesiDenemesi.AdminPages
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        BlogWebsiteDbEntities db = new BlogWebsiteDbEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BLOGID"]);
            if (Page.IsPostBack == false)
            {
                var tuler = (from x in db.TBL_TUR
                             select new
                             {
                                 x.TURAD,
                                 x.TURID
                             }).ToList();
                DropDownList1.DataSource = tuler;
                DropDownList1.DataBind();

                var tuler2 = (from x in db.TBL_KATEGORI
                              select new
                              {
                                  x.KATEGORIAD,
                                  x.KATEGORIID
                              }).ToList();
                DropDownList2.DataSource = tuler2;
                DropDownList2.DataBind();

                var deger = db.TBL_BLOG.Find(y);
                TextBox1.Text = deger.BLOGBASLIK;
                TextBox2.Text = deger.BLOGTARIH.ToString();
                TextBox3.Text = deger.BLOGGORSEL;
                TextBox4.Text = deger.BLOGICERIK;
                DropDownList1.SelectedValue = deger.BLOGTUR.ToString();
                DropDownList2.SelectedValue = deger.BLOGKATEGORI.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BLOGID"]);
            var blog = db.TBL_BLOG.Find(y);
            blog.BLOGBASLIK = TextBox1.Text;
            blog.BLOGTARIH = DateTime.Parse(TextBox2.Text);
            blog.BLOGGORSEL = TextBox3.Text;
            blog.BLOGICERIK = TextBox4.Text;
            blog.BLOGTUR = int.Parse(DropDownList1.SelectedValue);
            blog.BLOGKATEGORI = int.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}