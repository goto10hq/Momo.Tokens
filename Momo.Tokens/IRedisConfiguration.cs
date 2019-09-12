using System.Net;

namespace Momo.Tokens
{
    public interface IRedisConfiguration
    {
        /// <summary>
        /// Get or set host.
        /// </summary>
        /// <value>Host (ie. Azure Redis Caches looks like YOUR_CACHE.redis.cache.windows.net)</value>
        string Host { get; set; }

        /// <summary>
        /// Get or set port.
        /// </summary>
        /// <value>Port (default value 6380).</value>   
        int Port { get; set; }

        /// <summary>
        /// Get Dns end point.
        /// </summary>
        /// <returns>Dns end point.</returns>
        DnsEndPoint EndPoint { get; }

        /// <summary>
        /// Get or set password.
        /// </summary>
        /// <value>Password (access key).</value>
        string Password { get; set; }

        /// <summary>
        /// Get or set ssl.
        /// </summary>
        /// <value>Sll (default true).</value>
        bool Ssl { get; set; }
    }
}