namespace Momo.Tokens
{
    /// <summary>
    /// Tsumugi configuration interface.    
    /// </summary>
    public interface ITsumugiConfiguration
    {
        /// <summary>
        /// Get or set connection string.
        /// </summary>
        string ConnectionString { get; set; }

        /// <summary>
        /// Get or set queue.
        /// </summary>
        string Queue { get; set; }

        /// <summary>
        /// Get or set channel.
        /// </summary>
        string Channel { get; set; }

        /// <summary>
        /// Get or set emoji.
        /// </summary>
        string Emoji { get; set; }

        /// <summary>
        /// Get or set bot.
        /// </summary>
        string Bot { get; set; }
    }
}