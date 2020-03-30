/* TexasTea.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
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
        /// If the drink has lemon, default is set to false
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
        private bool sweet = true;
        /// <summary>
        /// If the tea is sweet, default is set to true
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                NotifyPropertyChange("Sweet");
            }
        }
        /// <summary>
        /// Price of Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Calories of Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(Size == Size.Small && Sweet) return 10;
                else if (Size == Size.Small && !Sweet) return 5;
                else if (Size == Size.Medium && Sweet) return 22;
                else if (Size == Size.Medium && !Sweet) return 11;
                else if (Size == Size.Large && Sweet) return 36;
                else if (Size == Size.Large && !Sweet) return 18;
                else throw new NotImplementedException();
            }
        }
        /// <summary>
        /// Special Instructions for Texas Tea
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
        /// <returns>The string describing the Cowboy Coffee</returns>
        public override string ToString()
        {
            if (Sweet) return $"{Size} Texas Sweet Tea";
            return $"{Size} Texas Plain Tea";
        }
    }
}
