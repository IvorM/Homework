using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment01.DB;

namespace Assignment01
{
    public partial class InsertCountry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddCountry_Click(object sender, EventArgs e)
        {
            try
            {
                if (Repository.InsertCountry(tbCountryName.Text)>0)
                {
                    lblInfo.Text ="Added country "+ tbCountryName.Text + " to DB.";
                    tbCountryName.Text = "";
                }
            }
            catch (SqlException ex)
            {
                lblInfo.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }
    }
}