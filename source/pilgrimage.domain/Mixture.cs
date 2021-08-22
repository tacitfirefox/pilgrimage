namespace pilgrimage.domain
{
    using System;

    /// <summary>
    /// Defines an alchemical mixture made by Rikku.
    /// </summary>
    public class Mixture
    {
        #region [Data]

        /// <summary>
        /// Gets the system identifier of this mixture.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the name of this mixture.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description of this mixture.
        /// </summary>
        public string Description { get; }

        #endregion
    }
}
