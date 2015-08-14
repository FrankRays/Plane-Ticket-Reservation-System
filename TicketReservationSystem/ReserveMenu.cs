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
    public partial class ReserveMenu : Form
    {

        OleDbConnection AirAsianDataBase;
        OleDbCommand oledbCmd = new OleDbCommand();
        string connectionString =
        @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Ray\Desktop\Plane-Ticket-Reservation-System\AirAsianDataBase.mdb";

        string custName;

        public ReserveMenu(string name)
        {
            custName = name;
            InitializeComponent();
        }

        private void ReserveMenu_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Welcome " + this.custName + " !");


            AirAsianDataBase = new OleDbConnection(connectionString);

            AirAsianDataBase.Open();

            string strSelect = "Select * from AirCraft";

            TripGridView.DataSource = null;
            TripGridView.Rows.Clear();
            TripGridView.Refresh();

            OleDbDataAdapter da = new OleDbDataAdapter( strSelect, AirAsianDataBase);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(da);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                TripGridView.Rows.Add(
                    dataTable.Rows[i][0],
                    dataTable.Rows[i][1],
                    dataTable.Rows[i][2],
                    dataTable.Rows[i][3],
                    dataTable.Rows[i][4],
                    dataTable.Rows[i][5]);
            }

            AirAsianDataBase.Close();





        }

      
    }
}
