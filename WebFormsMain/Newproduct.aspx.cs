using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebFormsMain
{
    public partial class Newproduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                MasterPage showMaster = this.Page.Master;
                string uname = (string)Session["Username"];
                MessageBox.Show(uname);
                HtmlAnchor liLogin = (HtmlAnchor)showMaster.FindControl("liLogin");
                HyperLink aLogout = (HyperLink)showMaster.FindControl("aLogout");

                aLogout.Visible = true;
                liLogin.Visible = false;
            }
        }
    }
}