namespace PM_Search_BLL
{
    public class UserVO
    {
        private string userName;
        private string userPassword;
        private int accessLevel;
        private int userID;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Password
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        public int AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}
