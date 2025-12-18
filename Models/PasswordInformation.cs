using System;
using System.Runtime.InteropServices.Swift;

namespace PasswordManager.Models;

public class PasswordInformation
{
    public string Username;
    public string Password;
    public string Website;

    public PasswordInformation(string username, string password, string website)
    {
        Username = username;
        Password = password;
        Website = website;
    }

    public bool Conflicts(PasswordInformation otherPassword)
    {
        if (otherPassword.Website == Website && otherPassword.Username == Username)
        {
            return true;
        }

        return false;
    }
}
