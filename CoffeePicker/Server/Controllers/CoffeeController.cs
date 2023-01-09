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
            new(6, "Doppio", "A double shot of espresso, the doppio is perfect for putting extra pep in your step.", new string[] { "1oz Espresso" }),
            new(7, "Cortado", "Like yin and yang, a cortado is the perfect balance of espresso and warm steamed milk. The milk is used to cut back on the espresso’s acidity.", new string[] { "1oz Espresso", "1oz Steamed Milk" }),
            new(8, "Red Eye", "Named after those pesky midnight flights, a red eye can cure any tiresome morning. A full cup of hot coffee with an espresso shot mixed in, this will definitely get your heart racing.", new string[] { "Coffee", "Espresso" }),
            new(9, "Galão", "Originating in Portugal, this hot coffee drink is closely related to the latte and cappuccino. Only difference is it contains about twice as much foamed milk, making it a lighter drink compared to the other two.", new string[] { "Espresso", "Foamed milk" }),
            new(10, "Lungo", "A lungo is a long-pull espresso. The longer the pull, the more caffeine there is and the more ounces you can enjoy.", new string[] { "Long pulled espresso" }),
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
