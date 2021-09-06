using  System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace system_on_rent.admin
{
   
    public partial class add_product : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BBSO535\SQLSERVER;Initial Catalog=SOR;Integrated Security=True");
        string a, b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            a = Class1.GetRandomPassword(10).ToString();
            img1.SaveAs(Request.PhysicalApplicationPath + "./images/" + a + img1.FileName.ToString());
            b = "/images/" + a + img1.FileName.ToString();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into product values('" + T1.Text + "','" + T2.Text + "'," + T3.Text + "," + T4.Text + ",'" + b.ToString() + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        

    }
}