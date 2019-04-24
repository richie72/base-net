using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using localhost;
using registerform.localhost;

namespace registerform
{
    public partial class UseService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
         {
             lblmessage.Text = "First Loading Time: " + DateTime.Now.ToLongTimeString();
         }
         else
         {
            lblmessage.Text = "PostBack at: " + DateTime.Now.ToLongTimeString();
         }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnservice_Click(object sender, EventArgs e)
        {
            WebService1 proxy = new WebService1();
            lblmessage.Text = String.Format("Current SATYAM Price:{0}",
            proxy.GetPrice("SATYAM").ToString());
        }
    }
}