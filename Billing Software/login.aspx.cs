using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using Dapper;
using DapperExtensions;
using Npgsql;
using DapperExtensions.Sql;
using BillingSoftwareBLL.DAPPER;
namespace Billing_Software
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            error.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var cn = new NpgsqlConnection(ConfigurationManager.AppSettings["dbconnection"]))
            {
                cn.Open();
                try
                {
                    var query = "select password from login where username=@userS";
                    var result = cn.Query<loginClass>(query, new { userS = usernameInput.Text.Trim() }).Single<loginClass>();
                    var d = result.password;
                    if(d.ToString() == password.Text.Trim())
                    {
                        Session["username"] = usernameInput.Text.Trim();
                        Response.Redirect("home.aspx");
                    }
                    else
                    {
                        error.Visible = true;
                    }
                }
                catch
                {
                    error.Visible = true;
                }
            }

        }
    }
}