namespace LoginScreen
{
    public partial class MainPage : ContentPage
    {
        bool isSidebarOpen = false;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ThemeIcon.Text = Application.Current.UserAppTheme == AppTheme.Dark
                ? "\uE51C"
                : "\uE518";
        }

        private async void OnMenuTapped(object sender, EventArgs e)
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

        private void OnThemeToggle(object sender, EventArgs e)
        {
            if (Application.Current.UserAppTheme == AppTheme.Dark)
            {
                Application.Current.UserAppTheme = AppTheme.Light;
                ThemeIcon.Text = "\uE518"; // light_mode
            }
            else
            {
                Application.Current.UserAppTheme = AppTheme.Dark;
                ThemeIcon.Text = "\uE51C"; // dark_mode
            }
        }
    }
}
