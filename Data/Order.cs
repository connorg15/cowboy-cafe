/* Order.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Last order number
        /// </summary>
        private uint lastOrderNumber;
        
        /// <summary>
        /// List of the items being ordered
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items => items;
        
        private double subtotal;
        /// <summary>
        /// Subtotal for order
        /// </summary>
        public double Subtotal => subtotal;

        /// <summary>
        /// Adding an item to the order
        /// </summary>
        /// <param name="item">The item being added</param>

        public void Add(IOrderItem item)
        {
            items.Add(item);
            subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
        /// <summary>
        /// Removing an item from the order
        /// </summary>
        /// <param name="item">The item being removed</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
