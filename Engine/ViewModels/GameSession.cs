using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession : BaseNorificationClass
    {
        private Location _currentLocation;
        public Player CurrentPlayer { get; set; }
        public World CurrentWorld { get; set; }
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationNorth));
                OnPropertyChanged(nameof(HasLocationSouth));
                OnPropertyChanged(nameof(HasLocationEast));
                OnPropertyChanged(nameof(HasLocationWest));
            }
        }

        public bool HasLocationNorth
        {
            get {
                return CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
                }
        }

        public bool HasLocationSouth
        {
            get
            {
                return CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }

        public bool HasLocationEast
        {
            get
            {
                return CurrentWorld.locationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationWest
        {
            get
            {
                return CurrentWorld.locationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }


        public GameSession()
        {
            CurrentPlayer = new Player() 
                {
                    Name = "Jo",
                    Gold = 10,
                    Class = "Fighter",
                    CurrentHP = 10,
                    EXP = 0,
                    Level = 1,
                };

            CurrentWorld = WorldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.locationAt(0, -1);
        }

        public void MoveNorth()
        {
            if (HasLocationNorth)
            {
                CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
        }
        public void MoveSouth()
        {
            if (HasLocationSouth)
            {
                CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            }
        }
        public void MoveEast()
        {
            if (HasLocationEast)
            {
                CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            }
        }
        public void MoveWest()
        {
            if (HasLocationWest)
            {
                CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }

    }
}
