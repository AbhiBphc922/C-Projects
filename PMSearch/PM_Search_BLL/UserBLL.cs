using PM_Search_DataAccess;
using System;
using System.Data;

namespace PM_Search_BLL
{
    public class UserBLL
    {
        private UserDAO user;

        public UserBLL()
        {
            user = new UserDAO();
        }

        public UserVO SetUserData(string username, string password)
        {
            UserVO userVO = new UserVO();
            DataTable dataTable = new DataTable();

            dataTable = user.GetUserData(username,password);
            if(dataTable.Rows.Count==0)
            {
                return null;
            }
            foreach (DataRow dr in dataTable.Rows)
            {
                userVO.UserID = Int32.Parse(dr["UserID"].ToString());
                userVO.UserName = dr["UserName"].ToString();
                userVO.Password = dr["Password"].ToString();
                userVO.AccessLevel = Int32.Parse(dr["AccessLevel"].ToString());
            }
            return userVO;
        }
    }
}
