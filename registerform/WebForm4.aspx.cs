using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LinqToSqlShared;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace registerform
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var db = new DataClasses1DataContext();
            firstone c = new firstone
            {
                name = TextBox1.Text.Trim(),
                email = TextBox2.Text.Trim(),
                //Status = "Active"
            };
            //firstone.Connection.ConnectionString =
    //System.Configuration.ConfigurationManager.AppSettings["constr"];
           // db.firstone.InsertOnSubmit(c);
            db.SubmitChanges();
            
        }
    }
}