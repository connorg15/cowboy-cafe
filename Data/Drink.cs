﻿/* Drink.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a Drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;
        /// <summary>
        /// Price of the drink
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// If ice is in the drink, default value set to true
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// Special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
