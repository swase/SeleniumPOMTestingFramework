using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.utils
{
    public class UserPageAddInventoryItems
    {

        public Dictionary<Items, string> Inventory { get; } = new Dictionary<Items, string>();
        //public Items SelectedItem { get; set; }
        public UserPageAddInventoryItems()
        {
            Inventory.Add(Items.Backpack, "-sauce-labs-backpack");
            Inventory.Add(Items.BikeLight, "-sauce-labs-bike-light");
            Inventory.Add(Items.BlackShirt, "-sauce-labs-bolt-t-shirt");
            Inventory.Add(Items.Jacket, "-sauce-labs-fleece-jacket");
            Inventory.Add(Items.Onesie, "-sauce-labs-onesie");
            Inventory.Add(Items.RedShirt, "-test.allthethings()-t-shirt-(red)");
        }

        public string GetAddItemId(Items item)
        {
            return $"add-to-cart{Inventory[item]}";
        }
        public string GetRemoveItemId(Items item) => $"remove{Inventory[item]}";
    }

    public enum Items
    {
        Backpack,
        BikeLight,
        BlackShirt,
        Jacket,
        Onesie,
        RedShirt
    }
}
