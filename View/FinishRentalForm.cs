﻿using System;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class FinishRentalForm : Form
    {
        private User user;
        private int garageindex;
        private Movements movements;
        private Rental rental;
       public FinishRentalForm(int Igarage, Rental rental,Movements movements, User user)
        {
            this.user = user;
            this.garageindex = Igarage;
            this.rental = rental;
            this.movements = movements;
            InitializeComponent();
        }

        private void FormFinishRental_Load(object sender, EventArgs e)
        {
            LoadFinishRental();
        }

        private void LoadFinishRental()
        {
            var activevehicle = rental.Garage.Vehicle;
            FillVehicleData(activevehicle);
            if (rental is HourRental)
            {
                FillHourRental(activevehicle);
            }
            if (rental is MonthRental)
            {
                FillMonthRental();
            }
        }

        private void FillMonthRental()
        {
            var monthRental = (MonthRental)rental;
            labelFinish.Text = "Finish Date:";
            labelFinishDateShow.Text = ($"{monthRental.ExpirationDate}");
            labelAmount.Text = "Renovation value";
            labelValueShow.Text = ($"{monthRental.ExpirationDate}");
        }

        private void FillHourRental(Vehicle activevehicle)
        {
            var totalamount = CalculateHoursAndAmount(activevehicle);
            labelAmount.Text = "Value:";
            labelValueShow.Text = ($"${totalamount}");
        }

        private double CalculateHoursAndAmount(Vehicle activevehicle)
        {
            TimeSpan time = DateTime.Now - rental.Date;
            labelFinish.Text = "Elapsed Time:";
            labelFinishDateShow.Text = ($"{ time.Hours}hs { time.Minutes}min ");
            double hs = time.Hours;
            double mins = time.Minutes;
            if (mins >= 0)
            {
                hs += 1;
            }
            var hourRental = (HourRental)rental;
            double totalamount = (hourRental.newCalculateAmount(activevehicle.VehicleType) * hs);
            return totalamount;
        }

        private void FillVehicleData(Vehicle activevehicle)
        {
            labelDomain.Text = "Domain:";
            labelDomainShow.Text = ($"{activevehicle.Domain}");
            labelBrand.Text ="Brand:";
            labelBrandShow.Text = ($"{activevehicle.Brand}");
            labelModel.Text = "Model:";
            labelModelShow.Text = ($"{activevehicle.Model}");
            labelVehicleType.Text = "Vehicle Type:";
            labelVehicleTypeShow.Text = ($"{activevehicle.VehicleType.Description}");
            labelStart.Text = "From:";
            labelStartShow.Text = ($"{rental.Date}");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Movement newMovement = new Movement();
            rental.Garage.State = false;
            if (rental is HourRental)
            {
                HourRental hr = (HourRental)rental;
                hr.Value = CalculateHoursAndAmount(hr.Garage.Vehicle);
                hr.Finish = DateTime.Now;
                newMovement.Amount = hr.Value;
                newMovement.Concept = "Hour Rental - Domain:"+hr.Garage.Vehicle.Domain;
                newMovement.Date = hr.Finish;
                newMovement.IsEntry = true;
                newMovement.user = user;
                newMovement.user.UserName = user.UserName;
                newMovement.user.Password = user.Password;
                newMovement.user.LastAdmission = user.LastAdmission;
                newMovement.closing = null;
                movements.AddMovements(newMovement);
            }
            if (rental is MonthRental)
            {
                MonthRental mr = (MonthRental)rental;
                mr.Value = mr.newCalculateAmount(mr.Garage.Vehicle.VehicleType);               
            }
            
            this.Close();
        }
    }
}
