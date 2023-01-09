using CoffeePicker.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeePicker.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {

        //private List<Coffee> Coffees = new List<Coffee>();

        private List<Coffee> Coffees = new()
        {
            new(1,"Black","Black coffee is as simple as it gets with ground coffee beans steeped in hot water, served warm. And if you want to sound fancy, you can call black coffee by its proper name: cafe noir.", new string[]{ "Coffee" }),
            new(2,"Latte","As the most popular coffee drink out there, the latte is comprised of a shot of espresso and steamed milk with just a touch of foam. It can be ordered plain or with a flavor shot of anything from vanilla to pumpkin spice.", new string[]{ "Espresso","Steamed Milk" }),
            new(3,"Cappuccino","Cappuccino is a latte made with more foam than steamed milk, often with a sprinkle of cocoa powder or cinnamon on top. Sometimes you can find variations that use cream instead of milk or ones that throw in flavor shot, as well.", new string[]{ "Espresso","Steamed Milk","Foam" }),
            new(4,"Americano","With a similar flavor to black coffee, the americano consists of an espresso shot diluted in hot water.", new string[]{ "Coffee","Hot Water" }),
            new(5,"Espresso","An espresso shot can be served solo or used as the foundation of most coffee drinks, like lattes and macchiatos.", new string[]{ "1oz Espresso" }),
        };

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var coffee = Coffees.Find(o => o.Id == id);

            if (coffee is not null)
            {
                return Ok(coffee);
            }

            return NotFound("Coffee not found");

        }

        [HttpGet("List")]
        public ActionResult List()
        {
            return Ok(Coffees);
        }


    }
}
