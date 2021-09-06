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
    public partial class product_desc : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BBSO535\SQLSERVER;Initial Catalog=SOR;Integrated Security=True");
        int id,qty;
        string product_name, product_des, product_price, product_qty,product_images;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null && Request.QueryString["id"] != "" )
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());

                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from product where p_id="+id+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
             
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                d2.DataSource = dt;
                d2.DataBind();

                con.Close();
               
            }
            else
            {
                Response.Redirect("display_item.aspx");
            }
            qty = get_qty(id);
            if (qty==0)
            {
                l2.Visible = false;
                t1.Visible = false;
                b1.Visible = false;
                l1.Text = "there is no available quantity of this system ";


            }
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();

            }
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product where p_id=" + id +"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                product_name = dr["product_name"].ToString();
                product_des = dr["product_desc"].ToString();
                product_price = dr["product_price"].ToString();
                product_qty = dr["product_qty"].ToString();
                product_images = dr["product_images"].ToString();
                
            }

            con.Close();


            if (Convert.ToInt32( t1.Text) >Convert.ToInt32( product_qty))
            {
                l1.Text = "plzzz  enter available quantity";




            }
            else
             {
                l1.Text = "";
                if (Request.Cookies["cart"] == null)
                {
                   
                    Response.Cookies["cart"].Value = product_name.ToString() + "&" + product_des.ToString() + "&" + product_price.ToString() + "&" + t1.Text + "&" + product_images.ToString()+"&"+id.ToString();
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(1);
                }
                else
                {
                    Response.Cookies["cart"].Value = Request.Cookies["cart"].Value + "|" + product_name.ToString() + "&" + product_des.ToString() + "&" + product_price.ToString() + "&" + t1.Text + "&" + product_images.ToString() + "&" + id.ToString();
                    Response.Cookies["cart"].Expires = DateTime.Now.AddDays(1);
                }
                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update product set product_qty=product_qty-"+t1.Text+"where p_id="+id+"";
                cmd1.ExecuteNonQuery();
                Response.Redirect("product_desc.aspx?id="+id.ToString()+"");
            }
        }
        public int get_qty(int id)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product where p_id=" + id + " ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                qty = Convert.ToInt32(dr["product_qty"].ToString());

            }
            return qty;
            }
    }
}