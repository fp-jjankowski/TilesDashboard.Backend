﻿using System.Collections.Generic;
using TilesDashboard.Core.Type.Enums;

namespace TilesDashboard.Contract
{
    public class TileDataDto
    {
        public string Name { get; set; }

        public TileType Type { get; set; }

        public IList<object> Data { get; private set; } = new List<object>();
    }
}
