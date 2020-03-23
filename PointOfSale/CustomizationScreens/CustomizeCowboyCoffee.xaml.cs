/* CustomizeCowboyCoffee.xaml.cs
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
    /// Interaction logic for CustomizeCowboyCoffee.xaml
    /// </summary>
    public partial class CustomizeCowboyCoffee : UserControl
    {
        private Order order;
        public CustomizeCowboyCoffee(object DataContext)
        {
            order = (Order)DataContext;
            InitializeComponent();
        }
        void Button_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee drink = (CowboyCoffee)DataContext;

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
                case "Decaf_Button":
                    drink.Decaf = true;
                    break;
                case "NoDecaf_Button":
                    drink.Decaf = false;
                    break;
                case "RoomForCream_Button":
                    drink.RoomForCream = true;
                    break;
                case "NoRoomForCream_Button":
                    drink.RoomForCream = false;
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
    }
}
