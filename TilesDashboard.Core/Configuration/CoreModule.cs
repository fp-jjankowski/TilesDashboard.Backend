﻿using Autofac;
using TilesDashboard.Core.Domain.Services;
using TilesDashboard.Core.Storage;

namespace TilesDashboard.WebApi.Configuration
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TileContext>().As<ITileContext>();
            builder.RegisterType<TileService>().As<ITileService>();
            builder.RegisterType<WeatherService>().As<IWeatherServices>();
            builder.RegisterType<MetricService>().As<IMetricService>();
        }
    }
}