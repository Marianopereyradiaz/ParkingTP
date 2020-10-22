using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Parking.View
{
    public partial class PreviousForm : Form
    {
        private XMLClosings closingsManager = new XMLClosings();
        private Closings closings = new Closings();
        private XMLMovements movementsManager = new XMLMovements();
        private Movements movements = new Movements();
        private XMLGarages garagesManager = new XMLGarages();
        private Parking parking = new Parking();
        private XMLRentals rentalsManager = new XMLRentals();
        private Rentals rentals= new Rentals();

        public PreviousForm()
        {
            InitializeComponent();
        }

        private void PreviousForm_Load(object sender, EventArgs e)
        {
            closings.AddAllClosings(closingsManager.ReturnClosings());
            foreach (Closing closing in closings.ReturnAllClosings())
            {
                listBox1.Items.Add(closing.Date+" "+closing.User.UserName);
            }
            parking.AddAllGarages(garagesManager.ReturnGarages());
            foreach (Garage garage in parking.ReturnAllGarages())
            {
                listBox3.Items.Add(garage.Number + " " + garage.State +" "+ garage.Vehicle.Domain);
            }
            rentals.AddAllRentals(rentalsManager.ReturnRentals());
            foreach (Rental rental in rentals.ReturnAllRentals())
            {
                listBox4.Items.Add(rental.Date + " " + rental.Garage.Number);
                DateTime dateTime = rental.Date.AddMonths(1);
                listBox5.Items.Add(dateTime);
                TimeSpan time = DateTime.Now - dateTime;
                if (time.Days < 35)
                {
                    listBox5.BackColor = Color.Red;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            movements.AddAllMovements(movementsManager.ReturnMovements());
            foreach (Movement movement in movements.ReturnAllMovements())
            {
                listBox2.Items.Add("$"+movement.Amount + " " + movement.Concept + " " + movement.Date + " " + movement.user.UserName);
            }
        }
    }
}
