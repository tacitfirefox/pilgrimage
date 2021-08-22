namespace pilgrimage.domain
{
    /// <summary>
    /// Defines a set of common parameters used by all entities.
    /// </summary>
    public struct Statistics
    {
        /// <summary>
        /// Gets or sets the maximum amount of HP.
        /// </summary>
        public uint MaximumHealthPoints { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of MP.
        /// </summary>
        public uint MaximumMagicPoints { get; set; }

        /// <summary>
        /// Gets or sets the physical damage score.
        /// </summary>
        public uint Strength { get; set; }

        /// <summary>
        /// Gets or sets the physical defense score.
        /// </summary>
        public uint Defense { get; set; }

        /// <summary>
        /// Gets or sets the magical damage score.
        /// </summary>
        public uint Magic { get; set; }

        /// <summary>
        /// Gets or sets the magical defense score.
        /// </summary>
        public uint MagicDefense { get; set; }

        /// <summary>
        /// Gets or sets the accuracy rating.
        /// </summary>
        public uint Accuracy { get; set; }

        /// <summary>
        /// Gets or sets the agility rating.
        /// </summary>
        public uint Agility { get; set; }

        /// <summary>
        /// Gets or sets the evasion rating.
        /// </summary>
        public uint Evasion { get; set; }

        /// <summary>
        /// Gets or sets the luck rating.
        /// </summary>
        public uint Luck { get; set; }
    }
}
