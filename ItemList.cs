
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhasmoRandomizer
{
    public class ItemList : List<int>
    {
        public void AdjustSize(int size)
        {
            while(this.Count < size)
            {
                this.Add(-1);
            }

            while(this.Count > size)
            {
                int itemId = this.Last();

                if (itemId >= 0)
                    Item.AllItems[itemId].QtyLeft++;

                this.RemoveAt(this.Count - 1);
            }
        }

        public bool HasEmptyItems()
        {
            return this.Count(x => x < 0) != 0;
        }

        public bool HasFlashlight()
        {
            foreach (var itemId in this.Where(x => x >= 0))
            {
                Item item = Item.AllItems[itemId];
                if (item.IsFlashlight) return true;
            }

            return false;
        }

        public bool HasLightsource()
        {
            foreach (var itemId in this.Where(x => x >= 0))
            {
                Item item = Item.AllItems[itemId];
                if (item.IsLight) return true;
            }

            return false;
        }
    }
}
