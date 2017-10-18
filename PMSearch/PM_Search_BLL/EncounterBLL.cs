using PM_Search_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;

namespace PM_Search_BLL
{
    public class EncounterBLL
    {
        private EncounterDAO encounter;

        public EncounterBLL()
        {
            encounter = new EncounterDAO();
        }

        public EncounterVO SetEncounterDataUsingEncounterId(int encounterid)
        {
            EncounterVO encounterVO = new EncounterVO();
            DataTable dataTable = new DataTable();

            dataTable = encounter.GetEncounterDataUsingEncounterId(encounterid);
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            foreach (DataRow dr in dataTable.Rows)
            {
                encounterVO.EncounterID = Int32.Parse(dr["EncounterID"].ToString());
                encounterVO.Physician = dr["Physician"].ToString();
                encounterVO.Medication = dr["Medication"].ToString();
                encounterVO.PersonID = Int32.Parse(dr["PersonID"].ToString());
            }
            return encounterVO;
        }

        public List<EncounterVO> SetEncounterDataUsingPersonId(int personid)
        {
            List<EncounterVO> encounterVO = new List<EncounterVO>();
            DataTable dataTable = new DataTable();

            dataTable = encounter.GetEncounterDataUsingPersonId(personid);
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            foreach (DataRow dr in dataTable.Rows)
            {
                EncounterVO tempEncounter = new EncounterVO();
                tempEncounter.EncounterID = Int32.Parse(dr["EncounterID"].ToString());
                tempEncounter.Physician = dr["Physician"].ToString();
                tempEncounter.Medication = dr["Medication"].ToString();
                tempEncounter.PersonID = Int32.Parse(dr["PersonID"].ToString());
                encounterVO.Add(tempEncounter);
            }
            return encounterVO;
        }

        public bool EncounterUpdated(int encounterid, string physician, string medication, int personid)
        {
            EncounterVO encounterUpdated = new EncounterVO();
            encounterUpdated.ModifyEncounter = encounter.UpdateEncounterData(encounterid, physician, medication, personid);
            return encounterUpdated.ModifyEncounter;
        }

        public bool EncounterAdded(string physician, string medication, int personid)
        {
            EncounterVO encounterAdded = new EncounterVO();
            encounterAdded.AddEncounter = encounter.AddEncounterData(physician, medication, personid);
            return encounterAdded.AddEncounter;
        }
    }
}
