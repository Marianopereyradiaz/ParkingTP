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
        private XMLMonthRentals monthRentalsManager = new XMLMonthRentals();
        private MonthRentals monthRentals= new MonthRentals();
        private HourRentals hourRentals = new HourRentals();
        public PreviousForm()
        {
            InitializeComponent();
        }

        private void PreviousForm_Load(object sender, EventArgs e)
        {
            closings.AddAllClosings(closingsManager.ReturnClosings());
            foreach (Closing closing in closings.ReturnAllClosings())
            {
                dataGridViewPreviousClosing.Rows.Add(closing.Date,closing.User.UserName);
            }
            parking.AddAllGarages(garagesManager.ReturnGarages());


            monthRentals.AddAllRentals(monthRentalsManager.ReturnRentals());

        }
        private void dataGridViewPreviousClosing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMovements.Rows.Clear();
            movements.AddAllMovements(movementsManager.ReturnMovements());
            foreach (Movement movement in movements.ReturnAllMovements())
            {
                if (movement.IsEntry == false)
                {
                    movement.Amount = -movement.Amount;
                }
                dataGridViewMovements.Rows.Add(movement.Concept,  movement.Amount, movement.Date, movement.user.UserName);
            }
        }

    }
}
