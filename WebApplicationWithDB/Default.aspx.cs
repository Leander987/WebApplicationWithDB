using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplicationWithDB
{
    public partial class Default : System.Web.UI.Page
    {


        protected void ButtonTestValg_Click(object sender, EventArgs e)
        {
            SqlParameter param;
            var connentionString = ConfigurationManager.ConnectionStrings["valg"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connentionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(Stemme.Pid) AS antstemmer, Parti.Parti\r\nFROM   Stemme INNER JOIN\r\n             Parti ON Stemme.Pid = Parti.Pid\r\nGROUP BY Stemme.Pid, Parti.Parti", conn);
                cmd.CommandType = CommandType.Text;

                //param = new SqlParameter("@fornavn", SqlDbType.NVarChar);
                //param.Value = TextBoxForNavn.Text;
                //cmd.Parameters.Add(param);
                

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                conn.Close();
            }

            GridView1.DataSource = dt;
            GridView1.DataBind();
             
        }

        protected void ButtonStem_Click(object sender, EventArgs e)
        {
            SqlParameter param;
            var connentionString = ConfigurationManager.ConnectionStrings["valg"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connentionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO stemme (pid, kid) VALUES (@pid, @kid)", conn);
                cmd.CommandType = CommandType.Text;

                param = new SqlParameter("@pid", SqlDbType.Int);
                param.Value = DropDownListParti.SelectedValue;
                cmd.Parameters.Add(param);

                param = new SqlParameter("@kid", SqlDbType.Int);
                param.Value = 1;
                cmd.Parameters.Add(param);


                cmd.ExecuteNonQuery();

                conn.Close();
            }
            ButtonStem.Visible=false;
            LabelUserMsg.Text = "Takk for deltagelsen";
            LabelUserMsg.Visible = true;
        }
    }
}