using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private string _class;
        private int _currentHP;
        private int _gold;
        private int _level;
        private int _eXP;
        public string Name 
        {
            get { return _name; } 
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Class 
        {
            get { return _class; } 
            set 
            {
                _class = value;
                OnPropertyChanged("Class"); 
            }
        }
        public int CurrentHP 
        { 
            get { return _currentHP; } 
            set
            {
                _currentHP = value;
                OnPropertyChanged("CurrentHP");
            }
        }
        public int Gold 
        { 
            get { return _gold; } 
            set 
            {
                OnPropertyChanged("Gold");
            }
        }
        public int EXP 
        {
            get { return _eXP; }
            set 
            { 
                _eXP = value;
                OnPropertyChanged("EXP");
            } 
        }
        public int Level 
        { 
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged("Level");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
