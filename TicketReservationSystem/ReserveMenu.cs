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


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
