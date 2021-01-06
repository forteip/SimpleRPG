using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(1001, "Pointy stick", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Rusty sword", 5, 1, 3));
        }

        public static GameItem CreateGameItem(int itemTypeId)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeId);

            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}
