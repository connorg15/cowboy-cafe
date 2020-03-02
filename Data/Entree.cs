/* Entree.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class representing an entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Gets the special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
