using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTopDesk.Logic;
using ProjectTopDesk.Model;

namespace ProjectTopDesk
{
    public partial class TopDesk : Form
    {
        User CurrentUser;
        private IncidentController incidentController;
        private UserManagementController userManagementController;

        public TopDesk(User CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            incidentController = new IncidentController();
            userManagementController = new UserManagementController();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCurrentFirstName.Text = CurrentUser.firstName;
            lblCurrentLastName.Text = CurrentUser.lastName;
            lblCurrentEmail.Text = CurrentUser.email;
            lblCurrentPhone.Text = CurrentUser.phoneNumber;
        }

        private void btnUpdateUserData_Click(object sender, EventArgs e)
        {
            User user = new User();

            //get new data
            string newFirstName = textBoxFirstName.Text;
            string newLastName = textBoxLastName.Text;
            string newEmail = textBoxEmail.Text;
            string newPhone = textBoxPhone.Text;
            

            //gooi dit in een aparte methode (validate data)
            if (string.IsNullOrEmpty(newFirstName))
            {
                newFirstName = lblCurrentFirstName.Text;
            }

            if (string.IsNullOrEmpty(newLastName))
            {
                newLastName = lblCurrentLastName.Text;
            }

            if (string.IsNullOrEmpty(newEmail)) // REGEX check 
            {
                newEmail = lblCurrentEmail.Text;
            }

            if (string.IsNullOrEmpty(newPhone)) // REGEX check 
            {
                newPhone = lblCurrentPhone.Text;
            }

            //put data in user object
            user.firstName = newFirstName;
            user.lastName = newLastName;
            user.email = newEmail;
            user.phoneNumber = newPhone;

            //go to logic layer
            userManagementController.UpdateUser("5e6624de1c9d4400008a5134", user);

            //empty textboxes
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";

        }

        private void HidePanels()
        {
            foreach (var control in Controls)
                if (control is Panel)
                    ((Panel)control).Visible = false;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlDashboard.Visible = true;
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlChangeUserData.Visible = true;
        }

        private void pnlDashboard_VisibleChanged(object sender, EventArgs e)
        {
            int amountUnresolved = incidentController.getAmountUnresolvedIncidents();
            lblUnresolved.Text = amountUnresolved.ToString();
            pbUnresolved.Value = amountUnresolved;

            int totalIncidents = incidentController.getAmountTotalIncidents();
            lblTotalIncident.Text = totalIncidents.ToString();
            pbUnresolved.Maximum = totalIncidents;

            int lateIncidents = incidentController.getAmountLateIncidents();
            lblLateIncident.Text = lateIncidents.ToString();
            pbLate.Value = lateIncidents;
        }
    }
}
