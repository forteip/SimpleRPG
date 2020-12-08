using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, -1, "Home", 
                "This is your home", 
                @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\home.jpg");

            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them.",
                @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\Farm_field.jpg");

            newWorld.AddLocation(-1, -1, "Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\Farmhouse.jpg");

            newWorld.AddLocation(-1, 0, "Trading Shop",
                "The shop of Susan, the trader.",
                @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\Trade_shop.jpg");

            newWorld.AddLocation(0, 0, "Town square",
                "This is the town square, you rest under a large tree.",
                @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\Town_center.jpg");

            newWorld.AddLocation(1, 0, "Town Gate",
                "There is a gate here, protecting the town from giant spiders.",
                @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\Town_gate.jpg");

            newWorld.AddLocation(2, 0, "Spider Forest",
                "The trees in this forest are covered with spider webs.",
                @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\Forest.jpg");

            newWorld.AddLocation(0, 1, "Herbalist's hut",
                "You see a small hut, with plants drying from the roof.",
                @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\Herbalist_hut.jpg");

            newWorld.AddLocation(0, 2, "Herbalist's garden",
                "There are many plants here, with snakes hiding behind them.",
                @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\Herb_Garden.jpg");
            return newWorld;
        }
    }
}
