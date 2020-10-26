using System;
using System.Windows.Forms;


namespace TP_Parking
{
    public partial class DailyRentalsForm : Form
    {
        private MonthRentals monthRentals;
        private HourRentals hourRentals;

        public DailyRentalsForm(MonthRentals monthRentals, HourRentals hourRentals)
        {
            InitializeComponent();
            this.hourRentals = hourRentals;
            this.monthRentals = monthRentals;

        }

        private void DailyRentalsForm_Load(object sender, EventArgs e)
        {
            string rentalType = "";
            string finish = "";
            double value;
            foreach (HourRental hourRental in hourRentals.ReturnAllRentals())
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
                this.dataGridViewDaily.Rows.Add(hourRental.Garage.Number, rentalType, hourRental.Garage.Vehicle.VehicleType.Description, hourRental.Garage.Vehicle.Domain, hourRental.Date, finish, "$" + value, "");
            }
            foreach (MonthRental monthRental in monthRentals.ReturnAllRentals())
            {         
                rentalType = "Mes";
                finish = Convert.ToString(monthRental.ExpirationDate);
                value = monthRental.CalculateAmount(monthRental.Garage.Vehicle.VehicleType);
                this.dataGridViewDaily.Rows.Add(monthRental.Garage.Number, rentalType, monthRental.Garage.Vehicle.VehicleType.Description, monthRental.Garage.Vehicle.Domain, monthRental.Date, finish, value, monthRental.Owner);
            }       
        }
        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
