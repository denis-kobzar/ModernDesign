using System;
using ModernDesign.Core;

namespace ModernDesign.MVVM.ViewModel
{
    internal class MainViewModel : Observable
    {
        /*public HomeViewModel */

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value; 
                OnPropertyChanged();
            }
        }

        public MainViewModel() { }


    }
}
