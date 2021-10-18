using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspnetAns6
{
    public partial class WFView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["clicks"] == null)
                {
                    ViewState["clicks"] = 0;
                }
                txtBox.Text = ViewState["clicks"].ToString();
            }
        }
        protected void btnCount_Click(object sender, EventArgs e)
        {
            int count = (int)ViewState["clicks"] + 1;
            txtBox.Text = count.ToString();
            ViewState["clicks"] = count++;
        }
    }
}