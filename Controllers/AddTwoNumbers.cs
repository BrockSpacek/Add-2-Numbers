
using Microsoft.AspNetCore.Mvc;

namespace Add_2_Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbers : ControllerBase
    {
        [HttpPost]
        [Route("Adding")]

        public string addTwoNumbers(int num1, int num2)
        {
            return $"{num1} + {num2} = {num1 + num2}.";
    }
    }
}