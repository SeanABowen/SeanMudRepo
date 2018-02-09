﻿using System;

namespace Uxc.Mud.Persistence
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public Area CurrentArea { get; set; }
        public DateTime Dob { get; set; }
        public int Mana { get; set; }
    }
}
