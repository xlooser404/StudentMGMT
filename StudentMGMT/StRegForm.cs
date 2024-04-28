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
    public partial class StRegForm : Form
    {
        public StRegForm()
        {
            InitializeComponent();
            getStudentID();
        }

        // Sql Data Connection 
        private SqlConnection Connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shanr\\Downloads\\finalpro\\StudentMGMT\\StudentMGMT\\dbStudentMGMT.mdf;Integrated Security=True");
        // Sql Data Connection

        // Get Student ID 
        private void getStudentID()
        {
            Connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from RegistrationTbl", Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Clear(); // Clear existing data before loading new data
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Load(reader);
            cbId.ValueMember = "Id";
            cbId.DataSource = dataTable;
            Connection.Close(); ;
        }

        private void getStudentdetails()
        {
            if (cbId.SelectedIndex > -1) // Check if an item is selected
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shanr\\Downloads\\finalpro\\StudentMGMT\\StudentMGMT\\dbStudentMGMT.mdf;Integrated Security=True"))
                    {
                        connection.Open();
                        int selectedStID = int.Parse(cbId.SelectedValue.ToString()); // Convert to integer
                        using (SqlCommand cmd = new SqlCommand("Select * from RegistrationTbl where Id = @stID", connection))
                        {
                            cmd.Parameters.AddWithValue("@stID", selectedStID); // Use parameter for safe value assignment
                            DataTable dataTable = new DataTable();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0) // Check if data exists for selected ID  
                            {
                                DataRow dataRow = dataTable.Rows[0];
                                txtFName.Text = dataRow["FirstName"].ToString();
                                txtLName.Text = dataRow["LastName"].ToString();
                                dtpDOB.Text = dataRow["DOB"].ToString();
                                cbGender.Text = dataRow["Gender"].ToString();
                                txtAddress.Text = dataRow["Address"].ToString();
                                txtEmail.Text = dataRow["Email"].ToString();
                                txtMobileNum.Text = dataRow["MobileNum"].ToString();
                                txtHomeNum.Text = dataRow["HomeNum"].ToString();
                                txtParentName.Text = dataRow["ParentName"].ToString();
                                txtNIC.Text = dataRow["NIC"].ToString();
                                txtPNumber.Text = dataRow["ParentNum"].ToString();
                            }
                            else
                            {
                                // Handle case where no employee found (optional: display message)
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        // Clear Data Function
        private void Clear_Data()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            dtpDOB.Text = "";
            cbGender.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtMobileNum.Text = "";
            txtHomeNum.Text = "";
            txtParentName.Text = "";
            txtNIC.Text = "";
            txtPNumber.Text = "";
            txtFName.Focus();
        }

        // RegNo Selection Function Calling
        private void cbId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getStudentdetails();
        }

        // Registration Button Click Event
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate user input to ensure all fields are filled in
                if (string.IsNullOrEmpty(txtFName.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtHomeNum.Text) ||
                    string.IsNullOrEmpty(txtParentName.Text) ||
                    string.IsNullOrEmpty(txtAddress.Text) ||
                    string.IsNullOrEmpty(txtNIC.Text) ||
                    cbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shanr\\Downloads\\finalpro\\StudentMGMT\\StudentMGMT\\dbStudentMGMT.mdf;Integrated Security=True"))

                    // Open database connection
                    Connection.Open();

                // Create SQL command with parameters
                using (SqlCommand cmd = new SqlCommand("INSERT INTO RegistrationTbl (FirstName, LastName, DOB, Gender, Address, Email, MobileNum, HomeNum, ParentName, NIC, ParentNum) VALUES (@StFName, @StLName, @StDOB, @StGender, @StAdd, @StEmail, @StMobile, @StHome, @StParentN, @StNIC, @StPNumber)", Connection))
                {
                    // Add parameters with appropriate data types
                    cmd.Parameters.AddWithValue("@StFName", txtFName.Text);
                    cmd.Parameters.AddWithValue("@StLName", txtLName.Text);
                    cmd.Parameters.AddWithValue("@StDOB", dtpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@StGender", cbGender.Text);
                    cmd.Parameters.AddWithValue("@StAdd", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@StEmail", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@StMobile", txtMobileNum.Text);
                    cmd.Parameters.AddWithValue("@StHome", txtHomeNum.Text);
                    cmd.Parameters.AddWithValue("@StParentN", txtParentName.Text);
                    cmd.Parameters.AddWithValue("@StNIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@StPNumber", txtPNumber.Text);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Student: {ex.Message}");
                // Consider logging the error for debugging
            }
            finally
            {
                // Close database connection even in case of errors
                Connection.Close();
            }

            getStudentID(); // Refresh combo box after adding a student
            // Clear form fields for the next entry
            Clear_Data();
        }

        // Delete Button Click Event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbId.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a student to delete.");
                    return;
                }

                int selectedStID = int.Parse(cbId.SelectedValue.ToString());

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shanr\\Downloads\\finalpro\\StudentMGMT\\StudentMGMT\\dbStudentMGMT.mdf;Integrated Security=True"))
                {
                    // Open database connection
                    connection.Open();

                    // Create SQL command with parameters
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM RegistrationTbl WHERE Id = @stID", connection))
                    {
                        // Add parameter for student ID
                        cmd.Parameters.AddWithValue("@stID", selectedStID);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student deleted successfully.");
                            // Reload student IDs after deletion
                            getStudentID();
                            // Clear form fields after deletion
                            Clear_Data();
                        }
                        else
                        {
                            MessageBox.Show("No student found with the selected ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}");
                // Consider logging the error for debugging
            }
        }

        // Update Button Click Event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbId.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a student to update.");
                    return;
                }

                int selectedStID = int.Parse(cbId.SelectedValue.ToString());

                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\shanr\\Downloads\\finalpro\\StudentMGMT\\StudentMGMT\\dbStudentMGMT.mdf;Integrated Security=True"))
                {
                    // Open database connection
                    connection.Open();

                    // Create SQL command with parameters
                    using (SqlCommand cmd = new SqlCommand("UPDATE RegistrationTbl SET FirstName = @StFName, LastName = @StLName, DOB = @StDOB, Gender = @StGender, Address = @StAdd, Email = @StEmail, MobileNum = @StMobile, HomeNum = @StHome, ParentName = @StParentN, NIC = @StNIC, ParentNum = @StPNumber WHERE Id = @stID", connection))
                    {
                        // Add parameters with appropriate data types
                        cmd.Parameters.AddWithValue("@StFName", txtFName.Text);
                        cmd.Parameters.AddWithValue("@StLName", txtLName.Text);
                        cmd.Parameters.AddWithValue("@StDOB", dtpDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@StGender", cbGender.Text);
                        cmd.Parameters.AddWithValue("@StAdd", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@StEmail", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@StMobile", txtMobileNum.Text);
                        cmd.Parameters.AddWithValue("@StHome", txtHomeNum.Text);
                        cmd.Parameters.AddWithValue("@StParentN", txtParentName.Text);
                        cmd.Parameters.AddWithValue("@StNIC", txtNIC.Text);
                        cmd.Parameters.AddWithValue("@StPNumber", txtPNumber.Text);
                        cmd.Parameters.AddWithValue("@stID", selectedStID);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student details updated successfully.");
                            // Reload student IDs after update
                            getStudentID();
                            // Clear form fields after update
                            Clear_Data();
                        }
                        else
                        {
                            MessageBox.Show("No student found with the selected ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student details: {ex.Message}");
                // Consider logging the error for debugging
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear_Data();
        }

        private void liblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LognForm lognForm = new LognForm();
            lognForm.Show();
            this.Hide();
        }

        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
