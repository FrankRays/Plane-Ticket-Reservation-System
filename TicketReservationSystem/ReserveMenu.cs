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

        Customer theCust;
        string custName;
        string tripType = "Single";
        int numOfSeat =1;
        double charges;


        public ReserveMenu(string n)
        {
            custName = n;
            InitializeComponent();
        }

        private void ReserveMenu_Load(object sender, EventArgs e)
        {

     
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

        private void TripGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.TripGridView.Rows[e.RowIndex];

                txtPlaneCode.Text   = row.Cells[0].Value.ToString();
                txtOrigin.Text      = row.Cells[1].Value.ToString();
                txtDest.Text        = row.Cells[2].Value.ToString();
                txtDepTime.Text     = row.Cells[3].Value.ToString();
                txtArrTime.Text     = row.Cells[4].Value.ToString();
                txtPrices.Text      = row.Cells[5].Value.ToString();
            

            }

        }

        private void ComboNumTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            numOfSeat = Convert.ToInt32(ComboNumTicket.SelectedItem.ToString());
            charges = Convert.ToDouble(txtPrices.Text) * numOfSeat;
            txtCharges.Text = charges.ToString();
        }

   
        private void comboTripType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tripType = comboTripType.SelectedItem.ToString();
        }

        private void btnBuyTrip_Click(object sender, EventArgs e)
        {
            string planeCode = txtPlaneCode.Text;
            string origin = txtOrigin.Text;
            string dest = txtDest.Text;
            string depTime = txtDepTime.Text;
            string arrTime = txtArrTime.Text;
            double prices = Convert.ToDouble(txtPrices.Text);

            AirCraft custCraft = new AirCraft(planeCode, origin, dest, depTime, arrTime, prices);
            Trips custTrip = new Trips(custCraft, numOfSeat);
            Reservation custReserve = new Reservation(custTrip, theCust, tripType);

        }

    }
}
