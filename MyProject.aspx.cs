using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace WebApplication3
{
    public partial class MyProject : System.Web.UI.Page
    {
        SqlDataAdapter da;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-JCM7G8I\\SQLEXPRESS;Initial Catalog=Vaibhu;Integrated Security=True;User ID=DESKTOP-JCM7G8I");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [Vaibhu].[dbo].[Student]" +
                "([ID],[Name],[Phone],[Address]) VALUES ('" + txtID.Text + "','" + txtName.Text + "','" + txtPhone.Text + "','" + txtAdd.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("data inserted successfully");
                con.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-JCM7G8I\\SQLEXPRESS;Initial Catalog=Vaibhu;Integrated Security=True;User ID=DESKTOP-JCM7G8I");
                SqlCommand cmd = new SqlCommand(@"DELETE FROM[Vaibhu].[dbo].[Student]
                WHERE [ID]='" + txtID.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("data deleted successfully");
                con.Close();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-JCM7G8I\\SQLEXPRESS;Initial Catalog=Vaibhu;Integrated Security=True;User ID=DESKTOP-JCM7G8I");
                SqlCommand cmd = new SqlCommand("UPDATE [Vaibhu].[dbo].[Student]   SET [ID] = '" + txtID.Text + "',[Name] = '" + txtName.Text + "',[Phone] = '" + txtPhone.Text + "',[Address] = '" + txtAdd.Text + "' WHERE [ID]='" + txtID.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("data updated successfully");
                con.Close();
            
        }

        protected void btnfetchall_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JCM7G8I\\SQLEXPRESS;Initial Catalog=Vaibhu;Integrated Security=True;User ID=DESKTOP-JCM7G8I");
            da = new SqlDataAdapter("select * from Student;", con);
            dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btngo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-JCM7G8I\\SQLEXPRESS;Initial Catalog=Vaibhu;Integrated Security=True;User ID=DESKTOP-JCM7G8I");
            int ID = Convert.ToInt32(txtID.Text);

            da = new SqlDataAdapter("select * from Student WHERE ID="+ID+"", con);
            dt = new DataTable();   
            da.Fill(dt);

            txtID.Text = dt.Rows[0][0].ToString();
            txtName.Text = dt.Rows[0][1].ToString();
            txtPhone.Text = dt.Rows[0][2].ToString();
            txtAdd.Text = dt.Rows[0][3].ToString();

            GridView1.DataSource = dt;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
