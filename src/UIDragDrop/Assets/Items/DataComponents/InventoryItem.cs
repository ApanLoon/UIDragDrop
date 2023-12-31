using DataObjects;
using System;

namespace Items
{
    [Serializable]
    public class InventoryItem : DataDefinitionComponent
    {
        /// <summary>
        /// Defines how many can be stacked in an inventory slot.
        /// </summary>
        public int MaxStackSize = 1;

        /// <summary>
        /// Base price for buying or selling. Trader percentages are added to this.
        /// </summary>
        public int BasePrice = 1;
    }
}

