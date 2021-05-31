using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogSitesiDenemesi.Entity;

namespace BlogSitesiDenemesi.AdminPages
{
    public partial class Bloglar : System.Web.UI.Page
    {
        BlogWebsiteDbEntities db = new BlogWebsiteDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBL_BLOG.ToList();
            Repeater1.DataBind();
        }
    }
}