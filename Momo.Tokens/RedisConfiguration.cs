using System.Net;

namespace Momo.Tokens
{
    public class RedisConfiguration : IRedisConfiguration
    {
        /// <summary>
        /// Get or set host.
        /// </summary>
        /// <value>Host (ie. Azure Redis Caches looks like YOUR_CACHE.redis.cache.windows.net)</value>
        public string Host { get; set; }

        /// <summary>
        /// Get or set port.
        /// </summary>
        /// <value>Port (default value 6380).</value>   
        public int Port { get; set; } = 6380;

        /// <summary>
        /// Get Dns end point.
        /// </summary>
        /// <returns>Dns end point.</returns>
        public DnsEndPoint EndPoint => new DnsEndPoint(Host, Port);

        /// <summary>
        /// Get or set password.
        /// </summary>
        /// <value>Password (access key).</value>
        public string Password { get; set; }

        /// <summary>
        /// Get or set ssl.
        /// </summary>
        /// <value>Sll (default true).</value>
        public bool Ssl { get; set; } = true;

        /// <summary>
        /// Ctor.
        /// </summary>
        public RedisConfiguration()
        {
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="host">Host.</param>
        /// <param name="password">Password (access key).</param>
        /// <param name="port">Port.</param>
        /// <param name="ssl">Ssl.</param>
        public RedisConfiguration(string host, string password, int port = 6380, bool ssl = true)
        {
            this.Host = host;
            this.Port = port;
            this.Password = password;
            this.Ssl = ssl;
        }
    }
}