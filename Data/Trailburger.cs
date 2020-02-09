using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger : Entree
    {
        /// <summary>
        /// Price of the burger
        /// </summary>
        public override double Price
        {
            get { return 4.50; }
        }
        /// <summary>
        /// Calories of the burger
        /// </summary>
        public override uint Calories
        {
            get { return 288; }
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
        /// Special instructions for the burger
        /// </summary>
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

                return instructions;
            }
        }
    }
}
