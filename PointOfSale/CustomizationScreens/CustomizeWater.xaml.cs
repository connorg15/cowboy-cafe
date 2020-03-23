using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
/* CustomizeWater.xaml.cs
 * Author: Connor Garcia
 */
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeWater.xaml
    /// </summary>
    public partial class CustomizeWater : UserControl
    {
        private Order order;
        public CustomizeWater(object dataContext)
        {
            order = (Order)dataContext;
            InitializeComponent();
        }
        void Button_Click(object sender, RoutedEventArgs e)
        {
            Water drink = (Water)DataContext;

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
                case "Lemon_Button":
                    drink.Lemon = true;
                    break;
                case "NoLemon_Button":
                    drink.Lemon = false;
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
