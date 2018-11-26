namespace Momo.Tokens
{
    /// <summary>
    /// Universal time configuration interface.
    /// </summary>
    public interface IUniversalTimeConfiguration
    {
        /// <summary>
        /// Name of the timezone.
        /// </summary>
        string Timezone { get; set; }        
    }
}