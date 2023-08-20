using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Maui_Counter.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        private int _counter;
        public MainViewModel()
        {
            _counter = 0;
            presentNum = 0.ToString();
        }

        [ObservableProperty]
        private string presentNum = string.Empty;

        [RelayCommand]
        public void Plus()
        {
            _counter++;
            PresentNum = _counter.ToString();
        }

        [RelayCommand]
        public void Minus() 
        {
            _counter--;
            PresentNum = _counter.ToString();
        }

        [RelayCommand]
        public void Reset()
        {
            _counter = 0;
            PresentNum = 0.ToString();
        }
    }
}
