namespace pilgrimage.domain
{
    using System;

    /// <summary>
    /// Defines an inventory item.
    /// </summary>
    public class Item
    {
        #region [Constructors]

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="name">The name of the item.</param>
        /// <param name="description">The description of the item.</param>
        public Item(
            string name,
            string description)
            : this(Guid.NewGuid())
        {
            this.Name = name;
            this.Description = description;
        }

        private Item(Guid id)
        {
            this.Id = id;
        }

        #endregion

        #region [Data]

        /// <summary>
        /// Gets the system identifier of this item.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the name of this item.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description of this item.
        /// </summary>
        public string Description { get; }

        #endregion
    }
}
