using System;
using System.Collections.Generic;
using System.Text;

namespace ZorkBuilder.Data
{
    public class World
    {
        public string StartingLocation { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
