using System;
using System.Windows.Forms;
using TP_Parking.Controllers;

namespace TP_Parking.View
{
    public partial class PreviousForm : Form
    {

        private ClosingsController closingsController = new ClosingsController();
        private MovementsController movementsController = new MovementsController();
        private ExceptionController exceptionController = new ExceptionController();
        public PreviousForm(ClosingsController closingsController, MovementsController movementsController)
        {
            InitializeComponent();
            this.movementsController = movementsController;
            this.closingsController = closingsController;
        }

        private void PreviousForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            while (i < closingsController.Get().ReturnAll().Count)
            {
                if (closingsController.Get().ReturnAll()[i].Date != DateTime.MinValue)
                {
                    dataGridViewPreviousClosing.Rows.Add(closingsController.Get().ReturnAll()[i].Date, closingsController.Get().ReturnAll()[i].User.UserName);
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }
        private void dataGridViewPreviousClosing_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double totalValue = 0;
                DateTime date;
                date = Convert.ToDateTime(dataGridViewPreviousClosing.CurrentCell.Value);
                dataGridViewMovements.Rows.Clear();
                labelTotalFromClosing.Text = " ";
                foreach (Movement movement in movementsController.Get().ReturnAll())
                {
                    if (movement.Closing.Date == date)
                    {
                        if (movement.IsEntry == false)
                        {
                            dataGridViewMovements.Rows.Add(movement.Concept, "", movement.Amount, movement.Date, movement.User.UserName);
                            totalValue -= movement.Amount;
                        }
                        else
                        {
                            totalValue += movement.Amount;
                            dataGridViewMovements.Rows.Add(movement.Concept, movement.Amount, "", movement.Date, movement.User.UserName);
                        }
                    }
                }
                labelTotalFromClosing.Text = ($"Total Cierre: ${totalValue}");
            }
            catch (Exception)
            {
                exceptionController.ShowMessage("Debe elegir el cierre por fecha");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalFromClosing_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
