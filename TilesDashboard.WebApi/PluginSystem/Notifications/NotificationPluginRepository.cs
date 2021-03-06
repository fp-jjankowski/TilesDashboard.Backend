﻿using System;
using System.Collections.Generic;
using System.Linq;
using TilesDashboard.Core.Type;
using TilesDashboard.PluginBase.Notification;

namespace TilesDashboard.WebApi.PluginSystem.Notifications
{
    public class NotificationPluginRepository : INotificationPluginRepository
    {
        private readonly INotificationPluginContext _notificationPluginContext;

        public NotificationPluginRepository(INotificationPluginContext notificationPluginContext)
        {
            _notificationPluginContext = notificationPluginContext ?? throw new ArgumentNullException(nameof(notificationPluginContext));
        }

        public IList<INotificationPlugin> FindNotificationPlugins(TileId tileId)
        {
            return _notificationPluginContext.NotificationPlugins.Where(x => x.TileId == tileId).ToList();
        }
    }
}
