using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment5
{
    public class ParticipantManager
    {
        private List<Participant> participants;

        public ParticipantManager()
        {
            participants = new List<Participant>();
        }
        public int Count => participants.Count;

        /// <summary>
        /// Function for adding a new participant to the list
        /// </summary>
        /// <param name="participant"></param>
        public void AddParticipant(Participant participant)
        {
            participants.Add(participant);
        }

        /// <summary>
        /// Function for getting participant at a chose index (selected participant)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Participant GetParticipantAt(int index)
        {
            if (index < 0 || index >= participants.Count)
                throw new ArgumentOutOfRangeException("Invalid participant index.");
            return participants[index];
        }

        /// <summary>
        /// Function for removing participant by index (selected participant)
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void RemoveParticipant(int index)
        {
            if (index < 0 || index >= participants.Count)
                throw new ArgumentOutOfRangeException("Invalid participant index.");
            participants.RemoveAt(index);
        }

        /// <summary>
        /// Function for updating participant at a chose index (selected participant)
        /// </summary>
        /// <param name="index"></param>
        /// <param name="updatedParticipant"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void UpdateParticipant(int index, Participant updatedParticipant)
        {
            if (index < 0 || index >= participants.Count)
                throw new ArgumentOutOfRangeException("Invalid participant index.");
            participants[index] = updatedParticipant;
        }

        /// <summary>
        /// Function for getting participant info, used for updating the participant list in the GUI
        /// </summary>
        /// <returns></returns>
        public List<string> GetParticipantsInfo()
        {
            List<string> infoList = new List<string>();
            foreach (Participant p in participants)
            {
                infoList.Add(p.ToString());
            }
            return infoList;
        }
    }
}
