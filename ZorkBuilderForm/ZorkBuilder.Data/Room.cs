﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZorkBuilder.Data
{
    class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Neighbor Neighbors { get; set; }
    }
}