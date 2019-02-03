namespace Momo.Tokens
{
    /// <summary>
    /// Storage configuration interface.
    /// </summary>
    public interface IStorageConfiguration
    {
        /// <summary>
        /// Get or set connection string.
        /// </summary>
        string ConnectionString { get; set; }

        /// <summary>
        /// Get or setcontainer.
        /// </summary>
        string Container { get; set; }
    }
}