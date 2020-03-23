using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Price of the burger
        /// </summary>
        public override double Price
        {
            get { return 5.20; }
        }
        /// <summary>
        /// Calories of the burger
        /// </summary>
        public override uint Calories
        {
            get { return 464; }
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
        private bool tomato = true;
        /// <summary>
        /// If tomato is on the burger
        /// </summary>      
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                NotifyPropertyChange("Tomato");
            }
        }
        private bool lettuce = true;
        /// <summary>
        /// If lettuce is on the burger
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                NotifyPropertyChange("Lettuce");
            }
        }
        private bool mayo = true;
        /// <summary>
        /// If mayo is on the burger
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                NotifyPropertyChange("Mayo");
            }
        }

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

                return instructions;
            }
        }
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
