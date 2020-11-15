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
        private ClosingsController closingsController = new ClosingsController();
        private MovementsController movementsController = new MovementsController();
        public ReportsForm(MonthRentalsController monthRentalsController, HourRentalsController hourRentalsController, ClosingsController closingsController, MovementsController movementsController)
        {
            InitializeComponent();
            this.hourRentalsController = hourRentalsController;
            this.monthRentalsController = monthRentalsController;
            this.movementsController = movementsController;
            this.closingsController = closingsController;
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
            PreviousForm previousForm = new PreviousForm(closingsController, movementsController);
            previousForm.ShowDialog();
        }
    }
}
