using System;
using System.Collections.Generic;
using System.Text;

namespace ZorkBuilder.Data
{
    class World
    {
        public string StartingLocation { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
