namespace pilgrimage.services.implementation.tacitfirefox
{
    using System;
    using System.Collections.Generic;
    using pilgrimage.domain;
    using pilgrimage.services.core;

    /// <summary>
    /// JSON implementation for <see cref="IItemProvider"/> using <seealso cref="ISearch"/>.
    /// </summary>
    public class ItemSearchProvider :
        IItemProvider,
        ISearch
    {
        public ItemSearchProvider()
        {
        }

        /// <inheritdoc />
        public IEnumerable<Item> GetItemsCarriedBy(IEnumerable<Enemy> enemies)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<(Item Item, uint Amount)> GetItemsNeededToCustomize(IEnumerable<Property> properties)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<(Item Item, uint Amount)> GetItemsNeededToTeach(IEnumerable<Ability> abilities)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<(Item PrimaryIngredient, Item SecondaryIngredient)> GetItemsThatCombineInto(IEnumerable<Mixture> mixtures)
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
