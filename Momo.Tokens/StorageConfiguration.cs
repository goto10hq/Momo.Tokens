namespace Momo.Tokens
{
    /// <summary>
    /// Storage configuration.
    /// </summary>
    public class StorageConfiguration : IStorageConfiguration
    {
        /// <summary>
        /// Get or set connection string.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Container.
        /// </summary>
        public string Container { get; }

        /// <summary>
        /// Ctor.
        /// </summary>
        public StorageConfiguration()
        {
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="connectionString">Connection string.</param>
        /// <param name="container">Container.</param>
        public StorageConfiguration(string connectionString, string container)
        {
            ConnectionString = connectionString;
            Container = container;
        }
    }
}