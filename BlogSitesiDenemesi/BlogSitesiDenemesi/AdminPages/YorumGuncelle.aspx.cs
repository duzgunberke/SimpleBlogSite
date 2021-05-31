using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogSitesiDenemesi.Entity;

namespace BlogSitesiDenemesi.AdminPages
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        BlogWebsiteDbEntities db = new BlogWebsiteDbEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YORUMID"]);
            if (Page.IsPostBack == false)
            {

                var deger = db.TBL_YORUM.Find(y);
                TextBox1.Text = deger.TBL_BLOG.BLOGBASLIK;
                TextBox2.Text = deger.KULLANICIAD;
                TextBox4.Text = deger.YORUMICERIK;

            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YORUMID"]);
            var yorum = db.TBL_YORUM.Find(y);
            yorum.KULLANICIAD = TextBox2.Text;
            yorum.YORUMICERIK = TextBox4.Text;
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}