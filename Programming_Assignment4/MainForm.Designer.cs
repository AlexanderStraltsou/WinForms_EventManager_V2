using Programming_Assignment5;

namespace Programming_Assignment4
{
    partial class MainForm
    {
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEventTitle;
        private TextBox txtCostPerPerson;
        private TextBox txtFeePerPerson;
        private Label outLabelNumGuests;
        private Label outLabelTotalCost;
        private Label outLabelTotalFees;
        private Label outLabelSurplusDeficit;
        private ListBox lstGuests;
        private Button btnCreateList;
        private Button btnSaveChanges;
        private GroupBox groupAddGuest;
        private TextBox textBoxStreet;
        private TextBox textBoxZipCode;
        private TextBox textBoxCity;
        private ComboBox comboBoxCountry;
        private Label labelStreet;
        private Label labelZipCode;
        private Label labelCity;
        private Label labelCountry;


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Text = "Event Organizer By Aliaksandr Straltsou";


            // Add New Event Box Area

            GroupBox groupNewEvent = new GroupBox
            {
                Text = "New Event",
                Location = new System.Drawing.Point(10, 15),
                Size = new System.Drawing.Size(270, 160)
            };

            Label lblMaxGuests = new Label
            {
                Text = "Event Title",
                Location = new System.Drawing.Point(10, 25)
            };
            this.txtEventTitle = new TextBox
            {
                Location = new System.Drawing.Point(150, 25),
                Width = 100,
                Name = "txtEventTitle"
            };

            Label lblCostPerPerson = new Label
            {
                Text = "Cost per person",
                Width = 130,
                Location = new System.Drawing.Point(10, 55)
            };
            this.txtCostPerPerson = new TextBox
            {
                Location = new System.Drawing.Point(150, 55),
                Width = 100,
                Name = "txtCostPerPerson"
            };

            Label lblFeePerPerson = new Label
            {
                Text = "Fee per person",
                Width = 130,
                Location = new System.Drawing.Point(10, 85)
            };
            this.txtFeePerPerson = new TextBox
            {
                Location = new System.Drawing.Point(150, 85),
                Width = 100,
                Name = "txtFeePerPerson"
            };

            Button btnCreateList = new Button
            {
                Text = "Create Event",
                Location = new System.Drawing.Point(10, 115),
                Width = 240,
                Height = 30,
                Name = "btnCreateList"
            };

            btnCreateList.Click += btnCreateList_Click;

            groupNewEvent.Controls.Add(lblMaxGuests);
            groupNewEvent.Controls.Add(txtEventTitle);
            groupNewEvent.Controls.Add(lblCostPerPerson);
            groupNewEvent.Controls.Add(txtCostPerPerson);
            groupNewEvent.Controls.Add(lblFeePerPerson);
            groupNewEvent.Controls.Add(txtFeePerPerson);
            groupNewEvent.Controls.Add(btnCreateList);
            this.Controls.Add(groupNewEvent);


            // Add New Guest Box Area
            this.groupAddGuest = new GroupBox
            {
                Text = "Add Guests",
                Location = new System.Drawing.Point(10, 200),
                Size = new System.Drawing.Size(270, 295),
                Name = "groupAddGuest",
                Enabled = false
            };

            Label lblFirstName = new Label
            {
                Text = "First Name",
                Location = new System.Drawing.Point(10, 40)
            };
            this.txtFirstName = new TextBox
            {
                Location = new System.Drawing.Point(110, 40),
                Width = 140,
                Name = "txtFirstName"
            };

            Label lblLastName = new Label
            {
                Text = "Last Name",
                Location = new System.Drawing.Point(10, 70)
            };
            this.txtLastName = new TextBox
            {
                Location = new System.Drawing.Point(110, 70),
                Width = 140,
                Name = "txtLastName"
            };


            Label lblStreet = new Label
            {
                Text = "Street",
                Location = new System.Drawing.Point(10, 100)
            };
            this.textBoxStreet = new TextBox
            {
                Location = new System.Drawing.Point(110, 100),
                Width = 140,
                Name = "textBoxStreet"
            };

            // Zip Code
            Label lblZipCode = new Label
            {
                Text = "Zip Code",
                Location = new System.Drawing.Point(10, 130)
            };
            this.textBoxZipCode = new TextBox
            {
                Location = new System.Drawing.Point(110, 130),
                Width = 140,
                Name = "textBoxZipCode"
            };

            // City
            Label lblCity = new Label
            {
                Text = "City",
                Location = new System.Drawing.Point(10, 160)
            };
            
            this.textBoxCity = new TextBox
            {
                Location = new System.Drawing.Point(110, 160),
                Width = 140,
                Name = "textBoxCity"
            };

            // Country
            Label lblCountry = new Label
            {
                Text = "Country",
                
                Location = new System.Drawing.Point(10, 190)
            };
            this.comboBoxCountry = new ComboBox
            {
                Location = new System.Drawing.Point(110, 190),
                Width = 140,
                Name = "comboBoxCountry",
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            Button btnAddGuest = new Button
            {
                Text = "Add Guest",
                Location = new System.Drawing.Point(10, 220),
                Width = 240,
                Height = 30,
                Name = "btnAddGuest"
            };

            groupAddGuest.Controls.Add(lblFirstName);
            groupAddGuest.Controls.Add(txtFirstName);
            groupAddGuest.Controls.Add(lblLastName);
            groupAddGuest.Controls.Add(txtLastName);
            groupAddGuest.Controls.Add(lblStreet);
            groupAddGuest.Controls.Add(textBoxStreet);
            groupAddGuest.Controls.Add(lblZipCode);
            groupAddGuest.Controls.Add(textBoxZipCode);
            groupAddGuest.Controls.Add(lblCity);
            groupAddGuest.Controls.Add(textBoxCity);
            groupAddGuest.Controls.Add(lblCountry);
            groupAddGuest.Controls.Add(comboBoxCountry);
            
            groupAddGuest.Controls.Add(btnAddGuest);
            this.comboBoxCountry.DataSource = Enum.GetValues(typeof(Countries));
            this.Controls.Add(groupAddGuest);
            btnAddGuest.Click += btnAddGuest_Click;


            // Summary Group Box Area
            GroupBox groupSummary = new GroupBox
            {
                Text = "Event Economy",
                Location = new System.Drawing.Point(290, 15),
                Size = new System.Drawing.Size(250, 160)
            };

            Label lblNumGuests = new Label
            {
                Text = "Number of guests",
                Location = new System.Drawing.Point(10, 30)
            };

            this.outLabelNumGuests = new Label
            {
                Location = new System.Drawing.Point(170, 30),
                Width = 80,
                
            };

            Label lblTotalCost = new Label
            {
                Text = "Total Cost",
                Location = new System.Drawing.Point(10, 60)
            };
            this.outLabelTotalCost = new Label
            {
                Location = new System.Drawing.Point(170, 60),
                Width = 80,

            };

            Label lblTotalFees = new Label
            {
                Text = "Total fees",
                Location = new System.Drawing.Point(10, 90)
            };
            this.outLabelTotalFees = new Label
            {
                Location = new System.Drawing.Point(170, 90),
                Width = 80,

            };

            Label lblSurplusDeficit = new Label
            {
                Text = "Surplus/deficit",
                Location = new System.Drawing.Point(10, 120),
                Width = 140
            };
            this.outLabelSurplusDeficit = new Label
            {
                Location = new System.Drawing.Point(170, 120),
                Width = 80,

            };

            groupSummary.Controls.Add(lblNumGuests);
            groupSummary.Controls.Add(outLabelNumGuests);
            groupSummary.Controls.Add(lblTotalCost);
            groupSummary.Controls.Add(outLabelTotalCost);
            groupSummary.Controls.Add(lblTotalFees);
            groupSummary.Controls.Add(outLabelTotalFees);
            groupSummary.Controls.Add(lblSurplusDeficit);
            groupSummary.Controls.Add(outLabelSurplusDeficit);
            this.Controls.Add(groupSummary);


            // Guest List Area
            Label lblGuestList = new Label
            {
                Text = "Participants",
                Location = new System.Drawing.Point(290, 185)
            };
            this.Controls.Add(lblGuestList);


            this.lstGuests = new ListBox
            {
                Location = new System.Drawing.Point(290, 210),
                Size = new System.Drawing.Size(480, 300),
                Name = "listGuestList"
            };
            this.Controls.Add(lstGuests);


            Button btnRemoveGuest = new Button
            {
                Text = "Remove Guest",
                Location = new System.Drawing.Point(630, 500),
                Width = 140,
                Height = 30,
                Name = "btnRemoveGuest"
            };
            this.Controls.Add(btnRemoveGuest);

            btnRemoveGuest.Click += btnRemoveGuest_Click;

            Button btnEditGuest = new Button
            {
                Text = "Edit Guest",
                Location = new System.Drawing.Point(490, 500),
                Width = 140,
                Height = 30,
                Name = "btnEditGuest"
            };
            this.Controls.Add(btnEditGuest);

            this.btnSaveChanges = new Button
            {
                Text = "Save Changes",
                Location = new System.Drawing.Point(350, 500),
                Width = 140,
                Height = 30,
                Name = "btnSaveChanges"
            };

            this.Controls.Add(btnSaveChanges);
            btnSaveChanges.Click += btnSaveChanges_Click;
            btnEditGuest.Click += btnEditGuest_Click;
        }
        #endregion
    }
}
