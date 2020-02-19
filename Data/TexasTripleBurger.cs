using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// Price of the burger
        /// </summary>
        public override double Price
        {
            get { return 6.45; }
        }
        /// <summary>
        /// Calories in the burger
        /// </summary>
        public override uint Calories
        {
            get { return 698; }
        }

        /// <summary>
        /// If a bun is on the burger
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If ketchup is on the burger
        /// </summary>
        public bool Ketchup { get; set; } = true;
        /// <summary>
        /// If mustard is on the burger
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If pickles are on the burger
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If cheese is on the burger
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If tomato is on the burger
        /// </summary>      
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If lettuce is on the burger
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If mayo is on the burger
        /// </summary>
        public bool Mayo { get; set; } = true;
        /// <summary>
        /// If bacon is on the burger
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// If egg is on the burger
        /// </summary>
        public bool Egg { get; set; } = true;

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");
                if (!Tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Bacon) instructions.Add("hold bacon");
                if (!Egg) instructions.Add("hold egg");

                return instructions;
            }
        }
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the cowpoke chili</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
