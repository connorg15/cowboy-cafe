/* PanDeCampo.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PanDeCampo : Side
    {
        /// <summary>
        /// Calories for the Pan De Campo with 3 different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Price for the Pan De Camp with 3 different sizes
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
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Pan De Campo</returns>
        public override string ToString()
        {
            return $"{Size} Pan de Campo";
        }
    }
}
