using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionState
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Clicks"] == null)
                {
                    Session["Clicks"] = 0;
                }
                TextBox1.Text = Session["Clicks"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //here the int variable ClicksCount, stores the Session clicks and increments up 1.
            int ClicksCount = (int)Session["Clicks"] + 1;
            //here convert int to string and passes the Session memory in the TextBox1.
            TextBox1.Text = ClicksCount.ToString();
            //here the Session memory gets stored back into the int variable ClicksCount.
            Session["Clicks"] = ClicksCount;
        }
    }
}