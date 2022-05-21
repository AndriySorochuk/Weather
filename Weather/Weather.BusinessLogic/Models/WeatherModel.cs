namespace Weather.BusinessLogic.Models
{
    public class WeatherModel
    {
        public string LocationId { get; set; }
        public string LocationName { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
    }
}
