using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservationSystem
{
    public partial class ReserveMenu : Form
    {
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
    }
}
