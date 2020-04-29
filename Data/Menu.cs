/* Menu.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// A collection of every time 
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return CompleteMenu; } }
        /// <summary>
        /// A List containing all entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees
        {
            get
            {
                List<IOrderItem> entree = new List<IOrderItem>();
                entree.Add(new AngryChicken());
                entree.Add(new CowpokeChili());
                entree.Add(new DakotaDoubleBurger());
                entree.Add(new PecosPulledPork());
                entree.Add(new RustlersRibs());
                entree.Add(new TexasTripleBurger());
                entree.Add(new TrailBurger());

                return entree;
            }
        }
        /// <summary>
        /// A List containing all drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks
        {
            get
            {
                List<IOrderItem> drink = new List<IOrderItem>();
                drink.Add(new CowboyCoffee());
                drink.Add(new JerkedSoda());
                drink.Add(new TexasTea());
                drink.Add(new Water());

                return drink;
            }
        }
        /// <summary>
        /// A list containing all Sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides
        {
            get
            {
                List<IOrderItem> side = new List<IOrderItem>();

                side.Add(new BakedBeans());
                side.Add(new ChiliCheeseFries());
                side.Add(new CornDodgers());
                side.Add(new PanDeCampo());

                return side;
            }

        }
        /// <summary>
        /// A List containing every item (Entree / Drink / Side) on the menu
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu
        {
            get
            {
                List<IOrderItem> menu = new List<IOrderItem>();
                menu.Add(new AngryChicken());
                menu.Add(new CowpokeChili());
                menu.Add(new DakotaDoubleBurger());
                menu.Add(new PecosPulledPork());
                menu.Add(new RustlersRibs());
                menu.Add(new TexasTripleBurger());
                menu.Add(new TrailBurger());
                menu.Add(new CowboyCoffee());
                menu.Add(new JerkedSoda());
                menu.Add(new TexasTea());
                menu.Add(new Water());
                menu.Add(new BakedBeans());
                menu.Add(new ChiliCheeseFries());
                menu.Add(new CornDodgers());
                menu.Add(new PanDeCampo());

                return menu;
            }
        }
        /// <summary>
        /// Searches the menu for matching items
        /// </summary>
        /// <param name="items">The list of items</param>
        /// <param name="terms">The term being searched</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            if (terms == null) return All;
            if (items == null) return All;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                if(item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }
        /// <summary>
        /// Gets the possible categoir
        /// </summary>
        public static string[] Categories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }
        /// <summary>
        /// Helper method to determine what category the item is in 
        /// </summary>
        /// <param name="item">The item being checked</param>
        /// <returns></returns>
        public static string GetItemType(IOrderItem item)
        {
            if (item is Entree) return "Entree";
            else if (item is Side) return "Side";
            else return "Drink";
        }
        /// <summary>
        /// Filters the provided collection of items by their type (Entree / Side / Drink)
        /// </summary>
        /// <param name="items">The collection of items</param>
        /// <param name="category">The category to include</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> category)
        {
            if (category == null || category.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in items)
            {
                if (item != null && category.Contains(GetItemType(item)))
                {
                    results.Add(item);
                }
            }
            return results;
        }
       /// <summary>
       /// Filters the provided collections of items to those whose prices fall within a specific range
       /// </summary>
       /// <param name="items">The collection of items</param>
       /// <param name="min">The minimum price</param>
       /// <param name="max">The maximum price</param>
       /// <returns>The filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            if(min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach(IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// Filters the provided collections of items to those whose calories fall within a specific range
        /// </summary>
        /// <param name="items">The collection of items</param>
        /// <param name="min">The minimum calories</param>
        /// <param name="max">The maximum calories</param>
        /// <returns>The filtered items</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

    }
}
