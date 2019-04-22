using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel_Default : System.Web.UI.Page 
{
    SqlConnection conn = new SqlConnection(@"Data Source=LAB4PC-2\STUDENT;Initial Catalog=safe_city;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            fetchDAta();
        }
    }
    public void fetchDAta()
    {
        conn.Open();

        string query = "select * from users where  not roles= 'Admin' and approve = 'Not Approve'  ";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();

        conn.Close();
    }

    

     



    protected void LinkButton2_Click(object sender, EventArgs e)
    {

    }
    
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow dRow = GridView1.Rows[e.RowIndex];
        Label lbl = dRow.FindControl("Label2") as Label;
        Label lbl3 = dRow.FindControl("Label3") as Label;
        string em = lbl3.Text;
        conn.Open();
        SqlDataAdapter _dAdapter = new SqlDataAdapter("UPDATE users SET approve = 'Approved' WHERE UserId = @ID", conn);
        _dAdapter.SelectCommand.Parameters.AddWithValue("@ID", lbl.Text);
        _dAdapter.SelectCommand.ExecuteNonQuery();
        
        conn.Close();

        MailMessage mail = new MailMessage();
        mail.To.Add(em);
       // mail.To.Add("maaz1709a@aptechsite.net");
        mail.From = new MailAddress("safecity07@gmail.com.com");
        mail.Subject = "Registration Approval";

        string Body = "Congratulations you are now registered in safe city" +
                      "using this this Plateform you can share your stories with us and spread awareness";
        mail.Body = Body;

        mail.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
        smtp.Credentials = new System.Net.NetworkCredential
             ("safecity07@gmail.com", "usama123456");
        //Or your Smtp Email ID and Password
        smtp.EnableSsl = true;
        smtp.Send(mail);

        fetchDAta();


      

        Response.Redirect("~/AdminPanel/Approveusers.aspx");
       



    }


}