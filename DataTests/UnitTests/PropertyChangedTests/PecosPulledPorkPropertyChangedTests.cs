/* PecosPulledPorkPropertyChangedTests.cs
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
    public class PecosPulledPorkPropertyChangedTests
    {
        // Test 1: Pecos Pulled Pork should implement the INotifyPropertyChanged Interface
        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var pecos = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pecos);
        }

        // Test 2: Changing the "Bread" property should invoke the PropertyChanged for "Bread"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var pecos = new PecosPulledPork();
            Assert.PropertyChanged(pecos, "Bread", () =>
            {
                pecos.Bread = false;
            });
        }

        // Test 3: Changing the "Bread" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecos = new PecosPulledPork();
            Assert.PropertyChanged(pecos, "SpecialInstructions", () =>
            {
                pecos.Bread = false;
            });
        }

        // Test 4: Changing the "Pickle" property should invoke the PropertyChanged for "Pickle"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var pecos = new PecosPulledPork();
            Assert.PropertyChanged(pecos, "Pickle", () =>
            {
                pecos.Pickle = false;
            });
        }
        // Test 5: Changing the "Pickle" property should invoke the PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var pecos = new PecosPulledPork();
            Assert.PropertyChanged(pecos, "SpecialInstructions", () =>
            {
                pecos.Pickle = false;
            });
        }
    }
}
