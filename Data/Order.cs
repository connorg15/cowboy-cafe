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
        static private uint lastOrderNumber = 1;

        /// <summary>
        /// List of the items being ordered
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

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
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
        /// <summary>
        /// Removing an item from the order
        /// </summary>
        /// <param name="item">The item being removed</param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
        }
        /// <summary>
        /// Gets the order number which increases the last order number by 1
        /// </summary>
        public uint OrderNumber => lastOrderNumber++;
        /// <summary>
        /// Will be invoked any time a public property in Order.cs is changed
        /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Used to track the order number displayed on the UI
        /// </summary>

        public string OrderString => "Order " + OrderNumber.ToString();

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}
