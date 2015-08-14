using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TicketReservationSystem
{
    public partial class CustomerLogin : Form
    {
        OleDbConnection AirAsianDataBase;
        OleDbCommand oledbCmd = new OleDbCommand();
        string connectionString =
             //   @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jet\Desktop\Plane-Ticket-Reservation-System\AirAsianDataBase.mdb";
             @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ray\Desktop\Plane-Ticket-Reservation-System\AirAsianDataBase.mdb"; 

        public CustomerLogin()
        {
            InitializeComponent();
            AirAsianDataBase = new OleDbConnection(connectionString);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AirAsianDataBase.Open();
            try
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string contactnumber = txtHP.Text;
                string gender;

                if (MaleRadioButton.Checked == true)
                    gender = "Male";
                else
                    gender = "Female";

                int birthdayDate = Convert.ToInt16(comboBoxDate.SelectedItem.ToString());
                int birthdayMonth = Convert.ToInt16(comboBoxMonth.SelectedItem.ToString());
                int birthdayYear = Convert.ToInt16(comboBoxYear.SelectedItem.ToString());
                string membership = cboxCustType.SelectedItem.ToString();

                string insertstring = "Insert into Customer ([FullName], [Gender], [BirthdayDate], [BirthdayMonth], [BirthdayYear], [Contact], [Email], [MemberShip]) values (@name,@gender,@birthdayDate,@birthdayMoth,@birthdayYear,@contactnumber, @email, @membership)";

                oledbCmd.Connection = AirAsianDataBase;
                oledbCmd.CommandText = insertstring;
                oledbCmd.Parameters.AddWithValue("@name", name);
                oledbCmd.Parameters.AddWithValue("@gender", gender);
                oledbCmd.Parameters.AddWithValue("@birthdayDate", birthdayDate);
                oledbCmd.Parameters.AddWithValue("@birthdayMonth", birthdayMonth);
                oledbCmd.Parameters.AddWithValue("@birthdayYear", birthdayYear);
                oledbCmd.Parameters.AddWithValue("@contactnumber", contactnumber);
                oledbCmd.Parameters.AddWithValue("@email", email);
                oledbCmd.Parameters.AddWithValue("@membership", membership);

                int temp = oledbCmd.ExecuteNonQuery();

                if (temp > 0)
                    MessageBox.Show("Registered successfully!");
                else
                    MessageBox.Show("Error occured! Unable to register!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
       

            AirAsianDataBase.Close();                // close the connection to the database
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCustLogin_Click(object sender, EventArgs e)
        {
            AirAsianDataBase.Close();
         
          
            string strSelect = "Select * from Customer Where [FullName] = @custName";
            OleDbDataAdapter da = new OleDbDataAdapter(strSelect, AirAsianDataBase);
            da.SelectCommand.Parameters.AddWithValue("@custName", txtCustName.Text);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);
            
            DataTable dataTable = new DataTable();
                 
            da.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Welcome");
                this.Hide();
                 
                ReserveMenu r = new ReserveMenu(txtCustName.Text);
                r.ShowDialog();
            }
            else MessageBox.Show("Login Fail, please try again!");
   
            AirAsianDataBase.Close();
        }
    }
}
