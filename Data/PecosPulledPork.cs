using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// Price of pulled pork
        /// </summary>
        public override double Price
        {
            get { return 5.88; }
        }
        /// <summary>
        /// Calories of pulled pork
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }
        private bool bread = true;
        /// <summary>
        /// If bread is on the pulled pork
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
        private bool pickle = true;
        /// <summary>
        /// If pickles are on the pulled pork
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// Special instructions for pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Pecos Pulled Pork</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
