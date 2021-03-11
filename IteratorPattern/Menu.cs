using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public class Menu
    {
        private List<Item> menuItems = new List<Item>();
        public void AddItem(Item item)
        {
            menuItems.Add(item);
        }
        public IItemIterator<Item> Iterator()
        {
            return new MenuItemIterator(this.menuItems);
        }

    }
    public class MenuItemIterator : IItemIterator<Item>
    {
        private int currentIndex = 0;
        private List<Item> menuItems;
        public MenuItemIterator(List<Item> items)
        {
            this.menuItems = items;
        }
        public bool HasNext()
        {
            return currentIndex < menuItems.Count;
        }

        public Item Next()
        {
            return menuItems[currentIndex++];
        }
    }
}
