using System;
using PasswordManager.Exceptions;

namespace PasswordManager.Models;

public class UserPasswords
{
    private readonly List<PasswordInformation> _passwords;
    private readonly string user;

    public UserPasswords() 
    {
        _passwords = new List<PasswordInformation>();
    }

    public IEnumerable<PasswordInformation> GetPasswords(string username) 
    {
        // TODO: get passwords from database for specific user (user is schema name)
        return _passwords.Where(r => r.Username == username);
    }

    public void AddPassword(PasswordInformation passwordInfo)
    {
        foreach (PasswordInformation existingPassword in _passwords)
        {
            if(existingPassword.Conflicts(passwordInfo))
            {
                throw new PasswordConflictException(existingPassword, passwordInfo);
            }
        }
    }
}
