namespace pilgrimage.services.implementation.tacitfirefox
{
    using System;
    using System.Collections.Generic;
    using pilgrimage.domain;
    using pilgrimage.domain.enumerations;
    using pilgrimage.services.core;

    /// <summary>
    /// JSON implementation for <see cref="IEquipmentProvider"/> using <seealso cref="ISearch"/>.
    /// </summary>
    internal class EquipmentSearchProvider :
        IEquipmentProvider,
        ISearch
    {
        public EquipmentSearchProvider()
        {
        }

        /// <inheritdoc />
        public IEnumerable<Equipment> GetEquipmentByCharacter(string characterName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<Equipment> GetEquipmentByProperties(IEnumerable<Property> properties)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string GetEquipmentName(string characterName, Category category, uint slotsCount, IEnumerable<Property> properties)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<TTarget> Search<TTarget>(IEnumerable<(string PropertyName, string PropertyValue)> indices = null)
        {
            throw new NotImplementedException();
        }
    }
}
