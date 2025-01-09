using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment5
{
    public class Participant
    {
        private string firstName;
        private string lastName;
        private Address address;


        /// <summary>
        /// Get & Set Properties
        /// </summary>
        public string FirstName
        {
            get => firstName;
            set => firstName = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("First name cannot be empty.");
        }

        public string LastName
        {
            get => lastName;
            set => lastName = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Last name cannot be empty.");
        }

        public Address Address
        {
            get => address;
            set => address = value ?? throw new ArgumentNullException("Address cannot be null.");
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        public Participant(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        /// <summary>
        /// To String method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Address}";
        }
    }
}
