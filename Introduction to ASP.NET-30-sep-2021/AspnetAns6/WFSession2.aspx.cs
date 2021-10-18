using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspnetAns6
{
    public partial class WFSession2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["clicks"] == null)
                {
                    Session["clicks"] = 0;
                }
                txtBox.Text = Session["clicks"].ToString();
            }
        }
        protected void btnCount_Click(object sender, EventArgs e)
        {
            int count = (int)Session["clicks"] + 1;
            txtBox.Text = count.ToString();
            Session["clicks"] = count++;
        }
    }
}