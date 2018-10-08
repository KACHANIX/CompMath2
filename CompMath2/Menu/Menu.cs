﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMath2.Menu
{
    public class Menu
    {
        private List<MenuItem> _items = new List<MenuItem>();
        public void AddItem(string desc, Func<bool> a)
        {
            var item = new MenuItem
            {
                Action = a,
                Description = desc,
                Key = (ConsoleKey)(_items.Count + 49)
            };
            _items.Add(item);
        }
        public bool Display()
        {
            int i = 1;
            foreach (MenuItem item in _items)
            {
                Console.WriteLine($"{i++}. {item.Description}");
            }

            Console.Write("Choose the function to integrate : ");
            ConsoleKey input = Console.ReadKey().Key;

            foreach (MenuItem item in _items)
            {
                if (item.Key == input)
                {
                    return item.Action();
                }
            }
            return true;
        }
    }
}
