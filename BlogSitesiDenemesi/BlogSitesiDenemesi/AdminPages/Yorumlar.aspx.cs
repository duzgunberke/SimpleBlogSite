using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogSitesiDenemesi.Entity;
namespace BlogSitesiDenemesi.AdminPages
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        BlogWebsiteDbEntities db = new BlogWebsiteDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var yorumlar = (from x in db.TBL_YORUM
                            select new
                            {
                                x.YORUMID,
                                x.KULLANICIAD,
                                x.TBL_BLOG.BLOGBASLIK
                            }).ToList();
            Repeater1.DataSource = yorumlar;
            Repeater1.DataBind();
        }
    }
}