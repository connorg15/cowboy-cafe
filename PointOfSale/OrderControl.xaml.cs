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
            var order = new Order();
            this.DataContext = order;
            ItemSelectionButton.Click += ItemSelctionButton_Clicked;
            CancelOrderButton.Click += CancelOrderButton_Clicked;
            CompleteOrderButton.Click += CompleteOrderButton_Clicked;
        }
        public void ItemSelctionButton_Clicked(object sender, RoutedEventArgs e)
        {

        }
        public void CancelOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
        public void CompleteOrderButton_Clicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
    }
}
