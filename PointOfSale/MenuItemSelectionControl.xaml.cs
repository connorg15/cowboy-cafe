﻿/* MenuItemSelectionControl.xaml.cs
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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            //Click Events for Entrees
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddPecoPulledPorkButton.Click += OnAddPecoPulledPorkButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;

            //Click Events for Sides
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;

            //Click Events for Drinks
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
        }
        /// <summary>
        /// Adds Cowpoke Chili to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new CowpokeChili());
            }
        }
        /// <summary>
        /// Adds Trail Burger to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddTrailBurgerClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
            }
        }
        /// <summary>
        /// Adds Pecos Pulled Pork to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddPecoPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
            }
        }
        /// <summary>
        /// Adds Dakota Double Burger to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
            }
        }
        /// <summary>
        /// Adds Texas Triple Burger to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
            }
        }
        /// <summary>
        /// Adds Angry Chicken to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new AngryChicken());
            };
        }
        /// <summary>
        /// Adds Rustlers Ribs to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }
        /// <summary>
        /// Adds Baked Beans to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }
        /// <summary>
        /// Adds Chili Cheese Fries to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }
        /// <summary>
        /// Adds Corn Dodgers to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }
        /// <summary>
        /// Adds Pan De Campo to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }
        /// <summary>
        /// Adds Cowboy Coffee to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }
        /// <summary>
        /// Adds Jerked Soda to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }
        /// <summary>
        /// Adds Texas Tea to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }
        /// <summary>
        /// Adds Water to the display when clicked
        /// </summary>
        /// <param name="sender">When the button is clicked</param>
        /// <param name="e">The data that is gathered when clicked</param>
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }
    }
}
