using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jo";
            CurrentPlayer.Gold = 10;
            CurrentPlayer.Class = "Fighter";
            CurrentPlayer.CurrentHP = 10;
            CurrentPlayer.EXP = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your House";
            CurrentLocation.ImageName = @"C:\Users\Spare Gaming\Desktop\Git\SimpleRPG\Engine\images\locations\home.jpg";

        }
    }
}
