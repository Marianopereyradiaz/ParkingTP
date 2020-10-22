using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Parking.View;

namespace TP_Parking
{
    public partial class ReportsForm : Form
    {
        private Rentals rentals;
        public ReportsForm(Rentals rentals)
        {
            InitializeComponent();
            this.rentals = rentals;
        }

        private void buttonDailyRental_Click(object sender, EventArgs e)
        {
            DailyRentalsForm newDailyRentalForm = new DailyRentalsForm(rentals);
            newDailyRentalForm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreviousForm previousForm = new PreviousForm();
            previousForm.ShowDialog();
        }
    }
}
