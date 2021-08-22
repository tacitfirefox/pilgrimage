namespace pilgrimage.services
{
    using System.Collections.Generic;
    using pilgrimage.domain;

    /// <summary>
    /// Describes a mechanism for retrieval of items.
    /// </summary>
    public interface IItemProvider
    {
        /// <summary>
        /// Gets a collection of items carried by any or all of the given enemies.
        /// </summary>
        /// <param name="enemies">A collection of enemy objects to search by.</param>
        /// <returns>A collection of <see cref="Item"/> objects.</returns>
        IEnumerable<Item> GetItemsCarriedBy(IEnumerable<Enemy> enemies);

        /// <summary>
        /// Gets a collection of items and how many of each are required to imbue the given properties.
        /// </summary>
        /// <param name="properties">A collection of properties to customize.</param>
        /// <returns>A collection of items and how many of each are required for equipment customization.</returns>
        IEnumerable<(Item Item, uint Amount)> GetItemsNeededToCustomize(IEnumerable<Property> properties);

        /// <summary>
        /// Gets a collection of items and how many of each are required to teach an aeon the given abilities.
        /// </summary>
        /// <param name="abilities">A collection of abilities to teach.</param>
        /// <returns>A collection of items and how many of each are required for aeon specialization.</returns>
        IEnumerable<(Item Item, uint Amount)> GetItemsNeededToTeach(IEnumerable<Ability> abilities);

        /// <summary>
        /// Gets a collection of <see cref="(Item, Item)"/> combinations that combine into any of the given mixtures.
        /// </summary>
        /// <param name="mixtures">The mixtures to search for.</param>
        /// <returns>A collection of <see cref="(Item, Item)"/> combinations.</returns>
        IEnumerable<(Item PrimaryIngredient, Item SecondaryIngredient)> GetItemsThatCombineInto(IEnumerable<Mixture> mixtures);
    }
}
