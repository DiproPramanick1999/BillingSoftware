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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Web.Services.WebMethod]
        public static string inserts (string item, string cost, string id)
        {
            string msg = id + "  " + item + "  " + cost;
            System.Diagnostics.Debug.WriteLine(msg);
            using (NpgsqlConnection cn = new NpgsqlConnection(ConfigurationManager.AppSettings["dbconnection"]))
            {
                cn.Open();
               Int32 id_int = Convert.ToInt32(id);
               Int32 cost_int = Convert.ToInt32(cost);

                string tanya = "insert into product (id) values(@ids);";
                string query = "insert into product(item) values(@items);";
                string dipro = "insert into product (cost) values(@costs);";

                int result2 = cn.Execute(tanya, new { ids = id_int });
                var result = cn.Execute(query, new { items = item });
                int result1 = cn.Execute(dipro, new { costs = cost_int });
                

            }
            return "succesfully added";
        }
    }
}