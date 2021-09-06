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
    public partial class payment_success : System.Web.UI.Page
    {
        SqlConnection conn= new SqlConnection(@"Data Source=DESKTOP-BBSO535\SQLSERVER;Initial Catalog=SOR;Integrated Security=True");
        string s, t;
        string oldorder = "";
        string order = "";
        string order_id,oldorder_id;
        string[] a = new string[6];
        int count = 0; 
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            oldorder = Request.QueryString["order_no"].ToString();
            order = Request.QueryString["order_no"].ToString();
            if (order == Session["order_no"].ToString())
            { 
                    SqlCommand cmd = conn.CreateCommand();

                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from registration where email='" + Session["user"].ToString() + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        SqlCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = "insert into orders values('" + dr["firstname"].ToString() + "','" + dr["lastname"].ToString() + "','" + dr["email"].ToString() + "','" + dr["address"].ToString() + "','" + dr["city"].ToString() + "','" + dr["state"].ToString() + "','" + dr["pincode"].ToString() + "','" + dr["mobile"].ToString() + "','" + Session["pdate"].ToString() + "','" + Session["rentdate"].ToString() + "')";
                        cmd1.ExecuteNonQuery();



                    }



                SqlCommand cmd2 = conn.CreateCommand();

                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select top 1 * from orders where email='" + Session["user"].ToString() + "' order by id desc";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    order_id = dr2["id"].ToString();

                }

                //end of collecting order id

               
                    if (Request.Cookies["cart"] != null)
                    {
                        s = Convert.ToString(Request.Cookies["cart"].Value);
                        string[] sa = s.Split('|');
                        for (int i = 0; i < sa.Length; i++)
                        {
                            t = Convert.ToString(sa[i].ToString());
                            string[] st = t.Split('&');
                            for (int j = 0; j < st.Length; j++)
                            {
                                a[j] = st[j].ToString();

                            }

                            SqlCommand cmd3 = conn.CreateCommand();

                            cmd3.CommandType = CommandType.Text;
                            cmd3.CommandText = "insert into order_details values('" + order_id.ToString() + "','" + a[0].ToString() + "','" + a[2].ToString() + "','" + a[3].ToString() + "','" + a[4].ToString() + "','" + Session["pdate"].ToString() + "','" + Session["rentdate"].ToString() + "') ";
                            cmd3.ExecuteNonQuery();

                        }
                        
                    }


            }
            if( oldorder==Session["order_n"].ToString()  )
            {

                SqlCommand cmdo = conn.CreateCommand();

                cmdo.CommandType = CommandType.Text;
                cmdo.CommandText = "select top 1 * from orders where email='" + Session["user"].ToString() + "' order by id desc";
                cmdo.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmdo);
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    oldorder_id = dr2["id"].ToString();

                }



                SqlCommand cmd3 = conn.CreateCommand();

                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "update orders set pdate=rentdate , rentdate='" + Session["rentdate"].ToString() + "'where id=" + oldorder_id.ToString();
                cmd3.ExecuteNonQuery();


                SqlCommand cmd4 = conn.CreateCommand();

                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "update order_details set pdate=rentdate , rentdate='" + Session["rentdate"].ToString() + "'where order_id=" + oldorder_id.ToString();
                cmd4.ExecuteNonQuery();




            }

            else
            {
               

                Response.Redirect("login.aspx");


            }



            count = 1;
            conn.Close();
            Session["user"] = "";
            Session["pdate"] = "";
            Session["rentdate"] = "";

            Response.Cookies["cart"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["cart"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("display_item.aspx");

        }
    }
}