using LoginScreen.ViewModel;
using System.Reflection.PortableExecutable;

namespace LoginScreen
{
    public partial class MainPage : ContentPage
    {
        bool isSidebarOpen = false;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
            //Header.MenuTapped += OnHeaderMenuTapped;
        }

        private async void OnHeaderMenuTapped(object? sender, EventArgs e)
        {
            if (!isSidebarOpen)
            {
                await SideBar.TranslateTo(0, 0, 250, Easing.CubicOut);
                isSidebarOpen = true;
            }
            else
            {
                await SideBar.TranslateTo(260, 0, 250, Easing.CubicIn);
                isSidebarOpen = false;
            }
        }
    }

}
