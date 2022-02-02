// ====================================================================//
// <copyright file="PilgrimageQuartermaster.cs" company="tacitfirefox">
// Copyright (c) 2021 tacitfirefox. All rights reserved.
// Licensed user the Unlicense license. See LICENSE file in the project root for full license information.
// </copyright>
// ====================================================================//

namespace Quartermaster.Pilgrimage
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.Extensions.Logging;
    using Quartermaster.Core;

    /// <summary>
    /// An implementation of <see cref="IQuartermaster"/> for the world of Final Fantasy X and Final Fantasy X-2.
    /// </summary>
    public class PilgrimageQuartermaster : IQuartermaster
    {
        public PilgrimageQuartermaster(ILogger<IQuartermaster> ledger)
        {
            this.Ledger = ledger ?? throw new ArgumentNullException(nameof(ledger));
        }

        #region [IQuartermaster Implementation]

        /// <inheritdoc/>
        public ILogger<IQuartermaster> Ledger { get; }

        /// <inheritdoc/>
        public string WorldName => "Final Fantasy X|X-2 HD Remaster";

        /// <inheritdoc/>
        public bool OpenInventory()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public bool CloseInventory()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<IEnumerable<ItemBase>> GetAvailableInventory()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<IEnumerable<(ItemBase Item, uint Quantity)>> GetRequiredInventory(IEnumerable<ItemBase> goalItems)
        {
            //-- For each goal item, retrieve the item's data from the repository and get all required items and quantities for it,
            //-- adding them to the result set.
            throw new NotImplementedException();
        }

        #endregion
    }
}
