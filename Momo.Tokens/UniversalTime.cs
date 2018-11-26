namespace Momo.Tokens
{
    /// <summary>
    /// Universal time configuration.
    /// </summary>
    public class UniversalTime : IUniversalTime
    {
        public string Timezone { get; set; }

        /// <summary>
        /// Create empty timezone.
        /// </summary>
        public UniversalTime()
        {
        }

        /// <summary>
        /// Create universal time with a given timezone.
        /// </summary>
        /// <param name="timeZone"></param>
        public UniversalTime(string timezone)
        {
            Timezone = timezone ?? throw new System.ArgumentNullException(nameof(timezone));
        }
    }
}