namespace pilgrimage.domain
{
    using System;
    using System.Collections.Generic;

    using pilgrimage.domain.enumerations;

    /// <summary>
    /// Defines an enemy combatant.
    /// </summary>
    public class Enemy
    {
        public Guid Id { get; }

        public string Name { get; }

        public uint Gil { get; }

        public uint Ap { get; }

        public uint? BribeCost { get; }

        public ushort EquipmentDropRate { get; }

        public IEnumerable<Property> EquipmentProperties { get; }

        public Statistics Statistics { get; }

        public Resistances Resistances { get; }

        public IEnumerable<(Item Item, Acquisition AcquisitionMethod, Rarity Rarity)> Inventory { get; }
    }
}
