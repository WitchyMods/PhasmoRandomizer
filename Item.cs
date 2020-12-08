using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhasmoRandomizer
{
    public class Item
    {
        public static List<Item> AllItems = new List<Item>() {
            new Item("EMF Reader", 2),
            new Item("Flashlight", 4, true, true),
            new Item("Photo Camera", 3),
            new Item("Lighter", 2, true),
            new Item("Candle", 4, true),
            new Item("UV Light", 2, true),
            new Item("Crucifix", 2),
            new Item("Video Camera", 6),
            new Item("Spirit Box", 2),
            new Item("Salt", 2),
            new Item("Smudge Stick", 4),
            new Item("Tripod", 5),
            new Item("Strong Flashlight", 4, true, true),
            new Item("Motion Sensor", 4),
            new Item("Sound Sensor", 4),
            new Item("Sanity Pills", 4),
            new Item("Thermometer", 3),
            new Item("Ghost Writing Book", 2),
            new Item("Infrared Light Sensor",4),
            new Item("Parabolic Microphone", 2),
            new Item("Glowstick", 2, true),
            new Item("Head Mounted Camera", 4)
        };

        public string Name { get; set; }
        public int MaxQty { get; set; }
        public int DefaultMaxQty { get; set; }
        public bool IsLight { get; set; }
        public bool IsFlashlight { get; set; }

        public int QtyLeft { get; set; }

        public Item(string name, int qty, bool isLight = false, bool isFlashlight = false)
        {
            this.Name = name;
            this.MaxQty = this.DefaultMaxQty = qty;
            this.IsLight = isLight;
            this.IsFlashlight = isFlashlight;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
