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
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddPecoPulledPorkButton.Click += OnAddPecoPulledPorkButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
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
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }
        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }
        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
    }
}
