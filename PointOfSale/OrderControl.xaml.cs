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
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsClicked;
            AddPecoPulledPorkButton.Click += OnAddPecoPulledPorkButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
        }
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }
        void OnAddTrailBurgerClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }
        void OnAddPecoPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }
        void OnAddRustlersRibsClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }
    }
}
