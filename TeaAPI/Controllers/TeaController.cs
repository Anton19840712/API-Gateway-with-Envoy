namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeeController : ControllerBase
    {
        private static readonly string[] Coffees = new[]
        {
            "Green", "Peppermint", "Earl Grey", "English Breakfast", "Camomile"
        };

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            return Ok(Teas[rng.Next(Teas.Length)]);
        }
    }
}