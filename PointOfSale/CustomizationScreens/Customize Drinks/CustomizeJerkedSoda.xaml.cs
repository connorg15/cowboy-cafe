/* CustomizeJerkedSoda.xaml.cs
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
using Size = CowboyCafe.Data.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeJerkedSoda.xaml
    /// </summary>
    public partial class CustomizeJerkedSoda : UserControl
    {
        private Order order;
        public CustomizeJerkedSoda(object dataContext)
        {
            order = (Order)dataContext;
            InitializeComponent();
        }
        void Button_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda drink = (JerkedSoda)DataContext;

            switch (((Button)sender).Name)
            {
                case "Small_Button":
                    drink.Size = CowboyCafe.Data.Size.Small;
                    break;
                case "Medium_Button":
                    drink.Size = CowboyCafe.Data.Size.Medium;
                    break;
                case "Large_Button":
                    drink.Size = CowboyCafe.Data.Size.Large;
                    break;
                case "BirchBeer_Button":
                    drink.Flavor = SodaFlavor.BirchBeer;
                    break;
                case "RootBeer_Button":
                    drink.Flavor = SodaFlavor.RootBeer;
                    break;
                case "CreamSoda_Button":
                    drink.Flavor = SodaFlavor.CreamSoda;
                    break;
                case "OrangeSoda_Button":
                    drink.Flavor = SodaFlavor.OrangeSoda;
                    break;
                case "Sarsparilla_Button":
                    drink.Flavor = SodaFlavor.Sarsparilla;
                    break;
                case "Ice_Button":
                    drink.Ice = true;
                    break;
                case "NoIce_Button":
                    drink.Ice = false;
                    break;
                default:
                    throw new NotImplementedException();
            }
            order.InvokePropertyChanged();
        }
        /// <summary>
        /// Checks for which size has been selected and updates the price, subtotal, and size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Radio_Button_Click(object sender, RoutedEventArgs e)
        {
            Drink drink = (JerkedSoda)DataContext;
            Size size;

            switch (((RadioButton)sender).Name)
            {
                case "Small_Button":
                    size = Size.Small;
                    break;
                case "Medium_Button":
                    size = Size.Medium;
                    break;
                case "Large_Button":
                    size = Size.Large;
                    break;
                default:
                    throw new NotImplementedException();
            }
            order.subtotalHelperFunction(drink, size);
            order.InvokePropertyChanged();
            drink.InvokeSizePropertyChanged();
        }
    }
}
