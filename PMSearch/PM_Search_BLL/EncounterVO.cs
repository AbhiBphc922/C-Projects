using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_Search_BLL
{
    public class EncounterVO
    {
        private int encounterID;
        private string physician;
        private string medication;
        private int personID;
        private bool modifyEncounter;
        private bool addEncounter;

        public int EncounterID
        {
            get { return encounterID; }
            set { encounterID = value; }
        }

        public string Physician
        {
            get { return physician; }
            set { physician = value; }
        }

        public string Medication
        {
            get { return medication; }
            set { medication = value; }
        }
        public int PersonID
        {
            get { return personID; }
            set { personID = value; }
        }
        public bool ModifyEncounter
        {
            get { return modifyEncounter; }
            set { modifyEncounter = value; }
        }
        public bool AddEncounter
        {
            get { return addEncounter; }
            set { addEncounter = value; }
        }
    }
}
