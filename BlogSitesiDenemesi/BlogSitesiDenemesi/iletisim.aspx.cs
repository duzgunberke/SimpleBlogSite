using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogSitesiDenemesi.Entity;

namespace BlogSitesiDenemesi
{
    
    public partial class iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        BlogWebsiteDbEntities db = new BlogWebsiteDbEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            TBL_ILETISIM t = new TBL_ILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.TELEFON = TextBox3.Text;
            t.KONU = TextBox1.Text;
            t.MESAJ = TextBox1.Text;
            db.TBL_ILETISIM.Add(t);
            db.SaveChanges();
        }
    }
}