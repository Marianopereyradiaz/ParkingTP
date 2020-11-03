using System;
using System.Windows.Forms;
using TP_Parking.Controllers;
using TP_Parking.View;

namespace TP_Parking
{
    public partial class ReportsForm : Form
    {
        private MonthRentalsController monthRentalsController;
        private HourRentalsController hourRentalsController;
        private Closings closings = new Closings();
        private Movements movements = new Movements();
        public ReportsForm(MonthRentalsController monthRentalsController, HourRentalsController hourRentalsController, Closings closings, Movements movements)
        {
            InitializeComponent();
            this.hourRentalsController = hourRentalsController;
            this.monthRentalsController = monthRentalsController;
            this.movements = movements;
            this.closings = closings;
        }

        private void buttonDailyRental_Click(object sender, EventArgs e)
        {
            DailyRentalsForm newDailyRentalForm = new DailyRentalsForm(monthRentalsController, hourRentalsController);
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
