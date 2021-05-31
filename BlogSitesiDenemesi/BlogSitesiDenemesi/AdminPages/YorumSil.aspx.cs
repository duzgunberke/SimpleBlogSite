using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogSitesiDenemesi.Entity;

namespace BlogSitesiDenemesi.AdminPages
{
    public partial class YorumSil : System.Web.UI.Page
    {
        BlogWebsiteDbEntities db = new BlogWebsiteDbEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["YORUMID"]);
            var yorum = db.TBL_YORUM.Find(x);
            db.TBL_YORUM.Remove(yorum);
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}