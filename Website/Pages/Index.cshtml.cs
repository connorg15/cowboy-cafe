using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The items to be displayed on the menu
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }
        /// <summary>
        /// The filtered categories
        /// </summary>
        [BindProperty(SupportsGet =true)]
        public string [] Categories { get; set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
       // [BindProperty (SupportsGet =true)]
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; } = "";
        /// <summary>
        /// The minimum Price
        /// </summary>
        [BindProperty(SupportsGet =true)]
        public double? PriceMin { get; set; }
        /// <summary>
        /// The maximum Price
        /// </summary>
        [BindProperty(SupportsGet =true)]
        public double? PriceMax { get; set; }
        /// <summary>
        /// The minimum Calories
        /// </summary>
        [BindProperty(SupportsGet =true)]
        public uint? CalorieMin { get; set; }
        /// <summary>
        /// The maximum Calories
        /// </summary>
        [BindProperty(SupportsGet =true)]
        public uint? CalorieMax { get; set; }

        /// <summary>
        /// Gets the search results for the display on the page
        /// </summary>
        public void OnGet(double? priceMin, double? priceMax, uint? calorieMin, uint? calorieMax)
        {
            Items = Menu.All;

            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];

            PriceMin = priceMin;
            PriceMax = priceMax;
            CalorieMin = calorieMin;
            CalorieMax = calorieMax;

            Items = Menu.Search(Items, SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CalorieMin, CalorieMax);
        }

    }
}
