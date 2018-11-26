namespace Momo.Tokens
{
    /// <summary>
    /// Shushu configuration interface.
    /// </summary>
    public interface IShushuConfiguration
    {
        /// <summary>
        /// Name of the Azure Search instance.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Service Api key.
        /// </summary>
        string ServiceApiKey { get; set; }

        /// <summary>
        /// Search Api key.
        /// </summary>
        string SearchApiKey { get; set; }

        /// <summary>
        /// Index.
        /// </summary>
        string Index { get; set; }
    }
}