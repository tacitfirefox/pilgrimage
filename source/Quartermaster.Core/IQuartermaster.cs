// ====================================================================//
// <copyright file="IQuartermaster.cs" company="tacitfirefox">
// Copyright (c) 2021 tacitfirefox. All rights reserved.
// Licensed user the Unlicense license. See LICENSE file in the project root for full license information.
// </copyright>
// ====================================================================//

namespace Quartermaster.Core
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Defines a single module that manages various world data for the purposes of determining items, quantities, and sources for various uses.
    /// </summary>
    public interface IQuartermaster
    {
        /// <summary>
        /// Gets the logger for this quartermaster.
        /// </summary>
        ILogger<IQuartermaster> Ledger { get; }

        /// <summary>
        /// Gets the name of the world (game) this quartermaster belongs to.
        /// </summary>
        string WorldName { get; }

        #region [Quartermaster Management]

        /// <summary>
        /// Initializes the quartermaster, loading any on-demand data.
        /// </summary>
        /// <returns>True if the quartermaster successfully loads the world inventory; false otherwise.</returns>
        bool OpenInventory();

        /// <summary>
        /// Uninitializes the quartermaster, unloading any on-demand data and clearing resources.
        /// </summary>
        /// <returns>True if the quartermaster successfully unloads the world inventory; false otherwise.</returns>
        bool CloseInventory();

        #endregion

        #region [Inventory Queries]

        /// <summary>
        /// Gets a collection of available items from the quartermaster.
        /// </summary>
        /// <returns>A collection of <see cref="ItemBase"/> objects.</returns>
        Task<IEnumerable<ItemBase>> GetAvailableInventory();

        /// <summary>
        /// Gets a collection of component material items and quantities of those items required to craft, customize, or otherwise create the entire given collection of items.
        /// </summary>
        /// <param name="goalItems">The collection of items intended for creation.</param>
        /// <returns>A collection of required <see cref="ItemBase"/>s and their needed quantities to create the goal items.</returns>
        Task<IEnumerable<(ItemBase Item, uint Quantity)>> GetRequiredInventory(IEnumerable<ItemBase> goalItems);

        #endregion
    }
}
