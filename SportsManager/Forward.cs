﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class Forward : Player
    {
        

        public Forward(string name, int number, string shotDirect, string position, bool healthy,int rating)
        {
            this.Name = name;
            this.Number = number;
            this.ShotDirection = shotDirect;
            this.PlayerPosition = position;
            this.IsHealthy = healthy;
            this.Rating = rating;
        }

        

    }
}