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
        public Order (uint i)
        {
            OrderNumber = i;
        }
        /// <summary>
        /// Will be invoked any time a public property in Order.cs is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// List of the items being ordered
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// List of the item prices
        /// </summary>
        private List<string> itemPrices = new List<string>();
        
        /// <summary>
        /// Items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }
       
        /// <summary>
        /// Item prices in the order
        /// </summary>
        public IEnumerable<string> ItemPrices { get { return itemPrices.ToArray(); } }
        
        /// <summary>
        /// Subtotal for order
        /// </summary>
        public double Subtotal { get; private set; }

        /// <summary>
        /// Total for order
        /// </summary>
        public double Total => Subtotal + Tax;
        /// <summary>
        /// Tax for order
        /// </summary>
        public double Tax => Subtotal * 0.16;

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
        public uint OrderNumber { get; private set; }
       
        /// <summary>
        /// Used to track the order number displayed on the UI
        /// </summary>
        public string OrderString => "Order " + OrderNumber.ToString();

        /// <summary>
        /// This method assists in updating the subtotal for changing sizes
        /// *** This method has been implemented from Zachery Burner I did not come up with it ***
        /// </summary>
        /// <param name="i">The item</param>
        /// <param name="new_size">The size the item is suppose to be</param>
        public void subtotalHelperFunction(IOrderItem i, Size new_size)
        {
            Side s;
            Drink d;

            Subtotal -= i.Price;
            if (i is Side)
            {
                s = (Side)i;
                s.Size = new_size;
                Subtotal += s.Price;
            }
            else
            {
                d = (Drink)i;
                d.Size = new_size;
                Subtotal += d.Price;
            }
            itemPrices.RemoveAt(itemPrices.Count - 1);

            string priceOfItemAsCurrency = String.Format("{0:C}", i.Price);
            itemPrices.Add(priceOfItemAsCurrency);
        }

        /// <summary>
        /// INvokes all properties that need to be invoked
        /// </summary>
        public void InvokePropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
        }
    }
}

