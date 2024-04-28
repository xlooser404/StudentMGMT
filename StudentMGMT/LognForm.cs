using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMGMT
{
    public partial class LognForm : Form
    {
        public LognForm()
        {
            InitializeComponent();
        }

        // Sql Data Connection 
        private SqlConnection Connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shanr\\Downloads\\finalpro\\StudentMGMT\\StudentMGMT\\dbStudentMGMT.mdf;Integrated Security=True");
        // Sql Data Connection

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from LoginTbl where Username='" + txtUserName.Text + "'AND Password='" + txtPassword.Text + "'", Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Connection.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successfull");
                this.Hide();
                StRegForm stRegForm = new StRegForm();
                stRegForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error");
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
