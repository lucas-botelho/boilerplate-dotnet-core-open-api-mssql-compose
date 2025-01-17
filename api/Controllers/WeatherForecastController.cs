using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet(Name = "GetTesteId")]
        public async Task<int>GetTesteId()
        {
            string connectionString = "Server=mssql;Database=MyDatabase;User Id=sa;Password=YourStrongPassword!";
            var results = new List<string>();

            //using (SqlConnection _con = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("SELECT * FROM Teste", _con);


            //    using (var reader = await command.ExecuteReaderAsync())
            //    {
            //        while (await reader.ReadAsync())
            //        {
            //            results.Add(reader.GetString(0)); // Assuming the column is of type string
            //        }
            //    }


            //    //using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
            //    //{


            //    //    _con.Open();
            //    //    var command = new SqlCommand(queryStatement, _con);
            //    //    var reader = command.ExecuteReaderAsync();
            //    //    _con.Close();

            //    //}
            //}

            return 1;
        }
    }
}
