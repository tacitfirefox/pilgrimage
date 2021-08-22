namespace pilgrimage.domain.enumerations
{
    /// <summary>
    /// Defines item acquisition methods supported by the system.
    /// </summary>
    public enum Acquisition
    {
        /// <summary>
        /// Dropped by an enemy.
        /// </summary>
        Drop,

        /// <summary>
        /// Stolen from an enemy.
        /// </summary>
        Steal,

        /// <summary>
        /// Bribed from an enemy.
        /// </summary>
        Bribe,
    }
}
