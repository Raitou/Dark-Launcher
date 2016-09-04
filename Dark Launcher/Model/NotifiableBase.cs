﻿using System.ComponentModel;

namespace Dark_Launcher.Model
{
    public abstract class NotifiableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetAndNotify<T>(ref T field, T value, string propertyName)
        {
            if (object.ReferenceEquals(field, value))
                return;

            field = value;

            OnPropertyChanged(propertyName);
        }
    }
}
