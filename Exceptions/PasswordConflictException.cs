using System;
using System.Dynamic;
using PasswordManager.Models;

namespace PasswordManager.Exceptions;

public class PasswordConflictException : Exception
{

    public PasswordInformation ExistingPassword {get;}
    public PasswordInformation NewPassword {get;}
    public PasswordConflictException(PasswordInformation existingPassword, PasswordInformation newPassword)
    {
        ExistingPassword = existingPassword;
        NewPassword = newPassword;
    }

    public PasswordConflictException(string message, PasswordInformation existingPassword, PasswordInformation newPassword) : base(message)
    {
        ExistingPassword = existingPassword;
        NewPassword = newPassword;
    }

    public PasswordConflictException(string message, Exception innerException, PasswordInformation existingPassword, PasswordInformation newPassword) : base(message, innerException)
    {
        ExistingPassword = existingPassword;
        NewPassword = newPassword;
    }
}
