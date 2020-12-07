using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Engine.Models;
using Engine.Factories;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
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
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationNorth");
                OnPropertyChanged("HasLocationSouth");
                OnPropertyChanged("HasLocationEast");
                OnPropertyChanged("HasLocationWest");
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
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jo";
            CurrentPlayer.Gold = 10;
            CurrentPlayer.Class = "Fighter";
            CurrentPlayer.CurrentHP = 10;
            CurrentPlayer.EXP = 0;
            CurrentPlayer.Level = 1;

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.locationAt(0, 0);
        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.locationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
