using System.Collections.Specialized;

namespace Momo.Tokens.SmtpConfigurations
{
    public interface ISmtpConfiguration
    {
        /// <summary>
        /// Gets the header values.
        /// </summary>
        /// <value>The header values.</value>
        NameValueCollection HeaderValues { get; }
    }
}