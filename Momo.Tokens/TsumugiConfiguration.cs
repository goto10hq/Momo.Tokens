using System;

namespace Momo.Tokens
{
    /// <summary>
    /// Tsumugi configuration.
    /// </summary>
    public class TsumugiConfiguration : ITsumugiConfiguration
    {
        /// <summary>
        /// Get or set connection string.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Get or set queue.
        /// </summary>
        public string Queue { get; set; }

        /// <summary>
        /// Get or set channel.
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// Get or set emoji.
        /// </summary>
        public string Emoji { get; set; }

        /// <summary>
        /// Get or set bot.
        /// </summary>
        public string Bot { get; set; }

        /// <summary>
        /// Ctor.
        /// </summary>
        public TsumugiConfiguration()
        {
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="connectionString">Connection string.</param>
        /// <param name="queue">Queue.</param>
        /// <param name="channel">Channel.</param>
        /// <param name="emoji">Emoji.</param>
        /// <param name="bot">Bot.</param>
        public TsumugiConfiguration(string connectionString, string queue, string channel, string emoji, string bot)
        {
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));

            if (queue == null)
                throw new ArgumentNullException(nameof(queue));

            if (channel == null)
                throw new ArgumentNullException(nameof(channel));

            if (emoji == null)
                throw new ArgumentNullException(nameof(emoji));

            if (bot == null)
                throw new ArgumentNullException(nameof(bot));

            ConnectionString = connectionString;
            Queue = queue;
            Channel = channel;
            Emoji = emoji;
            Bot = bot;
        }
    }
}