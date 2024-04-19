using UserAccountBusinessServices;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter UserID: ");
            string userID = Console.ReadLine();

            Console.Write("Enter username: ");
            string userName = Console.ReadLine();


            Console.Write("Enter password: ");
            string password = Console.ReadLine();


            UserService userService = new UserService();
            bool result = userService.VerifyUserAccount(userID, userName, password);

            if (result)
            {
                Console.WriteLine();
                Console.WriteLine("ACCOUNT VERIFIED!");
            }

            else
            {
                Console.WriteLine("ACCOUNT NOT FOUND! TRY AGAIN.");
            }
        }
    }
}