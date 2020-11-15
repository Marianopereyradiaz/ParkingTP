using System;
using System.Windows.Forms;
using TP_Parking.Controllers;

namespace TP_Parking
{
    public partial class DailyRentalsForm : Form
    {
        private MonthRentalsController monthRentalsController;
        private HourRentalsController hourRentalsController;
        public DailyRentalsForm(MonthRentalsController monthRentalsController, HourRentalsController hourRentalsController)
        {
            InitializeComponent();
            this.hourRentalsController = hourRentalsController;
            this.monthRentalsController = monthRentalsController;
        }
        private void DailyRentalsForm_Load(object sender, EventArgs e)
        {
            string rentalType = "";
            string finish = "";
            double value;
            DateTime now = DateTime.Now;
            foreach (HourRental hourRental in hourRentalsController.Get().ReturnAll())
            {
                if (now.Year == hourRental.Date.Year && now.Month == hourRental.Date.Month && now.Day == hourRental.Date.Day)
                {
                    rentalType = "Hora";
                    value = hourRental.Value;
                    if (Convert.ToString(hourRental.Finish) != "1/1/0001 00:00:00")
                    {
                        finish = Convert.ToString(hourRental.Finish);
                    }
                    else
                    {
                        finish = "-";
                    }
                    this.dataGridViewDaily.Rows.Add(hourRental.Garage.Number, rentalType, hourRental.Garage.Vehicle.VehicleType.Description, hourRental.Garage.Vehicle.Domain, hourRental.Date, finish, "$" + value, "-");
                }
            }
            foreach (MonthRental monthRental in monthRentalsController.Get().ReturnAll())
            {
                if (now.Year == monthRental.Date.Year && now.Month == monthRental.Date.Month && now.Day == monthRental.Date.Day)
                {
                    rentalType = "Mes";
                    finish = Convert.ToString(monthRental.ExpirationDate);
                    value = monthRental.CalculateAmount(monthRental.Garage.Vehicle.VehicleType);
                    this.dataGridViewDaily.Rows.Add(monthRental.Garage.Number, rentalType, monthRental.Garage.Vehicle.VehicleType.Description, monthRental.Garage.Vehicle.Domain, monthRental.Date, finish, value, monthRental.Owner);
                }
            }
        }
        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
