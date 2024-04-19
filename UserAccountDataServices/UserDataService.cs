using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAccountModel;

namespace UserAccountDataServices
{
    public class UserDataService
    {
        List<User> dummyUsers = new List<User>();

        public UserDataService()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {

            User user1 = new User { userID = "BN-00123-2022", userName = "lykasebelina", password = "123" };
            User user2 = new User { userID = "BN-00456-2022", userName = "lykamaesebelina", password = "456" };
            User user3 = new User { userID = "BN-00789-2022", userName = "lykamaecsebelina", password = "789" };

            dummyUsers.Add(user1);
            dummyUsers.Add(user2);
            dummyUsers.Add(user3);
        }

        public User GetUser(string userID, string userName, string password)
        {
            User foundUser = new User();

            foreach (var dummy in dummyUsers)
            {
                if (userID == dummy.userID && userName == dummy.userName && password == dummy.password)
                {
                    foundUser = dummy;
                }
            }

            return foundUser;
        }
    }
}

