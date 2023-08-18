using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Simple_Counter.ViewModel
{
    public partial class MainViewModel:ObservableObject
    {
        public MainViewModel() { 
            Text = 0.ToString();
        }

        private int num = 0;

        [ObservableProperty]
        private string text;

        [RelayCommand]
        void Add()
        {
            // add our item
            num++;
            Text = num.ToString();
        }
    }
}
