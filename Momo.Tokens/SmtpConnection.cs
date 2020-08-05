using System;

namespace Momo.Tokens
{
    public class SmtpConnection : ISmtpConnection
    {
        public string Server { get; set; }
        public int Port { get; } = 587;
        public string Login { get; }
        public string Password { get; }

        public SmtpConnection()
        {
        }

        public SmtpConnection(string server)
        {
            Server = server ?? throw new ArgumentNullException(nameof(server));
        }

        public SmtpConnection(string server, int port)
        {
            Server = server ?? throw new ArgumentNullException(nameof(server));
            Port = port;
        }

        public SmtpConnection(string server, int port, string login, string password)
        {
            Server = server ?? throw new ArgumentNullException(nameof(server));
            Port = port;
            Login = login;
            Password = password;
        }
    }
}