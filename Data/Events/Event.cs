﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tera.Game;

namespace Data.Events
{
    public abstract class Event
    {
        public Dictionary<EntityId, DateTime> NextChecks { get; set; }
        public bool InGame { get; set; }
        public Event(bool inGame)
        {
            NextChecks = new Dictionary<EntityId, DateTime>();
            InGame = inGame;
        }
    }
}
