namespace Weather.BusinessLogic.Models
{
    public class WeatherModel
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Description { get; set; }
        public string TemperatureMin { get; set; }
        public string TemperatureMax { get; set; }
        public DateTime Date { get; set; }
    }
}
