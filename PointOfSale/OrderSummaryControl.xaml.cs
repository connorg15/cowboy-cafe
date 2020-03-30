/* OrderSummaryControl.xaml.cs
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
using Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Changes to the item menu that is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnChangeSelectedItem(object sender, SelectionChangedEventArgs e)
        {
            FrameworkElement screen = null;
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is ListBox lb)
                {
                    if (lb.SelectedItem is IOrderItem item)
                    {
                        if (item is CowpokeChili)
                        {
                            screen = new CustomizeCowpokeChili();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is AngryChicken)
                        {
                            screen = new CustomizeAngryChicken();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is DakotaDoubleBurger)
                        {
                            screen = new CustomizeDakotaDoubleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is PecosPulledPork)
                        {
                            screen = new CustomizePecosPulledPork();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TexasTripleBurger)
                        {
                            screen = new CustomizeTexasTripleBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TrailBurger)
                        {
                            screen = new CustomizeTrailBurger();
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is BakedBeans)
                        {
                            screen = new CustomizeSideSize(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is ChiliCheeseFries)
                        {
                            screen = new CustomizeSideSize(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is CornDodgers)
                        {
                            screen = new CustomizeSideSize(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is PanDeCampo)
                        {
                            screen = new CustomizeSideSize(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is CowboyCoffee)
                        {
                            screen = new CustomizeCowboyCoffee(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is JerkedSoda)
                        {
                            screen = new CustomizeJerkedSoda(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is TexasTea)
                        {
                            screen = new CustomizeTexasTea(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if (item is Water)
                        {
                            screen = new CustomizeWater(DataContext);
                            screen.DataContext = item;
                            orderControl?.SwapScreen(screen);
                        }
                        else if(item is RustlersRibs)
                        {

                        }
                        else
                        {
                            throw new NotImplementedException("Item has not been implemented");
                        }
                    }
                }
                order.InvokePropertyChanged();
            }
        }
        /// <summary>
        /// Deletes the item that the red x button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    order.Remove((IOrderItem)button.DataContext);
                }
            }
        }
    }
}
