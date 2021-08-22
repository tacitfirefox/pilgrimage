namespace pilgrimage.services.core
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines a generic search interface.
    /// </summary>
    internal interface ISearch
    {
        /// <summary>
        /// Perform a search based on a collection of various generic parameters.
        /// </summary>
        /// <typeparam name="TTarget">The type of objects to return from the search.</typeparam>
        /// <param name="indices">Optional; a collection of search parameters.</param>
        /// <returns>A collection of <typeparamref name="TTarget"/> objects.</returns>
        IEnumerable<TTarget> Search<TTarget>(IEnumerable<(string PropertyName, string PropertyValue)> indices = null);
    }
}
