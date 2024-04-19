using UserAccountDataServices;


namespace UserAccountBusinessServices
{
    public class UserService
    {
        public bool VerifyUserAccount(string userID, string userName, string password)
        {
            UserDataService dataService = new UserDataService();
            var result = dataService.GetUser(userID, userName, password);

            return result.userID != null;
            return result.userName != null;
            return result.password != null;


        }
    }
}

