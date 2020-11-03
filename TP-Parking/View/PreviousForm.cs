using System;
using System.Windows.Forms;

namespace TP_Parking.View
{
    public partial class PreviousForm : Form
    {

        private Closings closings = new Closings();
        private Movements movements = new Movements();
        private DateTime date;
        private ExceptionController exceptionController = new ExceptionController();
        public PreviousForm(Closings closings, Movements movements)
        {
            InitializeComponent();
            this.movements = movements;
            this.closings = closings;
        }

        private void PreviousForm_Load(object sender, EventArgs e)
        {
            foreach (Closing closing in closings.ReturnAll())
            {
                dataGridViewPreviousClosing.Rows.Add(closing.Date, closing.User.UserName);
            }
        }
        private void dataGridViewPreviousClosing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double totalValue = 0;
                date = Convert.ToDateTime(dataGridViewPreviousClosing.CurrentCell.Value);
                dataGridViewMovements.Rows.Clear();
                labelTotalFromClosing.Text = " ";
                foreach (Movement movement in movements.ReturnAll())
                {
                    if (movement.Closing.Date == date)
                    {
                        if (movement.IsEntry == false)
                        {
                            movement.Amount = -movement.Amount;
                        }
                        totalValue += movement.Amount;
                        dataGridViewMovements.Rows.Add(movement.Concept, movement.Amount, movement.Date, movement.User.UserName);
                    }
                }
                labelTotalFromClosing.Text = ($"Total Cierre: ${totalValue}");
            }
            catch (Exception)
            {
                exceptionController.ShowMessage("Debe elegir el cierre por fecha");
            }
        }

    }
}
