using System;
using System.Web.Security;
using System.Data.SqlClient;

namespace WebFormsMain
{
    public partial class login : System.Web.UI.Page
    {
        private bool ValidateUser(string username, string password)
        {
            SqlConnection sqlConnection;
            SqlCommand cmd;
            string lookupPassword = null;

            try
            {
                sqlConnection = new SqlConnection("server=DESKTOP-EERLAR5\\SQLEXPRESS;database=database1;Integrated Security=SSPI;");
                sqlConnection.Open();

                cmd = new SqlCommand("select password from Users where username=@username", sqlConnection);
                cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 25);
                cmd.Parameters["@username"].Value = username;

                lookupPassword = (string)cmd.ExecuteScalar();

                cmd.Dispose();
                sqlConnection.Dispose();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("Error" + " " + ex.Message);
            }

            if (lookupPassword == null)
                return false;

            return (0 == string.Compare(lookupPassword, password, false));
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click1(object sender, EventArgs e)
        {
            if (ValidateUser(txtUsername.Text, txtPassword.Text))
            {
                Session["Username"] = txtUsername.Text;
                Response.Redirect("Newproduct.aspx");
            }
            else
                Response.Redirect("login.aspx", true);
        }
    }
}