using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Player : BaseNorificationClass
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
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Class 
        {
            get { return _class; } 
            set 
            {
                _class = value;
                OnPropertyChanged(nameof(Class)); 
            }
        }
        public int CurrentHP 
        { 
            get { return _currentHP; } 
            set
            {
                _currentHP = value;
                OnPropertyChanged(nameof(CurrentHP));
            }
        }
        public int Gold 
        { 
            get { return _gold; } 
            set 
            {
                OnPropertyChanged(nameof(Gold));
            }
        }
        public int EXP 
        {
            get { return _eXP; }
            set 
            { 
                _eXP = value;
                OnPropertyChanged(nameof(EXP));
            } 
        }
        public int Level 
        { 
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }

        public ObservableCollection<GameItem> Inventory { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
        }

    }
}
