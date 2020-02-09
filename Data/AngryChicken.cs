using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree
    {
        /// <summary>
        /// Price of Angry Chicken
        /// </summary>
        public override double Price
        {
            get { return 5.99; }
        }
        /// <summary>
        /// Calories of Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get { return 190; }
        }
        private bool bread = true;
        /// <summary>
        /// If the sandwich comes with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
        private bool pickle = true;
        /// <summary>
        /// If pickles are on the sandwich
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// Special instructions for the Angry Chicken
        /// </summary>
        public override List <string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;

            }
        }
    }
}
