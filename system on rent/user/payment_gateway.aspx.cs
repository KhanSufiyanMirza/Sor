using System;   
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace system_on_rent.user
{
    public partial class payment_gateway : System.Web.UI.Page
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-BBSO535\SQLSERVER;Initial Catalog=SOR;Integrated Security=True");
        string s, t;
        string[] a = new string[6];
        int tot = 0;
        string order_no,order_id;
        int deposite=0,count = 0;
        int rent = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (count == 0)
            {
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

                        rent = (rent + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString())))*10/100;
                        tot = tot + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString()));
                        deposite = (tot * 50 / 100)+rent;

                    }
                    Session["tot"] = deposite.ToString();
                }

                order_no = Class1.GetRandomPassword(10).ToString();
                Session["order_no"] = order_no.ToString();
                count = 1;
                Response.Write("<form action='https://wwww.sandbox.paypal.com/cgi-bin/websrc' method='post' name='buyCredits' id='buyCredits'>");
                Response.Write("<input type='hidden' name='cmd' value='_xclick'>");
                Response.Write("<input type='hidden' name='business' value='khansufiyanmirza@gmail.com'>");
                Response.Write("<input type='hidden' name='currency_code' value='INR'>");
                Response.Write("<input type='hidden' name='item_name' value='payment for rent'>");
                Response.Write("<input type='hidden' name='item_number' value='0'>");
                Response.Write("<input type='hidden' name='amount' value='" + Session["tot"].ToString() + "'>");
                Response.Write("<input type='hidden' name='return' value='http://localhost:52302/user/payment_success.aspx?order_no=" + order_no.ToString() + "'>");
                Response.Write("</form>");

                Response.Write("<script type='text/javascript'>");
                Response.Write("document.getElementById('buyCredits').submit();");
                Response.Write("</script>");
                //end
            }
            else
            {
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
                Session["tot"] = rent.ToString();
                Session["order_n"] = order_id.ToString();
                count = 1;
                Response.Write("<form action='https://wwww.sandbox.paypal.com/cgi-bin/websrc' method='post' name='buyCredits' id='buyCredits'>");
                Response.Write("<input type='hidden' name='cmd' value='_xclick'>");
                Response.Write("<input type='hidden' name='business' value='khansufiyanmirza@gmail.com'>");
                Response.Write("<input type='hidden' name='currency_code' value='INR'>");
                Response.Write("<input type='hidden' name='item_name' value='payment for rent'>");
                Response.Write("<input type='hidden' name='item_number' value='0'>");
                Response.Write("<input type='hidden' name='amount' value='" + Session["tot"].ToString() + "'>");
                Response.Write("<input type='hidden' name='return' value='http://localhost:52302/user/payment_success.aspx?order_no=" + order_id.ToString() + "'>");
                Response.Write("</form>");

                Response.Write("<script type='text/javascript'>");
                Response.Write("document.getElementById('buyCredits').submit();");
                Response.Write("</script>");



            }
        }
    }
}