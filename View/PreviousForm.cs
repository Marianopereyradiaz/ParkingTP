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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            movements.AddAllMovements(movementsManager.ReturnMovements());
            foreach (Movement movement in movements.ReturnAllMovements())
            {
                listBox2.Items.Add("$"+movement.Amount + " " + movement.Concept + " " + movement.Date + " " + movement.user.UserName);
            }

        }
    }
}
