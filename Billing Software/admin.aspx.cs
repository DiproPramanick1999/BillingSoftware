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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static List<productDapper> getProducts()
        {
            using (var cn = new NpgsqlConnection(ConfigurationManager.AppSettings["dbconnection"]))
            {
                cn.Open();
                var query = "select * from product where id>@ids;";
                var result = cn.Query<productDapper>(query, new { ids = 0 });
                var d = result;
                return d.ToList();
            }
        }
        [System.Web.Services.WebMethod]
        public static string deleteName(string id)
        {
            System.Diagnostics.Debug.WriteLine(id);
            using (var cn = new NpgsqlConnection(ConfigurationManager.AppSettings["dbconnection"]))
            {
                cn.Open();
                Int32 id_int = Convert.ToInt32(id);
                var query = "delete from product where id=@ids;";
                var result = cn.Execute(query, new { ids = id_int });
            }
            return "success";
        }
        
    }
}