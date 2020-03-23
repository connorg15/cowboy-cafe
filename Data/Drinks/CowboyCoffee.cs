/* CowboyCoffee.cs
 * Author: Connor Garcia
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A Class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// If Ice is in the Cowboy Coffee
        /// </summary>
        public new bool Ice = false;
        /// <summary>
        /// If the Cowboy Coffee is Decaf
        /// </summary>
        public bool Decaf { get; set; } = false;
        /// <summary>
        /// If there is room for cream in the Coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;
        
        /// <summary>
        /// Price for the Cowboy Coffee drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Calories for the Cowboy Coffee drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Special Instructions for the Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Cowboy Coffee</returns>
        public override string ToString()
        {
            if (Decaf) return $"{Size} Decaf Cowboy Coffee";
            return $"{Size} Cowboy Coffee";
        }
    }
}
