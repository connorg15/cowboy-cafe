/* Water.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Class representing the Water drink
    /// </summary>
    public class Water : Drink
    {
        private bool ice = true;
        public new bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyPropertyChange("Ice");
            }
        }
        private bool lemon = false;
        /// <summary>
        /// If the drink has lemon, default set to false
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyPropertyChange("Lemon");
            }
        }
        /// <summary>
        /// Price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Special Instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Water</returns>
        public override string ToString()
        {
            return $"{Size} Water";
        }
    }
}
