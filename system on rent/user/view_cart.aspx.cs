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
    public partial class view_cart : System.Web.UI.Page
    {
        string s, t;
        string[] a = new string[6];
        int tot = 0;
        int r,d,total,rent=0;

        protected void b1_Click(object sender, EventArgs e)
        {
            Session["checkoutbutton"] = "yes";
            Response.Redirect("checkout.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
            {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[7] { new DataColumn("product_name"), new DataColumn("product_desc"), new DataColumn("product_price"), new DataColumn("product_qty"), new DataColumn("product_images"), new DataColumn("id"), new DataColumn("product_id") });
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


                       // dt.Rows.Add(a[0], a[1], a[2], a[3], a[4], i.ToString(), a[5]);
                        dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), i.ToString(), a[5].ToString());
                        tot = tot + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString()));
                        d = tot * 50 / 100;
                        rent = tot * 10 / 100;
                        total = rent + d;
                     
                       
                    }
                }
               // Session["DataGridview"] = dt;
                dlgridview.DataSource = dt;
                dlgridview.DataBind();
                // dl.DataSource = dt;
                //dl.DataBind();
               // DateTime dt = new DateTime();
                Session["pdate"] = TextBox1.Text;
                DateTime t= DateTime.Parse(TextBox1.Text);
                Session["rentdate"] = t.AddMonths(Convert.ToInt32(TextBox2.Text));
                r = rent *Convert.ToInt32( TextBox2.Text);
                Label2.Text =  d.ToString() + "  is a deposit money and monthly rent is " +rent.ToString()+"<br/>" +TextBox2.Text+"months rent is  "+r.ToString();
                
            }

        }
        
    }
}