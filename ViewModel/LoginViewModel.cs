using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace LoginScreen.ViewModel
{
     public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string pin = string.Empty;


        [RelayCommand]
        private void KeyPressed(string key)
        {
            if (key == "Backspace")
            {
                if (Pin.Length > 0)
                    Pin = Pin[..^1];
            }
            else if (Pin.Length < 4)   // PIN limit
            {
                Pin += key;
            }
        }

        [RelayCommand]
        private void Login()
        {
            Console.WriteLine($"PIN entered: {Pin}");
        }

    }
}
