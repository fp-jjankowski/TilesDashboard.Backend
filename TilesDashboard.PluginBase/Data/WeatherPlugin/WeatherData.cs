﻿namespace TilesDashboard.PluginBase.Data.WeatherPlugin
{
    public class WeatherData : Result
    {
        public WeatherData(decimal temperature, decimal huminidy, Status status)
            : base(status)
        {
            Temperature = temperature;
            Huminidy = huminidy;
        }

        public WeatherData(decimal temperature, Status status)
            : base(status)
        {
            Temperature = temperature;
        }

        public WeatherData(Status status)
          : base(status)
        {
        }

        public static WeatherData Error(string errorMessage) => new WeatherData(Status.Error).WithErrorMessage(errorMessage) as WeatherData;

        public static WeatherData NoUpdate => new WeatherData(Status.NoUpdate);

        public decimal Temperature { get; private set; }

        public decimal? Huminidy { get; private set; }

        public override string ToString()
        {
            return $"Temperature: {Temperature} - Huminidy - {Huminidy} - Status: {Status}";
        }
    }
}
