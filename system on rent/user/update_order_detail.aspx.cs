using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace system_on_rent.user
{
    
    public partial class update_order_detail : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BBSO535\SQLSERVER;Initial Catalog=SOR;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where email='" + Session["user"].ToString() +"' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                TextBox1.Text= dr["firstname"].ToString();
                TextBox2.Text = dr["lasttname"].ToString();
                TextBox3.Text = dr["address"].ToString();
                TextBox4.Text = dr["city"].ToString();
                TextBox5.Text = dr["state"].ToString();
                TextBox6.Text = dr["mobile"].ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update  registration set firstname='"+TextBox1.Text+ "' lastname='" + TextBox2.Text + "' address='" + TextBox3.Text + "' city='" + TextBox4.Text + "' state='" + TextBox5.Text + "' mobile='" + TextBox6.Text + "' where email='" + Session["user"].ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("payment_getway.aspx");
        }
    }
}