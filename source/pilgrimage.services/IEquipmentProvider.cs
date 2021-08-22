namespace pilgrimage.services
{
    using System.Collections.Generic;

    using pilgrimage.domain;
    using pilgrimage.domain.enumerations;

    /// <summary>
    /// Describes a mechanism for retrieval of equipment objects.
    /// </summary>
    public interface IEquipmentProvider
    {
        /// <summary>
        /// Gets a collection of equipment objects that are usable by a specific character.
        /// </summary>
        /// <param name="characterName">The name of the character to search for.</param>
        /// <returns>A collection of <see cref="Equipment"/> objects.</returns>
        IEnumerable<Equipment> GetEquipmentByCharacter(string characterName);

        /// <summary>
        /// Gets a collection of equipment objects that have any or all of the given properties.
        /// </summary>
        /// <param name="properties">The collection of properties to search for.</param>
        /// <returns>A collection of <see cref="Equipment"/> objects.</returns>
        IEnumerable<Equipment> GetEquipmentByProperties(IEnumerable<Property> properties);

        /// <summary>
        /// Gets the name of a specific piece of a equipment for a character with a number of slots and properties.
        /// </summary>
        /// <param name="characterName">The name of the character to get the equipment piece for.</param>
        /// <param name="category">The category of the equipment piece.</param>
        /// <param name="slotsCount">The total number of slots the equipment piece has.</param>
        /// <param name="properties">The properties that occupy the equipment slots in order.</param>
        /// <returns>The name of the piece of equipment.</returns>
        string GetEquipmentName(
            string characterName,
            Category category,
            uint slotsCount,
            IEnumerable<Property> properties);
    }
}
