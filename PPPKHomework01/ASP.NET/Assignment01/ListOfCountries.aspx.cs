using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment01.DB;
using System.Data.SqlClient;

namespace Assignment01
{
    public partial class ListOfCountries : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopulateAListbox();
            }
            

        }

        private void PopulateAListbox()
        {
            lbCountry.Items.Clear();

            try
            {
                lbCountry.DataSource = Repository.GetCountries();
                lbCountry.DataTextField = "Name";
                lbCountry.DataValueField = "IDCountry";
                lbCountry.DataBind();
            }
            catch (SqlException e)
            {
                
                lblInfo.Text=e.Message;
            }
            catch (Exception e)
            {
                lblInfo.Text = e.Message;
            }   
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int numberOfDeletedCountries=0;
            try
            {
                if ((numberOfDeletedCountries+=Repository.DeleteCountries(lbCountry))>0)
                {
                    if (numberOfDeletedCountries==1)
                    {
                        lblInfo.Text = "Deleted 1 country!";
                    }
                    else
                    {
                        lblInfo.Text = "Deleted " + numberOfDeletedCountries + " countries!";
                    }
                    
                    lbCountry.Items.Clear();
                    PopulateAListbox();
                }
            }
            catch (SqlException ex)
            {
                
                lblInfo.Text=ex.Message;;
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }   
        }
    }
}