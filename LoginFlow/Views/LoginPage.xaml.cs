using LoginFlow.Datos;
using LoginFlow.Modelos;

namespace LoginFlow.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
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
            var usuario = await App.UsuarioRepo.ValidarCredencialesAsync(
                Username.Text?.Trim(),
                Password.Text?.Trim()
            );

            if (usuario != null)
            {
                Preferences.Set("UsuarioActual", usuario.NombreUsuario);
                await SecureStorage.SetAsync("hasAuth", "true");
                await Shell.Current.GoToAsync("///home");
            }
            else
            {
                Preferences.Remove("UsuarioActual");
                await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "Intentar de nuevo");
            }
        }
    }
}
