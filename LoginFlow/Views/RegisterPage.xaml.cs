using LoginFlow.Modelos;
using LoginFlow.Datos;

namespace LoginFlow.Views;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        try
        {
            string nombre = NombreEntry.Text?.Trim();
            string correo = CorreoEntry.Text?.Trim();
            string password = PasswordEntry.Text?.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Error", "Todos los campos son obligatorios.", "OK");
                return;
            }

            var usuario = new Usuario
            {
                NombreUsuario = nombre,
                Correo = correo,
                Password = password
            };

            await App.UsuarioRepo.RegistrarUsuarioAsync(usuario);

            ResultadoLabel.Text = "Usuario registrado correctamente.";
            ResultadoLabel.TextColor = Colors.Green;
            ResultadoLabel.IsVisible = true;

            await Task.Delay(1500);
            await Shell.Current.GoToAsync(".."); // Volver al login
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Ha ocurrido un error: {ex.Message}", "OK");
        }
    }
}
