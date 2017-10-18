namespace PM_Search_BLL
{
    public class PersonVO
    {
        private int personID;
        private string firstName;
        private string lastName;
        private string sex;
        private string birthDate;
        private string voterID;
        private bool modifyPerson;
        private bool addPerson;

        public int PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public string BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string VoterID
        {
            get { return voterID; }
            set { voterID = value; }
        }
        public bool ModifyPerson
        {
            get { return modifyPerson; }
            set { modifyPerson = value; }
        }
        public bool AddPerson
        {
            get { return addPerson; }
            set { addPerson = value; }
        }
    }
}
