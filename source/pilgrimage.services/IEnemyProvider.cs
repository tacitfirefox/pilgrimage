namespace pilgrimage.services
{
    using System.Collections.Generic;
    using pilgrimage.domain;
    using pilgrimage.domain.enumerations;

    /// <summary>
    /// Describes a mechanism for retrieval of enemy objects.
    /// </summary>
    public interface IEnemyProvider
    {
        /// <summary>
        /// Gets a collection of enemies that drop, hold, or can be bribed for any or all of the given <see cref="Item"/>s.
        /// </summary>
        /// <param name="items">A collection of items any of which the enemy can carry.</param>
        /// <returns>A collection of <see cref="(Enemy, Item, Acquisition, Rarity, uint)"/> objects.</returns>
        IEnumerable<(Enemy Target, Item Item, Acquisition Method, Rarity Rarity, uint Amount)> GetEnemiesThatCarry(IEnumerable<Item> items);

        /// <summary>
        /// Gets a collection of enemies that can drop equipment with any or all of the given <seealso cref="Property"/>-ies.
        /// </summary>
        /// <param name="properties">The collection of <see cref="Property"/>-ies to search for.</param>
        /// <returns>A collection of <see cref="Enemy"/> objects.</returns>
        IEnumerable<Enemy> GetEnemiesThatTeach(IEnumerable<Property> properties);

        /// <summary>
        /// Gets a collection of enemies that can be found in any of the given regions.
        /// </summary>
        /// <param name="regions">The names of the regions to search.</param>
        /// <returns>A collection of <see cref="Enemy"/> objects.</returns>
        IEnumerable<Enemy> GetEnemiesFoundIn(IEnumerable<string> regions);
    }
}
