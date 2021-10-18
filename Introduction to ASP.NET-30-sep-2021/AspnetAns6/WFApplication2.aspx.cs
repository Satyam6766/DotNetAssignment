using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspnetAns6
{
    public partial class WFApplication2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["clicks"] == null)
                {
                    Application["clicks"] = 0;
                }
                txtBox.Text = Application["clicks"].ToString();
            }
        }
        protected void btnCount_Click(object sender, EventArgs e)
        {
            int count = (int)Application["clicks"] + 1;
            txtBox.Text = count.ToString();
            Application["clicks"] = count++;
        }
    }
}