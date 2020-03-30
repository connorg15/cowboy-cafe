/* RustlersRibsPropertyChangedTests.cs
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
    public class RustlersRibsPropertyChangedTests
    {
        // Test 1: Rustlers Ribs should implement the INotifyPropertyChanged Interface
        [Fact]
        public void RustlersRibsShouldImplementINotifyPropertyChanged()
        {
            var ribs = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ribs);
        }
    }
}
