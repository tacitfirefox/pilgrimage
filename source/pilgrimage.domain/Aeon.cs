namespace pilgrimage.domain
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a summonable entity.
    /// </summary>
    public class Aeon
    {
        #region [Constructors]

        /// <summary>
        /// Initializes a new instance of the <see cref="Aeon"/> class.
        /// </summary>
        /// <param name="name">The name of the aeon.</param>
        /// <param name="reviveCount">The number of battles to win before auto-reviving from KO status.</param>
        /// <param name="startingAbilities">A collection of starting abilities for the aeon.</param>
        public Aeon(
            string name,
            uint reviveCount,
            IEnumerable<Ability> startingAbilities)
            : this(Guid.NewGuid())
        {
            this.Name = name;
            this.RevivalCount = reviveCount;
            this.AbilitiesLearned = startingAbilities;
        }

        private Aeon(Guid id)
        {
            this.Id = id;
        }

        #endregion

        #region [Data]

        /// <summary>
        /// Gets the system identifier of this aeon.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the name of this aeon.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the total number of battles that must be fought before this aeon automatically revives from KO.
        /// </summary>
        public uint RevivalCount { get; }

        /// <summary>
        /// Gets the collection of battle abilities this aeon has learned.
        /// </summary>
        public IEnumerable<Ability> AbilitiesLearned { get; }

        #endregion
    }
}
