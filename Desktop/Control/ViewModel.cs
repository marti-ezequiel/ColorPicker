using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Desktop
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChange([CallerMemberName] String propertyName = "")
        {
            var onPropertyChange = PropertyChanged;

            if (onPropertyChange != null)
            {
                onPropertyChange(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
