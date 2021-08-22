namespace pilgrimage.domain
{
    using System;

    /// <summary>
    /// Defines a usable battle skill.
    /// </summary>
    public class Ability
    {
        #region [Constructors]

        /// <summary>
        /// Initializes a new instance of the <see cref="Ability"/> class.
        /// </summary>
        /// <param name="name">The name of the ability.</param>
        /// <param name="description">The description of the ability.</param>
        /// <param name="action">The battle action category of the ability.</param>
        /// <param name="mpCost">The MP cost of the ability, if any.</param>
        public Ability(
            string name,
            string description,
            Action action,
            uint? mpCost = null)
            : this(Guid.NewGuid())
        {
            this.Name = name;
            this.Description = description;
            this.Action = action;
            this.MpCost = mpCost;
        }

        private Ability(Guid id)
        {
            this.Id = id;
        }

        #endregion

        #region [Data]

        /// <summary>
        /// Gets the system identifier of this ability.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the name of this ability.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description of this ability.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the battle action this ability can be used by.
        /// </summary>
        public Action Action { get; }

        /// <summary>
        /// Gets the MP cost of this ability. Null values are considered the same as zero values (there is no MP cost to use this ability).
        /// </summary>
        public uint? MpCost { get; }

        #endregion
    }
}
