/* OrderControl.xaml.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();

            var order = new Order(1);
            this.DataContext = order;
            ItemSelectionButton.Click += ItemSelctionButton_Clicked;
            CancelOrderButton.Click += CancelOrderButton_Clicked;
            CompleteOrderButton.Click += CompleteOrderButton_Clicked;
        }
        /// <summary>
        /// *Not Implemented Yet*
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ItemSelctionButton_Clicked(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
        /// <summary>
        /// Cancels the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CancelOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            Order o = (Order)DataContext;
            DataContext = new Order(o.OrderNumber + 1);
        }
        /// <summary>
        /// Completes the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CompleteOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            var screen = new TransactionControl();
            SwapScreen(screen);
        }
        /// <summary>
        /// Swaps the currently displayed screen
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
    }
}
