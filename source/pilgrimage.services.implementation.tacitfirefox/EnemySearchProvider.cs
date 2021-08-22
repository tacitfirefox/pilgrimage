namespace pilgrimage.services.implementation.tacitfirefox
{
    using System;
    using System.Collections.Generic;
    using pilgrimage.domain;
    using pilgrimage.domain.enumerations;
    using pilgrimage.services;
    using pilgrimage.services.core;

    /// <summary>
    /// JSON implementation for <see cref="IEnemyProvider"/> using <seealso cref="ISearch"/>.
    /// </summary>
    internal class EnemySearchProvider :
        IEnemyProvider,
        ISearch
    {
        public EnemySearchProvider()
        {
        }

        /// <inheritdoc />
        public IEnumerable<Enemy> GetEnemiesFoundIn(IEnumerable<string> regions)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<(Enemy Target, Item Item, Acquisition Method, Rarity Rarity, uint Amount)> GetEnemiesThatCarry(IEnumerable<Item> items)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<Enemy> GetEnemiesThatTeach(IEnumerable<Property> properties)
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
