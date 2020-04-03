/* Side.cs
 * Modified by: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side: IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Size size;
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
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public List<string> SpecialInstructions { get; }

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
