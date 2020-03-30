/* CustomizeSideSize.xaml.cs
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
    /// Interaction logic for CustomizeSideSize.xaml
    /// </summary>
    public partial class CustomizeSideSize : UserControl
    {
        private Order order;
        public CustomizeSideSize(object dataContext)
        {
            order = (Order)dataContext;
            InitializeComponent();
        }
        /// <summary>
        /// Click event handler for Side Size Selection
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e"></param>
        void Radio_Button_Click(object sender, RoutedEventArgs e)
        {
            Side side;
            if (DataContext is BakedBeans)
                side = (BakedBeans)DataContext;
            else if (DataContext is ChiliCheeseFries)
                side = (ChiliCheeseFries)DataContext;
            else if (DataContext is CornDodgers)
                side = (CornDodgers)DataContext;
            else
                side = (PanDeCampo)DataContext;

            switch (((RadioButton)sender).Name)
            {
                case "Small_Button":
                    side.Size = CowboyCafe.Data.Size.Small;
                    break;
                case "Medium_Button":
                    side.Size = CowboyCafe.Data.Size.Medium;
                    break;
                case "Large_Button":
                    side.Size = CowboyCafe.Data.Size.Large;
                    break;
                default:
                    throw new NotImplementedException();

            }
            order.InvokePropertyChanged();
        }
    }
}
