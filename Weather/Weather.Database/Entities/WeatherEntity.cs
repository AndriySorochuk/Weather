namespace Weather.Database.Entities
{
    public class WeatherEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string TemperatureMin { get; set; }
        public string TemperatureMax { get; set; }
        public DateTime Date { get; set; }
        public DateTime Created { get; set; }

        public int LocationId { get; set; }

        public virtual LocationEntity Location { get; set; }
    }
}
