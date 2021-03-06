﻿namespace Momo.Tokens
{
    /// <summary>
    /// Shushu configuration.
    /// </summary>
    public class ShushuConfiguration : IShushuConfiguration
    {
        /// <summary>
        /// Name of the Azure Search instance.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Service Api key.
        /// </summary>
        public string ServiceApiKey { get; set; }

        /// <summary>
        /// Search Api key.
        /// </summary>
        public string SearchApiKey { get; set; }

        /// <summary>
        /// Index.
        /// </summary>
        public string Index { get; set; }

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
            if (name == null)
                throw new System.ArgumentNullException(nameof(name));

            if (serviceApiKey == null)
                throw new System.ArgumentNullException(nameof(serviceApiKey));

            if (searchApiKey == null)
                throw new System.ArgumentNullException(nameof(searchApiKey));

            if (index == null)
                throw new System.ArgumentNullException(nameof(index));

            Name = name;
            ServiceApiKey = serviceApiKey;
            SearchApiKey = searchApiKey;
            Index = index;
        }
    }
}