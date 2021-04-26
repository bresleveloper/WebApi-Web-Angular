using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_Web_Angular
{
    public class exampleDB
    {
        private string connetionString = @"Data Source=.;Initial Catalog=example;Integrated Security=True"; 

        public DataTable GetPersons()
        {
            using (SqlConnection conn = new SqlConnection(connetionString))
            {
                using (SqlDataAdapter adp = new SqlDataAdapter("Select * From Person", conn))
                {
                    DataSet ds = new DataSet("GetPersons");
                    adp.Fill(ds);
                    return ds.Tables[0];
                }
            }

        }


    }
}