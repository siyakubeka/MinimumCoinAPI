using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimumCoinAPI.models;
namespace MinimumCoinAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        
        Calculation calculation = new Calculation();
        [HttpGet]
        public int Get()
        {
            //Get the Different denominations of coins
            int[] coins = { 25, 10, 5 };

            //Get the number of coins
            int m = coins.Length;

            //The amount that need to be paid out
            int Y = 30;

            //Send the information above to the Calculation model and return the minimum number of coins needed to make change for a given amount of Y
            return calculation.countMinCoin(coins, m, Y);
        }

    }
}
