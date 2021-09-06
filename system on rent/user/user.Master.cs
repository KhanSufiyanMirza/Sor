using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace system_on_rent.user
{
    public partial class user : System.Web.UI.MasterPage
    {
        string s, t;
        string[] a = new string[6];
        int tot = 0;
        int d, total;
        int totcount=0;

        protected void Page_Load(object sender, EventArgs e)
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

                    tot = tot + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString()));
                    d = tot * 40 / 100;
                    total = tot + d;
                    totcount = totcount + 1;
                    carttot.Text = totcount.ToString();
                    cartprice.Text = total.ToString();
                }
            }
        }
    }
}