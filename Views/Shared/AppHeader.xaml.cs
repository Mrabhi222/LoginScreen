namespace LoginScreen.Views.Shared;

public partial class AppHeader : ContentView
{
    public event EventHandler? MenuTapped;

    public AppHeader()
    {
        InitializeComponent();
    }

    private void OnMenuTapped(object sender, EventArgs e)
    {
        MenuTapped?.Invoke(this, EventArgs.Empty);
    }

    private void OnThemeToggle(object sender, EventArgs e)
    {
        if (Application.Current.UserAppTheme == AppTheme.Dark)
        {
            Application.Current.UserAppTheme = AppTheme.Light;
            ThemeIcon.Text = "\uE518";
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
            ThemeIcon.Text = "\uE51C";
        }
    }
}
