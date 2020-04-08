/* CashRegisterModelView.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer this class uses
        /// </summary>
        private CashDrawer drawer = new CashDrawer();
        /// <summary>
        /// Holds the order total
        /// </summary>
        public double orderTotal = 0;
        /// <summary>
        /// Holds the order number
        /// </summary>
        public uint orderNum = 0;
        public CashRegisterModelView(double t, uint num)
        {
            orderTotal = t;
            orderNum = num;
        }
        /// <summary>
        /// The total amount of currency in the drawer
        /// </summary>
        public double TotalValue { get; private set; }

        /// <summary>
        /// Penny count variable
        /// </summary>
        private int penny = 0;
        /// <summary>
        /// The amount of Pennies in the Cash Register
        /// </summary>
        public int Pennies
        {
            get => penny;
            set
            {
                if (penny == value || value < 0) return;
                var quantity = value - penny;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    penny++;
                    TotalValue += 0.01;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    penny--;
                    TotalValue -= 0.01;
                }
                InvokePropertyChanged("Pennies");
            }
        }
        /// <summary>
        /// Nickel coumt variable
        /// </summary>
        private int nickel = 0;

        /// <summary>
        /// The amount of Nickels in the Cash Register
        /// </summary>
        public int Nickels
        {
            get => nickel;
            set
            {
                if (nickel == value || value < 0) return;
                var quantity = value - nickel;
                if (quantity > 0) 
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                    nickel++;
                    TotalValue += 0.05;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    nickel--;
                    TotalValue -= 0.05;
                }
                InvokePropertyChanged("Nickels");
            }
        }
        /// <summary>
        /// Dime count variable
        /// </summary>
        private int dime = 0;
        /// <summary>
        /// The amount of Dimes in the Cash Register
        /// </summary>
        public int Dimes
        {
            get => dime;
            set
            {
                if (dime == value || value < 0) return;
                var quantity = value - dime;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantity);
                    dime++;
                    TotalValue += 0.10;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                    dime--;
                    TotalValue -= 0.10;
                }
                InvokePropertyChanged("Dimes");
            }
        }
        /// <summary>
        /// Quarter count variable
        /// </summary>
        private int quarter = 0;
        /// <summary>
        /// The amount of Quarters in the Cash Register
        /// </summary>
        public int Quarters
        {
            get => quarter;
            set
            {
                if (quarter == value || value < 0) return;
                var quantity = value - quarter;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quantity);
                    quarter++;
                    TotalValue += 0.25;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                    quarter--;
                    TotalValue -= 0.25;
                }
                InvokePropertyChanged("Quarters");
            }
        }
        /// <summary>
        /// Half Dollar count variable
        /// </summary>
        private int halfdollar = 0;
        /// <summary>
        /// The amount of Half Dollars in the Cash Register
        /// </summary>
        public int HalfDollars
        {
            get => halfdollar;
            set
            {
                if (halfdollar == value || value < 0) return;
                var quantity = value - halfdollar;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                    halfdollar++;
                    TotalValue += 0.50;
                }
                else
                {
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                    halfdollar--;
                    TotalValue -= 0.50;
                }
                InvokePropertyChanged("HalfDollars");
            }
        }
        /// <summary>
        /// One Dollar Bill count variable
        /// </summary>
        private int one = 0;
        /// <summary>
        /// The amount of One Dollar Bills in the Cash Register
        /// </summary>
        public int Ones
        {
            get => one;
            set
            {
                if (one == value || value < 0) return;
                var quantity = value - one;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.One, quantity);
                    one++;
                    TotalValue += 1.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                    one--;
                    TotalValue -= 1.00;
                }
                InvokePropertyChanged("Ones");
            }
        }
        /// <summary>
        /// Two Dollar Bill count variable
        /// </summary>
        private int two = 0;
        /// <summary>
        /// The amount of Two Dollar Bills in the Cash Register
        /// </summary>
        public int Twos
        {
            get => two;
            set
            {
                if (two == value || value < 0) return;
                var quantity = value - two;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Two, quantity);
                    two++;
                    TotalValue += 2.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                    two--;
                    TotalValue -= 2.00;
                }
                InvokePropertyChanged("Twos");
            }
        }
        /// <summary>
        /// Five Dollar Bill count variable
        /// </summary>
        private int five = 0;

        /// <summary>
        /// The amount of Five Dollar Bills in the Cash Register
        /// </summary>
        public int Fives
        {
            get => five;
            set
            {
                if (five == value || value < 0) return;
                var quantity = value - five;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Five, quantity);
                    five++;
                    TotalValue += 5.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                    five--;
                    TotalValue -= 5.00;
                }
                InvokePropertyChanged("Fives");
            }
        }
        /// <summary>
        /// Ten Dollar Bill count variable
        /// </summary>
        private int ten = 0;
        /// <summary>
        /// The amount of Ten Dollar Bills in the Cash Register
        /// </summary>
        public int Tens
        {
            get => ten;
            set
            {
                if (ten == value || value < 0) return;
                var quantity = value - ten;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Ten, quantity);
                    ten++;
                    TotalValue += 10.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                    ten--;
                    TotalValue -= 10.00;
                }
                InvokePropertyChanged("Tens");
            }
        }
        /// <summary>
        /// Twenty Dollar bill count variable
        /// </summary>
        private int twenty = 0;
        /// <summary>
        /// The amount of Twenty Dollar Bills in the Cash Register
        /// </summary>
        public int Twenties
        {
            get => twenty;
            set
            {
                if (twenty == value || value < 0) return;
                var quantity = value - twenty;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantity);
                    twenty++;
                    TotalValue += 20.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                    twenty--;
                    TotalValue -= 20.00;
                }
                InvokePropertyChanged("Twenties");
            }
        }
        /// <summary>
        /// Fifty Dollar Bill count variable
        /// </summary>
        private int fifty = 0;
        /// <summary>
        /// The amount of Fifty Dollar Bills in the Cash Register
        /// </summary>
        public int Fifties
        {
            get => fifty;
            set
            {
                if (fifty == value || value < 0) return;
                var quantity = value - fifty;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Fifty, quantity);
                    fifty++;
                    TotalValue += 50.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                    fifty--;
                    TotalValue -= 50.00;
                }
                InvokePropertyChanged("Fifites");
            }
        }
        /// <summary>
        /// Hundred Dollar Bill count variable
        /// </summary>
        private int hundred = 0;
        /// <summary>
        /// The amount of Hundred Dollar Bills in the Cash Register
        /// </summary>
        public int Hundreds
        {
            get => hundred;
            set
            {
                if (hundred == value || value < 0) return;
                var quantity = value - hundred;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantity);
                    hundred++;
                    TotalValue += 100.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                    hundred--;
                    TotalValue -= 100.00;
                }
                InvokePropertyChanged("Hundreds");
            }
        }
        /// <summary>
        /// Boolean getter that determines if the right amount as been paid
        /// </summary>
        public bool ReadyToPay
        {
            get { return TotalValue >= orderTotal; }
        }

        /// <summary>
        /// Helper method for triggering PropertyChanged events
        /// </summary>
        /// <param name="denomination">The denomination property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ReadyToPay"));
        }

    }
}
