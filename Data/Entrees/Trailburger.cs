using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class TrailBurger : Entree, INotifyPropertyChanged
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

        private bool bun = true;
        /// <summary>
        /// If a bun is on the burger
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                NotifyPropertyChange("Bun");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If ketchup is on the burger
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                NotifyPropertyChange("Ketchup");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If mustard is on the burger
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                NotifyPropertyChange("Mustard");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If pickles are on the burger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyPropertyChange("Pickle");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If cheese is on the burger
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                NotifyPropertyChange("Cheese");
            }
        }

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
        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the cowpoke chili</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
