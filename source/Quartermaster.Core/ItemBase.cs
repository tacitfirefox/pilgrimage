// ====================================================================//
// <copyright file="ItemBase.cs" company="tacitfirefox">
// Copyright (c) 2021 tacitfirefox. All rights reserved.
// Licensed user the Unlicense license. See LICENSE file in the project root for full license information.
// </copyright>
// ====================================================================//

namespace Quartermaster.Core
{
    /// <summary>
    /// Defines a useable item in a quartermaster's inventory.
    /// </summary>
    public abstract class ItemBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemBase"/> class.
        /// </summary>
        /// <param name="name">The name of the item.</param>
        /// <param name="description">The description of the item.</param>
        public ItemBase(
            string name,
            string description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Gets the name of this item.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description of this item.
        /// </summary>
        public string Description { get; }
    }
}
