using PM_Search_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;

namespace PM_Search_BLL
{
    public class PersonBLL
    {
        private PersonDAO person;

        public PersonBLL()
        {
            person = new PersonDAO();
        }

        public List<PersonVO> SetPersonData(string firstname, string lastname, string sex,
                                        string birthdate, string voterid)
        {
            List<PersonVO> personVOList = new List<PersonVO>();
            DataTable dataTable = new DataTable();

            dataTable = person.GetPersonData(firstname, lastname, sex, birthdate, voterid);
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            foreach (DataRow dr in dataTable.Rows)
            {
                PersonVO tempPerson = new PersonVO();
                tempPerson.PersonID = Int32.Parse(dr["PersonID"].ToString());
                tempPerson.FirstName = dr["FirstName"].ToString();
                tempPerson.LastName = dr["LastName"].ToString();
                tempPerson.Sex = dr["Sex"].ToString();
                tempPerson.BirthDate = dr["BirthDate"].ToString();
                tempPerson.VoterID = dr["VoterID"].ToString();
                personVOList.Add(tempPerson);
            }
            return personVOList;
        }
    
        public bool PersonUpdated(string firstname, string lastname, string sex,
                                       string birthdate, string voterid,int personid)
        {
            PersonVO personUpdated = new PersonVO();
            personUpdated.ModifyPerson = person.UpdatePersonData(personid, firstname, lastname, sex,
                                        birthdate, voterid);
            return personUpdated.ModifyPerson;
        }

        public bool PersonAdded(string firstname, string lastname, string sex,
                                      string birthdate, string voterid)
        {
            PersonVO personAdded = new PersonVO();
            personAdded.AddPerson = person.AddPersonData(firstname, lastname, sex,
                                        birthdate, voterid);
            return personAdded.AddPerson;
        }

        public PersonVO SetPersonDataUsingPersonId(int personid)
        {
            PersonVO personVO = new PersonVO();
            DataTable dataTable = new DataTable();

            dataTable = person.GetPersonDataUsingPersonId(personid);
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            foreach (DataRow dr in dataTable.Rows)
            {
                personVO.PersonID = Int32.Parse(dr["PersonID"].ToString());
                personVO.FirstName = dr["FirstName"].ToString();
                personVO.LastName = dr["LastName"].ToString();
                personVO.Sex = dr["Sex"].ToString();
                personVO.BirthDate = dr["BirthDate"].ToString();
                personVO.VoterID = dr["VoterID"].ToString();
            }
            return personVO;
        }
    }
}
