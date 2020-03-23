using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// Price of ribs
        /// </summary>
        public override double Price
        {
            get { return 7.50; }
        }
        /// <summary>
        /// Calories of ribs
        /// </summary>
        public override uint Calories
        {
            get { return 894; }
        }
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the cowpoke chili</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
