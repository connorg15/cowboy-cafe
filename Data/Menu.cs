/* Menu.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// A List containing all entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entree()
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
        /// <summary>
        /// A List containing all drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drink()
        {
            List<IOrderItem> drink = new List<IOrderItem>();
            drink.Add(new CowboyCoffee());
            drink.Add(new JerkedSoda());
            drink.Add(new TexasTea());
            drink.Add(new Water());

            return drink;
        }
        /// <summary>
        /// A list containing all Sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Side()
        {
            List<IOrderItem> side = new List<IOrderItem>();

            side.Add(new BakedBeans());
            side.Add(new ChiliCheeseFries());
            side.Add(new CornDodgers());
            side.Add(new PanDeCampo());

            return side;
        }
        /// <summary>
        /// A List containing every item (Entree / Drink / Side) on the menu
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            menu.Add((IOrderItem)Side());
            menu.Add((IOrderItem)Drink());
            menu.Add((IOrderItem)Entree());

            return menu;
        }
    }
}
