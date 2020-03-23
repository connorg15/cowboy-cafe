/* CustomizeTexasTea.xaml.cs
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
    /// Interaction logic for CustomizeTexasTea.xaml
    /// </summary>
    public partial class CustomizeTexasTea : UserControl
    {
        private Order order;
        public CustomizeTexasTea(object dataContext)
        {
            order = (Order)dataContext;
            InitializeComponent();
        }

        void Button_Click(object sender, RoutedEventArgs e)
        {
            TexasTea drink = (TexasTea)DataContext;

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
                case "Sweet_Button":
                    drink.Sweet = true;
                    break;
                case "Plain_Button":
                    drink.Sweet = false;
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
