using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhasmoRandomizer
{
    public static class Randomizer
    {
        private static Random r = new Random();

        public static int NbPlayers { get; private set; } = 1;
        public static int NbItemsPerPlayer { get; private set; } = 3;
        public static bool ForceFlashlight { get; set; } = false;
        public static bool ForceLightsource { get; set; } = false;

        public static List<ItemList> SelectedItems { get; private set; } = new List<ItemList>();

        public static void SetNbPlayers(int nbPlayers)
        {
            NbPlayers = nbPlayers;

            while (NbPlayers < SelectedItems.Count)
            {
                List<int> itemsToReturn = SelectedItems.Last();

                foreach (var itemId in itemsToReturn)
                {
                    Item.AllItems[itemId].QtyLeft++;
                }

                SelectedItems.RemoveAt(SelectedItems.Count - 1);
            }

            while (NbPlayers > SelectedItems.Count)
            {
                ItemList itemsToAdd = new ItemList();
                SelectedItems.Add(itemsToAdd);
                Randomize(itemsToAdd);
            }
        }

        public static void SetNbItemsPerPlayer(int nbItems)
        {
            NbItemsPerPlayer = nbItems;

            foreach (var list in SelectedItems)
            {
                Randomize(list);
            }
        }

        static Randomizer()
        {
            SelectedItems.Add(new ItemList());
        }

        public static void Randomize()
        {
            //Reset all of the items
            for (int i = 0; i < Item.AllItems.Count; i++)
            {
                Item.AllItems[i].QtyLeft = Item.AllItems[i].MaxQty;
            }

            //Reset all the lists
            foreach (var list in SelectedItems)
                for (int i = 0; i < list.Count; i++)
                    list[i] = -1;

            //Randomize all the lists
            foreach (var list in SelectedItems)
                Randomize(list);
        }

        public static void Randomize(ItemList itemList)
        {
            //Fill the missing slots with empty items
            itemList.AdjustSize(NbItemsPerPlayer);

            if ((ForceFlashlight || ForceLightsource) && !itemList.HasFlashlight() && !itemList.HasEmptyItems() && Item.AllItems.Count(x => x.QtyLeft > 0 && x.IsFlashlight) > 0)
            {
                itemList[0] = -1;
            }

            List<Item> randomItems = Item.AllItems.Where(x => x.QtyLeft > 0).ToList();

            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i] < 0 && ForceFlashlight && !itemList.HasFlashlight())
                {
                    AddFlashlight(itemList, r, randomItems, i);
                }

                if (itemList[i] < 0 && ForceLightsource && !itemList.HasLightsource())
                {
                    AddLightsource(itemList, r, randomItems, i);
                }

                while (itemList[i] < 0 && randomItems.Any())
                {
                    var item = randomItems[r.Next(0, randomItems.Count)];
                    int itemId = Item.AllItems.IndexOf(item);

                    if (!itemList.Contains(itemId))
                    {
                        item.QtyLeft--;
                        itemList[i] = itemId;
                    }

                    randomItems.Remove(item);
                }
            }
        }

        private static void AddLightsource(List<int> itemList, Random r, List<Item> randomItems, int i)
        {
            var lights = randomItems.Where(x => x.IsLight).ToList();

            if (lights.Any())
            {
                randomItems.RemoveAll(x => lights.Contains(x));

                var light = lights[r.Next(0, lights.Count)];
                light.QtyLeft--;

                itemList[i] = Item.AllItems.IndexOf(light);
            }
        }

        private static void AddFlashlight(List<int> itemList, Random r, List<Item> randomItems, int i)
        {
            var flashlightItems = randomItems.Where(x => x.IsFlashlight).ToList();

            if (flashlightItems.Any())
            {
                randomItems.RemoveAll(x => flashlightItems.Contains(x));
                Item flashlight = flashlightItems[r.Next(0, flashlightItems.Count)];
                flashlight.QtyLeft--;

                itemList[i] = Item.AllItems.IndexOf(flashlight);
            }
        }
    }
}
