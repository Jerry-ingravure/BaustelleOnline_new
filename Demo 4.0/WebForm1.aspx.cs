using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Demo_4._0
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridview();
            }
        }

        private void BindGridview()
        {
          using (SqlConnection con = new SqlConnection("Data Source=h2732830.stratoserver.net\\UI4INFINITY;Initial Catalog=ingravure;Persist Security Info=True;User ID=ingravure;Password=0yCl3PL4EYXK076QQJxt"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select TOP 10 material,supplier,qty FROM po_avise_view", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataBind();
                    con.Close();
                

            }
        }
    }
}