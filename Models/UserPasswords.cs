using System;

namespace PasswordManager.Models;

public class UserPasswords
{
    private readonly List<PasswordInformation> _passwords;

    public UserPasswords() {
        _passwords = new List<PasswordInformation>();
    }

    public IEnumerable<PasswordInformation> getPasswords(string username) {
        return _passwords.Where(r => r.username == username);
    }
}
