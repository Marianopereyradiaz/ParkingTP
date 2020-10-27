using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TP_Parking.View;

namespace TP_Parking
{
    public partial class ReportsForm : Form
    {
        private MonthRentals monthRentals;
        private HourRentals hourRentals;
        private Closings closings = new Closings();
        private Movements movements = new Movements();
        public ReportsForm(MonthRentals monthRentals, HourRentals hourRentals,Closings closings, Movements movements)
        {
            InitializeComponent();
            this.hourRentals = hourRentals;
            this.monthRentals = monthRentals;
            this.movements = movements;
            this.closings = closings;
        }

        private void buttonDailyRental_Click(object sender, EventArgs e)
        {
            DailyRentalsForm newDailyRentalForm = new DailyRentalsForm(monthRentals,hourRentals);
            newDailyRentalForm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPreviousClosings_Click(object sender, EventArgs e)
        {
            PreviousForm previousForm = new PreviousForm(closings, movements);
            previousForm.ShowDialog();
        }
    }
}
