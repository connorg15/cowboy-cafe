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
        private List<string> itemPrices = new List<string>();
        /// <summary>
        /// Items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Subtotal for order
        /// </summary>
        public double Subtotal { get; private set; }

        /// <summary>
        /// Adding an item to the order
        /// *** Lines 41-43 of this method have been implemented from Zachery Burner ***
        /// </summary>
        /// <param name="item">The item being added</param>

        public void Add(IOrderItem item)
        {
            double itemPrice = item.Price;
            string currency = String.Format("{0:c}", itemPrice);
            Subtotal += itemPrice;

            items.Add(item);
            itemPrices.Add(currency);
            InvokePropertyChanged();
        }
        /// <summary>
        /// Removing an item from the order
        /// *** Lines 56-58 of this method have been implemented from Zachery Burner ***
        /// </summary>
        /// <param name="item">The item being removed</param>
        public void Remove(IOrderItem item)
        {
            double itemPrice = item.Price;
            string currency = String.Format("{0:c}", itemPrice);
            Subtotal -= itemPrice;

            items.Remove(item);
            itemPrices.Add(currency);
            InvokePropertyChanged();
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

        /// <summary>
        /// INvokes all properties that need to be invoked
        /// </summary>
        public void InvokePropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}

