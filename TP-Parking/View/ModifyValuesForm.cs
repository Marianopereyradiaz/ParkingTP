using System;
using System.Windows.Forms;

namespace TP_Parking
{
    public partial class ModifyValuesForm : Form
    {
        public ModifyValuesForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyValuesForm_Load(object sender, EventArgs e)
        {
            textBoxNewPickUpValue.Text = ($"{HourRental.PickUpValue}");
            textBoxNewCarValue.Text = ($"{HourRental.CarValue}");
            textBoxNewMotorcycleValue.Text = ($"{HourRental.MotorcycleValue}");
            textBoxNewMonthHour.Text = ($"{MonthRental.MonthValue}");
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            HourRental.PickUpValue = Convert.ToDouble(textBoxNewPickUpValue.Text);
            HourRental.CarValue = Convert.ToDouble(textBoxNewCarValue.Text);
            HourRental.MotorcycleValue = Convert.ToDouble(textBoxNewMotorcycleValue.Text);
            MonthRental.MonthValue = Convert.ToDouble(textBoxNewMonthHour.Text);
            MessageBox.Show("Se modificaron valores", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
