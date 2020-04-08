/* CashRegisterControl.xaml.cs
 * Author: Connor Garcia
 * 
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
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl 
    {
        public CashRegisterControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click event handler to print the receipt of the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if(DataContext is CashRegisterModelView view)
            {
                ReceiptPrinter receipt = new ReceiptPrinter();
                MessageBox.Show("Payment Successful");
                receipt.Print("Order Number: " + view.orderNum.ToString() + "\n");
                receipt.Print("Date: " + DateTime.Now.ToString() + "\n");
                //foreach (IOrderItem item in .Items)
                //{
                //    receipt.Print(item.ToString() + "  ");
                //    receipt.Print(String.Format("{0:C2}", item.Price) + "\n");
                //    foreach (string s in item.SpecialInstructions)
                //    {
                //        receipt.Print("- " + s.ToString() + "\n");
                //    }
                //}
                receipt.Print("Paid: " + String.Format("{0:C2}", view.TotalValue) + "\n");
                receipt.Print("Change: " + String.Format("{0:C2}", (view.TotalValue - view.orderTotal)) + "\n");
            }
        }
    }
}
