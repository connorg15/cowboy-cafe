/* MenuTests.cs
 * Author: Connor Garcia
 */
using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTests
    {
        //Sides should contain chili cheese fries, baked beans, corn dodgers, and pan de campo
        [Fact]
        public void MenuSidesShouldContainExpectedItems()
        {
            var sides = new List<IOrderItem>(Menu.Sides);
            sides.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                sides,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
            );
        }

        //Entrees should contain Angry Chicken, Cowpoke Chili, Dakota Double Burger, 
        //Pecos Pulled Pork, Rustler's Ribs, Texas Triple Burger, and Trailburger
        [Fact]
        public void MenuEntreesShouldContainExpectedItems()
        {
            var entrees = new List<IOrderItem>(Menu.Entrees);
            entrees.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
            );
        }
        //Drinks should contain Cowboy Coffee, Jerked Soda, Texas Tea, Water
        [Fact]
        public void MenuDrinksShouldContainExpectedItems()
        {
            var drinks = new List<IOrderItem>(Menu.Drinks);
            drinks.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                drinks,
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
            );
        }
        //All should contain an instance of every item
        //[Fact]
        //public void MenuAllShouldContainExpectedItems()
        //{
        //    var items = new List<IOrderItem>(Menu.All);
        //    items.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
        //    Assert.Collection(
        //        items,
        //        (ac) => { Assert.IsType<AngryChicken>(ac); },
        //        (cc) => { Assert.IsType<CowpokeChili>(cc); },
        //        (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
        //        (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
        //        (rr) => { Assert.IsType<RustlersRibs>(rr); },
        //        (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
        //        (tb) => { Assert.IsType<TrailBurger>(tb); },
        //        (cbc) => { Assert.IsType<CowboyCoffee>(cbc); },
        //        (js) => { Assert.IsType<JerkedSoda>(js); },
        //        (tt) => { Assert.IsType<TexasTea>(tt); },
        //        (w) => { Assert.IsType<Water>(w); },
        //        (bb) => { Assert.IsType<BakedBeans>(bb); },
        //        (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
        //        (cd) => { Assert.IsType<CornDodgers>(cd); },
        //        (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
        //    );
        //}
    }
}
