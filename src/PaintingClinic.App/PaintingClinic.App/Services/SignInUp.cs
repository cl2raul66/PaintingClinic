namespace PaintingClinic.App.Services;

public interface ISignInUp
{
    bool Signin(string username, string password);
    bool Signup(string username, string password);
}

public class SignInUp : ISignInUp
{
    public bool Signin(string username, string password)
    {
        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {
            var accesskey = Preferences.Default.Get($"{username.Trim().ToLower()}:{password.Trim().ToLower()}", string.Empty);
            if (string.IsNullOrEmpty(accesskey))
            {
                //envia el usuario y pasword al server
                if (true)
                {
                    Preferences.Default.Set($"{username.Trim().ToLower()}:{password.Trim().ToLower()}", accesskey);
                    return true;
                }
            }
            else
            {
                return true;
            }
        }
        return false;
    }

    public bool Signup(string username, string password)
    {
        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
        {
            var accesskey = Preferences.Default.Get($"{username.Trim().ToLower()}:{password.Trim().ToLower()}", string.Empty);
            if (string.IsNullOrEmpty(accesskey))
            {
                //envia el usuario y pasword al server
                Preferences.Default.Set($"{username.Trim().ToLower()}:{password.Trim().ToLower()}", accesskey);
                return true;
            }
        }
        return false;
    }
}
