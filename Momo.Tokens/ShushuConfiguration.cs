namespace Momo.Tokens
{
    /// <summary>
    /// Shushu configuration.
    /// </summary>
    public class ShushuConfiguration
    {
        /// <summary>
        /// Name of the Azure Search instance.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Service Api key.
        /// </summary>
        public string ServiceApiKey { get; }

        /// <summary>
        /// Search Api key.
        /// </summary>
        public string SearchApiKey { get; }

        /// <summary>
        /// Index.
        /// </summary>
        public string Index { get; }

        /// <summary>
        /// Ctor.
        /// </summary>
        public ShushuConfiguration()
        {
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="name">Name of the Azure Search instance.</param>
        /// <param name="serviceApiKey">Service Api key.</param>
        /// <param name="searchApiKey">Search Api key.</param>
        /// <param name="index">Index.</param>
        public ShushuConfiguration(string name, string serviceApiKey, string searchApiKey, string index)
        {
            Name = name;
            ServiceApiKey = serviceApiKey;
            SearchApiKey = searchApiKey;
            Index = index;
        }
    }
}