/* ChiliCheeseFries.cs
 * Modified by: Connor Garcia
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Calories for chili cheese fries with 3 different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();

                }
            }
        }
        /// <summary>
        /// Price of chili cheese fries with 3 different sizes
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Chili Cheese Fries</returns>
        public override string ToString()
        {
            return $"{Size} Chili Cheese Fries";
        }
    }
}
