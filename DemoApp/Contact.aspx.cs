using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoApp
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSend_Click(object sender, EventArgs e)
        {
            InsertData(cfMsg.Name, cfMsg.Msg);
            lblOutput.Text = string.Format("User: {0} said: {1}", cfMsg.Name, cfMsg.Msg);
        }

        protected void InsertData(string Name, string Msg)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MsgDB"].ConnectionString;
            string insertRecord = "INSERT into Msgs (Name, MSg) values (@Name, @Msg)";

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (var sqlCommand = new SqlCommand(insertRecord, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("Name", Name);
                    sqlCommand.Parameters.AddWithValue("Msg", Msg);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}