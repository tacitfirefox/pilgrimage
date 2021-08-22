namespace pilgrimage.domain
{
    using System;
    using System.Collections.Generic;
    using pilgrimage.domain.enumerations;

    /// <summary>
    /// Defines a weapon or armor piece.
    /// </summary>
    public class Equipment
    {
        #region [Constructors]

        /// <summary>
        /// Initializes a new instance of the <see cref="Equipment"/> class.
        /// </summary>
        /// <param name="name">The name of the equipment.</param>
        /// <param name="type">The type of the equipment.</param>
        /// <param name="properties">The properties that define the equipment.</param>
        public Equipment(
            string name,
            enumerations.Category type,
            IEnumerable<Property> properties)
            : this(Guid.NewGuid())
        {
            this.Name = name;
            this.EquipmentType = type;
            this.Properties = properties;
        }

        private Equipment(Guid id)
        {
            this.Id = id;
        }

        #endregion

        #region [Data]

        /// <summary>
        /// Gets the system unique identifier for this piece of equipment.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the collection of properties that define this piece of equipment.
        /// </summary>
        public IEnumerable<Property> Properties { get; }

        /// <summary>
        /// Gets the name of this piece of equipment.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the equipment type (weapon or armor) of this piece of equipment.
        /// </summary>
        public Category EquipmentType { get; }

        #endregion

        /// <summary>
        /// Sets the name of this equipment piece.
        /// </summary>
        /// <param name="name">The name of the equipment.</param>
        public void SetEquipmentName(string name)
        {
            this.Name = name;
        }
    }
}
