using Programming_Assignment5;
using System;
using System.Windows.Forms;

namespace Programming_Assignment4
{
    public partial class MainForm : Form
    {
        
        private EventManager eventManager;
        
        public MainForm()
        { 
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Function is preparing application for start, 
        /// clearing the inputs and setting start values for the results 
        /// and making sure the "add guest" box is locked.
        /// </summary>
        private void InitializeGUI()
        {
            eventManager = new EventManager();
            Text = "Event Organizer By Aliaksandr Straltsou";
            groupAddGuest.Enabled = false;
            btnSaveChanges.Enabled = false;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEventTitle.Clear();
            txtCostPerPerson.Clear();
            txtFeePerPerson.Clear();
            outLabelNumGuests.Text = "0";
            outLabelTotalCost.Text = "0.00";
            outLabelTotalFees.Text = "0.00";
            outLabelSurplusDeficit.Text = "0.00";
        }
   
        /// <summary>
        /// Function for creating a list which is firstly trying to parse the users inputs then
        /// after successfull parsing and validation creating a new list, unlocking "add guest" box and clearing the UI
        /// If inputs are invalid user will be noticed about the error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateList_Click(object sender, EventArgs e)
        {
            // Validating and parsing inputs
            try
            {
                if (string.IsNullOrWhiteSpace(txtEventTitle.Text))
                {
                    MessageBox.Show("Title Of Event Is Required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                eventManager.Title = txtEventTitle.Text;
                eventManager.CostPerPerson = double.TryParse(txtCostPerPerson.Text, out double cost) ? cost : 0.0;
                eventManager.FeePerPerson = double.TryParse(txtFeePerPerson.Text, out double fee) ? fee : 0.0;

                //Enabling Add Participant Box Area
                groupAddGuest.Enabled = true;

                // Pop-Up Message that confirms that the event is succesfully created
                MessageBox.Show($"Event created successfully.", "Success");
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Function for adding a new guest to the list as soon as Add button is clicked and inputs are validated
        /// After successfull attemt the guest list and summary will be updated according to changes in event manager
        /// Input fields are also cleared after submitting the guest info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            try
            {
                var address = new Address(textBoxStreet.Text, textBoxCity.Text, textBoxZipCode.Text, (Countries)comboBoxCountry.SelectedIndex);
                var participant = new Participant(txtFirstName.Text, txtLastName.Text, address);
                eventManager.Participants.AddParticipant(participant);
                UpdateGUI();
                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Function for removing "selected" guest from the list as soon as Remove button in UI is clicked
        /// After successfull attemt the guest list and summary will be updated according to changes in event manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveGuest_Click(object sender, EventArgs e)
        {
           
            if (lstGuests.SelectedIndex >= 0)
            {
                eventManager.Participants.RemoveParticipant(lstGuests.SelectedIndex);
                UpdateGUI();
                UpdateSummary();
            }
            else
            {
                MessageBox.Show("Please select a participant to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Function for enabling editing process as soon as participant is selected and edit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            // Ensure a participant is selected
            if (lstGuests.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a participant to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Getting the selected participant index
            int selectedIndex = lstGuests.SelectedIndex;

            // Fetching the participant
            Participant selectedParticipant = eventManager.Participants.GetParticipantAt(selectedIndex);

            if (selectedParticipant != null)
            {
                //Loading current data of selected participant in into inputs for editing
                txtFirstName.Text = selectedParticipant.FirstName;
                txtLastName.Text = selectedParticipant.LastName;
                textBoxStreet.Text = selectedParticipant.Address.Street;
                textBoxCity.Text = selectedParticipant.Address.City;
                textBoxZipCode.Text = selectedParticipant.Address.ZipCode;
                comboBoxCountry.SelectedItem = selectedParticipant.Address.Country;
            }
            btnSaveChanges.Enabled = true;
        }

        /// <summary>
        /// Function for saving changes during editing of participants details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstGuests.SelectedIndex;

            if (MessageBox.Show("Do you want to save changes?", "Edit Participant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Participant updatedParticipant = new Participant(
                    txtFirstName.Text,
                    txtLastName.Text,
                    new Address(
                        textBoxStreet.Text,
                        textBoxCity.Text,
                        textBoxZipCode.Text,
                        (Countries)Enum.Parse(typeof(Countries), comboBoxCountry.SelectedItem.ToString())
                    )
                );
                eventManager.Participants.UpdateParticipant(selectedIndex, updatedParticipant);
                MessageBox.Show("Participant updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            UpdateGUI();
            btnSaveChanges.Enabled = false;
        }

        /// <summary>
        /// Updating and cleraring data in inputs and participants list
        /// </summary>
        private void UpdateGUI()
        {
            lstGuests.Items.Clear();
            lstGuests.Items.AddRange(eventManager.Participants.GetParticipantsInfo().ToArray());
            txtFirstName.Clear();
            txtLastName.Clear();
            textBoxStreet.Clear();
            textBoxCity.Clear();
            textBoxZipCode.Clear();
            comboBoxCountry.SelectedIndex = -1;
        }

        /// <summary>
        /// Function for updating results according to recent changes
        /// </summary>
        private void UpdateSummary()
        {
            
            int numOfGuests = eventManager.Participants.Count;
            double surplusDeficit = eventManager.GetSurplusOrDeficit();
            double totalFees = eventManager.GetTotalFees();
            double totalCost = eventManager.GetTotalCost();

            outLabelNumGuests.Text = numOfGuests.ToString();
            outLabelTotalCost.Text = totalCost.ToString("N2");
            outLabelTotalFees.Text = totalFees.ToString("N2");
            outLabelSurplusDeficit.Text = surplusDeficit.ToString("N2");
        }
    }
}
