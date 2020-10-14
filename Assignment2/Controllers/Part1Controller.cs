using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class Part1Controller : ApiController
    {
        /// <summary>
        /// Total calories of order
        /// </summary>
        /// <example> api/part1/menu/1/1/1/1 </example>
        /// <param name="burger">First choice</param>
        /// <param name="drink">Second choice</param>
        /// <param name="side">Third choice</param>
        /// <param name="dessert">Fourth choice</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/part1/Menu/{burger}/{drink}/{side}/{dessert}")]

        public string GetMenu(int burger, int drink, int side, int dessert)
        {
            
            int[] pickBurger = { 461, 431, 420, 0 };
            int[] pickDrink = { 130, 160, 118, 0 };
            int[] pickSide = { 100, 57, 70, 0 };
            int[] pickDessert = { 167, 266, 75, 0 };
            int totalCalorie = pickBurger[burger - 1] + pickDrink[drink - 1] + pickSide[side - 1] + pickDessert[dessert - 1];

            ///string myTotal = $"Your total calorie count is:  + {totalCalorie}";

            return "Your total calorie is " + totalCalorie;
        }
    }
}
