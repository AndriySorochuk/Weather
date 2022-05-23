using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.BusinessLogic.Models;
using Weather.Database.Entities;

namespace Weather.BusinessLogic.Extensions
{
    public static class WeatherExtensions
    {
        public static WeatherModel Map(this WeatherEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return new WeatherModel
            {
                Id = entity.Id,
                Date = entity.Date,
                LocationId = entity.LocationId,
                Description = entity.Description,
                TemperatureMax = entity.TemperatureMax,
                TemperatureMin = entity.TemperatureMin
            };
        }
    }
}
