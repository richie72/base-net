using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace registerform
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\crud.mdf;Integrated Security=True;User Instance=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            alldata();
        }

        private void alldata()
        {
            con.Open();
            String s = "select * from firstone";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            con.Close();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String s = "insert into firstone(name,address,email,phone) values ('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"')";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            alldata();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            String s = "update firstone set name='"+TextBox1.Text+"', address='"+TextBox2.Text+"',email='"+TextBox3.Text+"',phone='"+TextBox4.Text+"' where id = "+TextBox5.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            alldata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            String s = "delete from firstone where id="+TextBox5.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            alldata();
        }
    }
}