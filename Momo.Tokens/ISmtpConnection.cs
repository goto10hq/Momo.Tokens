using Momo.Tokens.SmtpConfigurations;

namespace Momo.Tokens
{
    public interface ISmtpConnection
    {
        string Server { get; }
        int Port { get; }
        string Login { get; }
        string Password { get; }        
    }
}