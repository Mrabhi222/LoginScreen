using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LoginScreen.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {
        // PIN
        [ObservableProperty]
        private string pin = string.Empty;

        // VISIBILITY
        [ObservableProperty]
        private bool isNumpadVisible = true;

        [ObservableProperty]
        private bool isGifVisible = false;

        [ObservableProperty]
        private bool isAccessCard = false;

        // LOGIN METHOD COMMANDS
        [RelayCommand]
        private void SelectUserCode()
        {
            IsNumpadVisible = true;
            IsAccessCard = false;
            IsGifVisible = false;
        }

        [RelayCommand]
        private void SelectFingerprint()
        {
            IsNumpadVisible = false;
            IsAccessCard = false;
            IsGifVisible = true;
        }

        [RelayCommand]
        private void SelectAccessCard()
        {
            IsNumpadVisible = false;
            IsGifVisible = false;
            IsAccessCard = true;
        }

        // KEYPAD
        [RelayCommand]
        private void KeyPressed(string key)
        {
            if (key == "Backspace")
            {
                if (Pin.Length > 0)
                    Pin = Pin[..^1];
            }
            else if (Pin.Length < 4)
            {
                Pin += key;
            }
        }

        // LOGIN
        [RelayCommand]
        private void Login()
        {
            Console.WriteLine($"PIN entered: {Pin}");
        }
    }
}
