using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IServiceProvider _provider;

        public WeatherForecastController(IServiceProvider provider)
        {
            _provider = provider;
        }


        [HttpGet]

       public IActionResult Provider()
        {
            return Ok(_provider.GetRequiredService<IProcesso>());
        }
    }
}