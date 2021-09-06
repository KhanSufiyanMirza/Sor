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
    public partial class delete_cart : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BBSO535\SQLSERVER;Initial Catalog=SOR;Integrated Security=True");
        string s, t;
        string[] a = new string[6];
        int id;
        string product_name, product_des, product_price, product_qty, product_images, product_id;
        int count = 0;
        int qty;
        protected void Page_Load(object sender, EventArgs e)

        {
            id = Convert.ToInt32(Request.QueryString["id"].ToString());

            DataTable dt = new DataTable();
            dt.Rows.Clear();
            dt.Columns.AddRange(new DataColumn[7] { new DataColumn("product_name"), new DataColumn("product_desc"), new DataColumn("product_price"), new DataColumn("product_qty"), new DataColumn("product_image"), new DataColumn("id"), new DataColumn("product_id") });
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



                    dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), i.ToString(), a[5].ToString());



                }
            }

            count = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (count == id)
                {
                    product_id = dr["product_id"].ToString();
                    qty = Convert.ToInt32(dr["product_qty"].ToString());

                }
                count++;


            }
            count = 0;
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update product set product_qty=product_qty+" + qty.ToString() + "where p_id=" + product_id;
            cmd.ExecuteNonQuery();
            con.Close();





            //chnagge data
            //dt =(DataTable) Session["DataGridview"];
            dt.Rows.RemoveAt(id);

            Response.Cookies["cart"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["cart"].Expires = DateTime.Now.AddDays(-1);
            foreach (DataRow dr in dt.Rows)
            {
                product_name = dr["product_name"].ToString();
                product_des = dr["product_desc"].ToString();
                product_price = dr["product_price"].ToString();
                product_qty = dr["product_qty"].ToString();
                product_images = dr["product_image"].ToString();
                product_id = dr["product_id"].ToString();


                count = count + 1;
                if (count == 1)
                {
                    Response.Cookies["cart"].Value = product_name.ToString() + "&" + product_des.ToString() + "&" + product_price.ToString() + "&" + product_qty.ToString() + "&" + product_images.ToString() + "&" + product_id.ToString();
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(1);
                }
                else
                {

                    Response.Cookies["cart"].Value = Request.Cookies["cart"].Value + "|" + product_name.ToString() + "&" + product_des.ToString() + "&" + product_price.ToString() + "&" + product_qty.ToString() + "&" + product_images.ToString() + "&" + product_id.ToString();

                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(1);
                }
            }
            Response.Redirect("view_cart.aspx");

        }
    }
}  