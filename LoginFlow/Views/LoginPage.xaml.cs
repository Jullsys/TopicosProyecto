namespace LoginFlow.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    protected override bool OnBackButtonPressed()
    {
        Application.Current.Quit();
        return true;
    }

    private async void TapGestureRecognizerReg_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("Register");
    }

    private async void TapGestureRecognizerPwd_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("Recover");
    }

    private async void LoginButton_Clicked(object sender, EventArgs e)
    {
        if (IsCredentialCorrect(Username.Text, Password.Text))
        {
            Preferences.Set("UsuarioActual", Username.Text.Trim());
            await SecureStorage.SetAsync("hasAuth", "true");
            await Shell.Current.GoToAsync("///home");
        }
        else
        {
            Preferences.Remove("UsuarioActual");
            await DisplayAlert("Login failed", "Username or password if invalid", "Try again");
        }
    }

    bool IsCredentialCorrect(string username, string password)
    {
        string storedUsername = Preferences.Get("usuario_nombre", string.Empty);
        string storedPassword = Preferences.Get("usuario_password", string.Empty);

        return username == storedUsername && password == storedPassword;
    }
}
