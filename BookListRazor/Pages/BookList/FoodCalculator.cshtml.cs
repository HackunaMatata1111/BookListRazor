using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using BookListRazor.Model;

namespace BookListRazor.Pages
{
    public class FoodCalculatorModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public FoodCalculatorModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //[BindProperty]
        //public FoodTravelCalculatorCO FoodTravelCalculatorCO { get; set; }


        #region Constant

        private const double cheeseSandwich = 2.73;
        private const double eggCheeseSandwich = 3.62;
        private const double chickenSoup = 1.36;
        private const double eggRice = 1.05;
        private const double chickenCheeseSandwich = 3.99;
        private const double chickenSandwich = 1.54;
        private const double chickenSteak = 2.03;
        private const double vegRice = 0.26;
        private const double milk = 0.72;

        #endregion

        public void OnGet()
        {
        }

        public IActionResult OnPostSellProduct()
        {
            if (ModelState.IsValid)
            {
                double sum = 0;
                List<double> sumTotal = new List<double>();

                string item1 = Request.Form["cheesesandwich"];
                if(!string.IsNullOrEmpty(item1))
                {
                    //sum = sum + (Convert.ToDouble(item1) * cheeseSandwich);
                    sumTotal.Add(Convert.ToDouble(item1) * cheeseSandwich);
                }

                string item2 = Request.Form["eggcheesesandwich"];
                if (!string.IsNullOrEmpty(item2))
                {
                    sumTotal.Add(Convert.ToDouble(item2) * eggCheeseSandwich);
                }

                string item3 = Request.Form["chickensoup"];
                if (!string.IsNullOrEmpty(item3))
                {
                    sumTotal.Add(Convert.ToDouble(item3) * chickenSoup);
                }

                string item4 = Request.Form["eggRice"];
                if (!string.IsNullOrEmpty(item4))
                {
                    sumTotal.Add(Convert.ToDouble(item4) * eggRice);
                }

                string item5 = Request.Form["chickencheesesandwich"];
                if (!string.IsNullOrEmpty(item5))
                {
                    sumTotal.Add(Convert.ToDouble(item5) * chickenCheeseSandwich);
                }

                string item6 = Request.Form["chickensandwich"];
                if (!string.IsNullOrEmpty(item6))
                {
                    sumTotal.Add(Convert.ToDouble(item6) * chickenSandwich);
                }

                string item7 = Request.Form["chickensteak"];
                if (!string.IsNullOrEmpty(item7))
                {
                    sumTotal.Add(Convert.ToDouble(item7) * chickenSteak);
                }

                string item8 = Request.Form["vegrice"];
                if (!string.IsNullOrEmpty(item8))
                {
                    sumTotal.Add(Convert.ToDouble(item8) * vegRice);
                }

                string item9 = Request.Form["milk"];
                if (!string.IsNullOrEmpty(item9))
                {
                    sumTotal.Add(Convert.ToDouble(item9) * milk);
                }

                IEnumerable<double> returnCollection = sumTotal.Select(m => m);
                sum = Math.Round((returnCollection.Sum(m => Convert.ToDouble(m))),2);
                if (sum > 0)
                {
                    TempData["SumResult"] = sum.ToString();
                }

                FoodTravelCalculatorCO foodTravelCalculatorCO = new FoodTravelCalculatorCO();
                foodTravelCalculatorCO.Co2Footprint = Convert.ToDecimal(sum);
                foodTravelCalculatorCO.FoodIndicator = "F";
                _db.FoodTravelCalculatorCO.Add(foodTravelCalculatorCO);
                _db.SaveChanges();

            }
            return Page();

        }
    }
}
