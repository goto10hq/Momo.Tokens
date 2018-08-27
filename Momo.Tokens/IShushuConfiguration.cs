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
        string Name { get; }

        /// <summary>
        /// Service Api key.
        /// </summary>
        string ServiceApiKey { get; }

        /// <summary>
        /// Search Api key.
        /// </summary>
        string SearchApiKey { get; }

        /// <summary>
        /// Index.
        /// </summary>
        string Index { get; }
    }
}