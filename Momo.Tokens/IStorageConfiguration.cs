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
        string ConnectionString { get; }

        /// <summary>
        /// Get container.
        /// </summary>
        string Container { get; }
    }
}