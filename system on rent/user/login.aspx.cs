using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace system_on_rent.user
{
    public partial class login : System.Web.UI.Page
    { //private string connectionstring = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        //SqlConnection conn = new SqlConnection(connectionstring);
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BBSO535\SQLSERVER;Initial Catalog=SOR;Integrated Security=True");
        int tot = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
           
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where email='"+ UserName.Text+ "'and password='"+Password.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            tot = Convert.ToInt32(dt.Rows.Count.ToString());
            if (tot > 0)
            {
                if (Session["checkoutbutton"].ToString()=="yes")
                {
                    Session["user"] = UserName.Text;
                    Response.Redirect("update_order_detail.aspx");
                }
                else
                {
                    Session["user"] = UserName.Text;
                    Response.Redirect("order_detail.aspx");
                }
            }
            else
            {
                Label1.Text = "password is invalid<br/> please check your username and password";

            }
            conn.Close();
        }
    }
}