using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogic
    {
        private DataAccessLayer.DataAccessLayer dataAccess;

        public BusinessLogic()
        {
            dataAccess = new DataAccessLayer.DataAccessLayer();
        }

        public bool ValidateInput(string username, string password)
        {
            bool result = true;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                result = false;
            }
            return result;
        }

        public bool Login(string username, string password)
        {
            bool result = false;
            if (ValidateInput(username, password))
            {
                result = dataAccess.CheckLogin(username, password);
            }
            return result;
        }
    }
}
