using Corelibs.CLI;
using Corelibs.Cognito;

namespace ManabuX.Client.CLI.Views;

internal class Login : ICommandHandler
{
    private readonly IAuthentication _auth;

    public Login(
        IAuthentication authUser)
    {
        _auth = authUser;
    }

    public async Task<string> Process(string[] args)
    {
        Console.Write("Username: ");
        var username = Console.ReadLine();

        Console.Write("Password: ");
        var password = Console.ReadLine();

        await _auth.SignIn(username, password);

        return $"Login successful";
    }

    public string Command => "login";
}
