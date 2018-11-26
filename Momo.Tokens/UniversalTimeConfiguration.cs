namespace Momo.Tokens
{
    /// <summary>
    /// Universal time configuration.
    /// </summary>
    public class UniversalTimeConfiguration : IUniversalTimeConfiguration
    {
        public string Timezone { get; set; }

        /// <summary>
        /// Create empty timezone.
        /// </summary>
        public UniversalTimeConfiguration()
        {
        }

        /// <summary>
        /// Create universal time with a given timezone.
        /// </summary>
        /// <param name="timeZone"></param>
        public UniversalTimeConfiguration(string timezone)
        {
            Timezone = timezone ?? throw new System.ArgumentNullException(nameof(timezone));
        }
    }
}