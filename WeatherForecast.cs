namespace InjecaoDependencia
{
    public class WeatherForecast : IProcesso
    {
        public Guid Id { get; set; }

        public WeatherForecast()
        {
            Id = Guid.NewGuid();
        }
    }
}