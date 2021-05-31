using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogSitesiDenemesi.Entity;
namespace BlogSitesiDenemesi.AdminPages
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogWebsiteDbEntities db = new BlogWebsiteDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_BLOG t = new TBL_BLOG();
            t.BLOGBASLIK = TextBox1.Text;
            t.BLOGGORSEL = TextBox3.Text;
            t.BLOGICERIK = TextBox4.Text;
            t.BLOGTARIH = DateTime.Parse(TextBox2.Text);
            t.BLOGKATEGORI = int.Parse(DropDownList2.SelectedValue);
            t.BLOGTUR = int.Parse(DropDownList1.SelectedValue);
            db.TBL_BLOG.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");

        }
    }
}