class DBInterface
{
    Database database;
    public DBInterface()
    {
        database = new Database();
    }

    public bool loggedIn()
    {
        return false;
    }
}