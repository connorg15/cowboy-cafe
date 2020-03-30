/*  TexasTripleBurgerPropertyChangedTests.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.UnitTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        // Test 1: Texas Triple Burger should implement the INotifyPropertyChanged Interface
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var texas = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texas);
        }

        // Test 2: Changing the "Bun" property should invoke the PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Bun", () =>
            {
                texas.Bun = false;
            });
        }
        // Test 3: Changing the "Bun" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Bun = false;
            });
        }
        // Test 4: Changing the "Ketchup" property should invoke the PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Ketchup", () =>
            {
                texas.Ketchup = false;
            });
        }
        // Test 5: Changing the "Ketchup" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Ketchup = false;
            });
        }
        // Test 6: Changing the "Mustard" property should invoke the PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Mustard", () =>
            {
                texas.Mustard = false;
            });
        }
        // Test 7: Changing the "Mustard" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Mustard = false;
            });
        }
        // Test 8: Changing the "Pickle" property should invoke the PropertyChanged for "Pikckle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Pickle", () =>
            {
                texas.Pickle = false;
            });
        }
        // Test 9: Changing the "Pickle" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Pickle = false;
            });
        }
        // Test 10: Changing the "Cheese" property should invoke the PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Cheese", () =>
            {
                texas.Cheese = false;
            });
        }
        // Test 11: Changing the "Cheese" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Cheese = false;
            });
        }
        // Test 12: Changing the "Tomato" property should invoke the PropertyChanged for "Tomato"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Tomato", () =>
            {
                texas.Tomato = false;
            });
        }
        // Test 13: Changing the "Tomato" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingTomaotShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Tomato = false;
            });
        }
        // Test 14: Changing the "Lettuce" property should invoke the PropertyChanged for "Lettuce"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Lettuce", () =>
            {
                texas.Lettuce = false;
            });
        }
        // Test 15: Changing the "Lettuce" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Lettuce = false;
            });
        }
        // Test 16: Changing the "Mayo" property should invoke the PropertyChanged for "Mayo"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Mayo", () =>
            {
                texas.Mayo = false;
            });
        }
        // Test 17: Changing the "Mayo" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Mayo = false;
            });
        }
        // Test 18: Changing the "Bacon" property should invoke the PropertyChanged for "Bacon"
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Bacon", () =>
            {
                texas.Bacon = false;
            });
        }
        // Test 19: Changing the "Bacon" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Bacon = false;
            });
        }
        // Test 20: Changing the "Egg" property should invoke the PropertyChanged for "Egg"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "Egg", () =>
            {
                texas.Egg = false;
            });
        }
        // Test 21: Changing the "Mayo" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texas = new TexasTripleBurger();
            Assert.PropertyChanged(texas, "SpecialInstructions", () =>
            {
                texas.Egg = false;
            });
        }
    }
}
