namespace Momo.Tokens
{
    /// <summary>
    /// Storage configuration interface.
    /// </summary>
    public interface IStorageConfiguration
    {
        /// <summary>
        /// Get connection string.
        /// </summary>
        string ConnectionString { get; set; }

        /// <summary>
        /// Get container.
        /// </summary>
        string Container { get; set; }
    }
}