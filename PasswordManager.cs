
static class PasswordManager
{

    static void login(DBInterface dbinterface, string loginQuery, string passwordQuery)
    {
        string userInput = "";
        while (!dbinterface.loggedIn())
        {
            Console.WriteLine(loginQuery);
            userInput = Console.ReadLine();

            Console.WriteLine(passwordQuery);
            userInput = Console.ReadLine();

            break;
        }
    }
    static void mainLoop(DBInterface dbinterface)
    {
        string loginQuery = "Welcome to your password manager!\nPlease enter your username and password to login\nUsername:";

        string passwordQuery = "Password:";

        string options = "Please enter the number corresponding to the option you choose\n 1) Add password\n 2) Delete password\n 3) Edit password information\n 4) List passwords\n 5) Quit";

        login(dbinterface, loginQuery, passwordQuery);

        string userInput = "";
        while (userInput != Convert.ToString(5))
        {
            Console.WriteLine(options);
            userInput = Console.ReadLine();
        }
    }
    public static void Main()
    {
        DBInterface dbinterface = new DBInterface();
        mainLoop(dbinterface);
    }
}