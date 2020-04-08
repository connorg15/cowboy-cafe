/* TransactionControl.xaml.cs
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
using CashRegister;
using ResultCode = CashRegister.ResultCode;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// Receipt variable
        /// </summary>
        ReceiptPrinter receipt = new ReceiptPrinter();
        public TransactionControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Click event for the option to pay with credit card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayWithCreditClicked(object sender, RoutedEventArgs e)
        {
            Order o = (Order)DataContext;
            CardTerminal ct = new CardTerminal();

            ResultCode result = ct.ProcessTransaction(o.Total);
            if(DataContext is Order order)
            {
                switch (result)
                {
                    case ResultCode.Success:
                        MessageBox.Show("Payment Successful");
                        receipt.Print("Order Number: " + order.OrderNumber.ToString() + "\n");
                        receipt.Print("Date: " + DateTime.Now.ToString() + "\n");
                        foreach (IOrderItem item in order.Items)
                        {
                            receipt.Print(item.ToString() + "  ");
                            receipt.Print(String.Format("{0:C2}", item.Price) + "\n");
                            foreach (string s in item.SpecialInstructions)
                            {
                                receipt.Print("- " + s.ToString() + "\n");
                            }
                        }
                        receipt.Print("Payed with: Credit\n\n");
                        break;
                    case ResultCode.InsufficentFunds:
                        MessageBox.Show("Insufficent Funds, please try a different card or pay with cash");
                        break;
                    case ResultCode.ReadError:
                        MessageBox.Show("Read Error, please try again");
                        break;
                    case ResultCode.UnknownErrror:
                        MessageBox.Show("Unknown Error, please try again");
                        break;
                    case ResultCode.CancelledCard:
                        MessageBox.Show("This card is cancelled, please use a different cad or pay with cash");
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }
        /// <summary>
        /// Click event for the option to pay with cash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PayWithCashClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var screen = new CashRegisterControl();
                screen.DataContext = new CashRegisterModelView(order.Total, order.OrderNumber);
                this.Content = screen;
            }
        }
        /// <summary>
        /// Click event to cancel the transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelTransaction_Click(object sender, RoutedEventArgs e)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }
    }
}
