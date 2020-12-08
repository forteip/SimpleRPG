using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Engine
{
    public class BaseNorificationClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
