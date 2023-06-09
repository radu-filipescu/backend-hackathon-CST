﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Configs
{
    public class UserActionsTable
    {
        public Dictionary<int, int> actionIdScoreMappings = new Dictionary<int, int>();
        public UserActionsTable()
        {
            // commuting by bus
            actionIdScoreMappings.Add(1, 50);
            // commuting by bike
            actionIdScoreMappings.Add(2, 100);
            // plastic free 
            actionIdScoreMappings.Add(3, 50);
            // eco quiz
            actionIdScoreMappings.Add(4, 25);
            // planting
            actionIdScoreMappings.Add(5, 300);
            // donating
            actionIdScoreMappings.Add(6, 200);

            actionIdScoreMappings.Add(7, 1000);
            // solar panels
            actionIdScoreMappings.Add(8, 5000);
            // charging stations
            actionIdScoreMappings.Add(9, 2500);
            // green office
            actionIdScoreMappings.Add(10, 1500);
        }
    }
}
