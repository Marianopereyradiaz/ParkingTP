using System;
using System.Windows.Forms;


namespace TP_Parking
{
    public partial class DailyRentalsForm : Form
    {
        private Rentals rentals;

        public DailyRentalsForm(Rentals rentals)
        {
            InitializeComponent();
            this.rentals = rentals;

        }

        private void DailyRentalsForm_Load(object sender, EventArgs e)
        {

            foreach (Rental r in rentals.ReturnAllRentals())
            {
                string rentalType = "";
                string finish = "";
                double value;
                if (r is HourRental)
                {
                    HourRental hr = (HourRental)r;
                    rentalType = "Hora";
                    value = hr.Value;
                    if (Convert.ToString(hr.Finish) != "1/1/0001 00:00:00")
                    {
                        finish = Convert.ToString(hr.Finish);

                    }
                    else
                    {
                        finish = "-";
                    }
                    this.dataGridViewDaily.Rows.Add(r.Garage.Number, rentalType, r.Garage.Vehicle.VehicleType.Description, r.Garage.Vehicle.Domain, r.Date, finish, "$" + value, "");

                }
                else
                {
                    MonthRental mr = (MonthRental)r;
                    rentalType = "Mes";
                    finish = Convert.ToString(mr.ExpirationDate);
                    value = mr.newCalculateAmount(mr.Garage.Vehicle.VehicleType);
                    this.dataGridViewDaily.Rows.Add(r.Garage.Number, rentalType, r.Garage.Vehicle.VehicleType.Description, r.Garage.Vehicle.Domain, r.Date, finish, value, mr.Owner);
                }

            }
        }
        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
