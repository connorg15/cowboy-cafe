/* DakotaDoubleBurgerPropertyChangedTests.cs
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
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        // Test 1: Dakota Double Burger should implement the INotifyPropertyChanged Interface
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakota);
        }

        // Test 2: Changing the "Bun" property should invoke the PropertyChanged for "Bun"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Bun", () =>
            {
                dakota.Bun = false;
            });
        }
        // Test 3: Changing the "Bun" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Bun = false;
            });
        }
        // Test 4: Changing the "Ketchup" property should invoke the PropertyChanged for "Ketchup"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Ketchup", () =>
            {
                dakota.Ketchup = false;
            });
        }
        // Test 5: Changing the "Ketchup" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Ketchup = false;
            });
        }
        // Test 6: Changing the "Mustard" property should invoke the PropertyChanged for "Mustard"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mustard", () =>
            {
                dakota.Mustard = false;
            });
        }
        // Test 7: Changing the "Mustard" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Mustard = false;
            });
        }
        // Test 8: Changing the "Pickle" property should invoke the PropertyChanged for "Pikckle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Pickle", () =>
            {
                dakota.Pickle = false;
            });
        }
        // Test 9: Changing the "Pickle" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Pickle = false;
            });
        }
        // Test 10: Changing the "Cheese" property should invoke the PropertyChanged for "Cheese"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Cheese", () =>
            {
                dakota.Cheese = false;
            });
        }
        // Test 11: Changing the "Cheese" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Cheese = false;
            });
        }
        // Test 12: Changing the "Tomato" property should invoke the PropertyChanged for "Tomato"
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Tomato", () =>
            {
                dakota.Tomato = false;
            });
        }
        // Test 13: Changing the "Tomato" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingTomaotShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Tomato = false;
            });
        }
        // Test 14: Changing the "Lettuce" property should invoke the PropertyChanged for "Lettuce"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Lettuce", () =>
            {
                dakota.Lettuce = false;
            });
        }
        // Test 15: Changing the "Lettuce" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Lettuce = false;
            });
        }
        // Test 16: Changing the "Mayo" property should invoke the PropertyChanged for "Mayo"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mayo", () =>
            {
                dakota.Mayo = false;
            });
        }
        // Test 17: Changing the "Mayo" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Mayo = false;
            });
        }
    }
}
