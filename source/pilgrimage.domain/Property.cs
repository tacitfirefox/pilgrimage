namespace pilgrimage.domain
{
    using System;

    /// <summary>
    /// Defines an equipment ability.
    /// </summary>
    public class Property
    {
        #region [Constructors]

        /// <summary>
        /// Initializes a new instance of the <see cref="Property"/> class.
        /// </summary>
        /// <param name="name">The name of the property.</param>
        /// <param name="description">The description of the property.</param>
        /// <param name="category">The equipment category the property can be applied to.</param>
        public Property(
            string name,
            string description,
            Equipment category)
            : this(Guid.NewGuid())
        {
            this.Name = name;
            this.Description = description;
            this.Category = category;
        }

        private Property(Guid id)
        {
            this.Id = id;
        }

        #endregion

        #region [Data]

        /// <summary>
        /// Gets the system identifier of this property.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the name of this property.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description of this property.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Gets the equipment category this property can apply to.
        /// </summary>
        public Equipment Category { get; }

        #endregion
    }
}
