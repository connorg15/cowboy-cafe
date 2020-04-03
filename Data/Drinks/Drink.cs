/* Drink.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a Drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Size of the drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
            }
        }
        /// <summary>
        /// Price of the drink
        /// </summary>
        public abstract double Price { get; }
        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// If ice is in the drink, default value set to true
        /// </summary>
        public bool Ice { get; set; }
        /// <summary>
        /// Special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Checks if the value of size is Small
        /// </summary>
        public bool IsSmall
        {
            get { return Size == Size.Small; }
            set { Size = Size.Small; }
        }
        /// <summary>
        /// Checks if the value of Size is Medium
        /// </summary>
        public bool IsMedium
        {
            get { return Size == Size.Medium; }
            set { Size = Size.Medium; }
        }
        /// <summary>
        /// Checks if the value of Size is Large
        /// </summary>
        public bool IsLarge
        {
            get { return Size == Size.Large; }
            set { Size = Size.Large; }
        }
        protected void NotifyPropertyChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
        /// <summary>
        /// Invokes boolean properties for radio buttons
        /// </summary>
        public void InvokeSizePropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSmall"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsMedium"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLarge"));
        }
    }
}
