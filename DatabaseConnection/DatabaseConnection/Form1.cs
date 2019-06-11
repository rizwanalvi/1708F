namespace DatabaseConnection
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data.SqlClient;
    using System.Configuration;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlString = ConfigurationManager.ConnectionStrings["dbConnect"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(sqlString);
            if (sqlconn.State == ConnectionState.Closed)
                sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * from Mobile", sqlconn);
            SqlDataReader dReader = _cmd.ExecuteReader();
            while (dReader.Read()) {

                dataGridView1.Rows.Add(new object[] { dReader["ID"], dReader["NAME"] });
            }
               

        }
        private void button2_Click(object sender, EventArgs e)
        {
            String sqlString = ConfigurationManager.ConnectionStrings["dbConnect"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(sqlString);
            if (sqlconn.State == ConnectionState.Closed)
                sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("SELECT * from Mobile WHERE ID = @id", sqlconn);
            _cmd.Parameters.AddWithValue("@id",textBox1.Text);
            SqlDataReader dReader = _cmd.ExecuteReader();
            while (dReader.Read())
            {

                dataGridView1.Rows.Add(new object[] { dReader["ID"], dReader["NAME"] });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sqlString = ConfigurationManager.ConnectionStrings["dbConnect"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(sqlString);
            if (sqlconn.State == ConnectionState.Closed)
                sqlconn.Open();
            SqlCommand _cmd = new SqlCommand("DELETE from Mobile WHERE ID = @id", sqlconn);
            _cmd.Parameters.Add("@id", textBox2.Text);
            _cmd.ExecuteNonQuery();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String s = ConfigurationManager.ConnectionStrings["dbConnect"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(s);
            if (sqlconn.State == ConnectionState.Closed)
                sqlconn.Open();
            String query = "INSERT INTO MOBILE(NAME,BRAND,MODEL) VALUES(@MN,@BR,@MO)";
            SqlCommand _cmd = new SqlCommand(query, sqlconn);
            _cmd.Parameters.AddWithValue("@MN",txtName.Text);
            _cmd.Parameters.AddWithValue("@BR", cmbBrand.SelectedItem.ToString());
            _cmd.Parameters.Add("@MO",txtModel.Text);
            _cmd.ExecuteNonQuery();

        }
    }
}
