using Programming_Assignment5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment4
{
    
    public class EventManager
    {
        private double costPerPerson; // cost per participant
        private double feePerPerson; // fees to be paid by the guest (revenue)
        private string title;
        private ParticipantManager participantManager;

        public ParticipantManager Participants => participantManager;

        public EventManager()
        {
            participantManager = new ParticipantManager();
        }

        /// <summary>
        /// Get & Set properties
        /// </summary>   
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    title = value;
            }
        }
        public double CostPerPerson
        {
            get 
            { 
                return costPerPerson; 
            }

            set
            {
                if (value >= 0.0)
                    costPerPerson = value;
            }
        }
        public double FeePerPerson
        {
            get 
            { 
                return feePerPerson; 
            }

            set
            {
                if (value >= 0.0)
                    feePerPerson = value;
            }
        }

        /// <summary>
        /// Function for getting total cost of all registered guests
        /// </summary>
        /// <returns>
        /// The total cost of the event calculated as the number of guests multiplied by the cost per person
        /// </returns>
        public double GetTotalCost()
        {
            return participantManager.Count * costPerPerson;
        }

        /// <summary>
        /// Function for getting total fees (revenue) paid by guests
        /// </summary>
        /// <returns>
        /// The total revenue from guest fees which is number of guests multiplied by the fee per person
        /// </returns>
        public double GetTotalFees()
        {
            return participantManager.Count * feePerPerson;
        }

        /// <summary>
        /// Function for getting results either surplus or deficit for the current event
        /// </summary>
        /// <returns>
        /// Financial result as a surplus (profit) or a deficit (loss).
        /// </returns>
        public double GetSurplusOrDeficit()
        {
            return GetTotalFees() - GetTotalCost();
        }

    }

}
