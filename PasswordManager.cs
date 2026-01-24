
static class PasswordManager
{

    static void _loginExisting(DBInterface dbinterface)
    {
        string loginQuery = "Welcome to your password manager!\nPlease enter your username and password to login\nUsername:";

    }

    static void _register(DBInterface dbinterface)
    {
        string registerQuery = "Welcome!\nPlease sign up with a username and password";
        string usernameQuery = "Username:";
        string passwordQuery = "Password:";
        string username = ""
        string password = ""

        Console.WriteLine(registerQuery);
        Console.WriteLine(usernameQuery);
        username = Console.ReadLine();
        Console.WriteLine(passwordQuery);
        password = Console.ReadLine();

        

    }
    static void _login(DBInterface dbinterface)
    {
        
        string passwordQuery = "Password:";
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
    static void _mainLoop(DBInterface dbinterface)
    {
        string options = "Please enter the number corresponding to the option you choose\n 1) Add password\n 2) Delete password\n 3) Edit password information\n 4) List passwords\n 5) Quit";

        _login(dbinterface);

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
        _mainLoop(dbinterface);
    }
}