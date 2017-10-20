using Microsoft.SharePoint.Utilities;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Avoid.VisualWebPart1
{
    public partial class VisualWebPart1UserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string dummy_query1 = Request.Form["query"];//post
            string dummy_query2 = Request.QueryString["query"];//get
            if (!String.IsNullOrEmpty(dummy_query1))
            {
                if (dummy_query1.Contains("javascript"))
                {
                    Server.Transfer("/_layouts/15/Avoid/ErrorPage1.aspx", true);
                }
                if (dummy_query1.Contains("script"))
                {
                    Server.Transfer("/_layouts/15/Avoid/ErrorPage1.aspx", true);
                }
                //Response.Redirect(Page.ResolveClientUrl(@"~hostUrl\_layouts\Avoid\ErrorPage1.aspx"));
                //SPUtility.Redirect("settings.aspx", SPRedirectFlags.Static | SPRedirectFlags.RelativeToLayoutsPage, HttpContext.Current);
                //Response.Redirect("http://www.microsoft.com/gohere/look.htm");
                //SPUtility.Redirect
                //Page.Response.Redirect("http://www.microsoft.com/gohere/look.htm");
                //Context.Reponse.Redirect("http://www.microsoft.com/gohere/look.htm");
            }
            if (!String.IsNullOrEmpty(dummy_query2) )
            {
                if (dummy_query2.Contains("javascript"))
                {
                    Server.Transfer("/_layouts/15/Avoid/ErrorPage1.aspx", true);
                }
                if (dummy_query2.Contains("script"))
                {
                    Server.Transfer("/_layouts/15/Avoid/ErrorPage1.aspx", true);
                }

            }
        }
    }
}
