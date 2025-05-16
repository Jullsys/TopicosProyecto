namespace LoginFlow.Views
{
    public partial class RecoverPage : ContentPage
    {
        public RecoverPage()
        {
            InitializeComponent();
        }

        private async void OnRecoveryClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text?.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                await DisplayAlert("Error", "Por favor ingresa un correo electr�nico.", "OK");
                return;
            }

            // Aqu� deber�as hacer la l�gica de recuperaci�n, como enviar un correo de recuperaci�n
            // Este es solo un ejemplo simulado
            await DisplayAlert("Recuperaci�n", "Se ha enviado un correo con instrucciones para recuperar tu contrase�a.", "OK");

            // Despu�s de mostrar el mensaje, puedes redirigir a la p�gina de inicio de sesi�n
            await Shell.Current.GoToAsync("login");
        }
    }
}
