/* JerkedSoda.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Price of the Jerked Soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Calories of the Jerked Soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
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
        /// <summary>
        /// Flavor of the Jerked Soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }
        /// <summary>
        /// Special Instructions for the Jerked Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Jerked Soda</returns>
        public override string ToString()
        {
            if (Flavor == SodaFlavor.CreamSoda) return $"{Size} Cream Soda Jerked Soda";
            else if (Flavor == SodaFlavor.OrangeSoda) return $"{Size} Orange Soda Jerked Soda";
            else if (Flavor == SodaFlavor.Sarsparilla) return $"{Size} Sarsparilla Jerked Soda";
            else if (Flavor == SodaFlavor.BirchBeer) return $"{Size} Birch Beer Jerked Soda";
            else if (Flavor == SodaFlavor.RootBeer) return $"{Size} Root Beer Jerked Soda";
            else throw new NotImplementedException();
        }
    }
}
