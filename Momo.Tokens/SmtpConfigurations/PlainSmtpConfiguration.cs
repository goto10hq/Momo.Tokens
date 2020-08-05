using System.Collections.Specialized;

namespace Momo.Tokens.SmtpConfigurations
{
    /// <summary>
    /// Plain smtp configuration.
    /// </summary>
    public class PlainSmtpConfiguration : ISmtpConfiguration
    {
        /// <summary>
        /// Get header values.
        /// </summary>
        public NameValueCollection HeaderValues { get; } = new NameValueCollection();
    }
}
