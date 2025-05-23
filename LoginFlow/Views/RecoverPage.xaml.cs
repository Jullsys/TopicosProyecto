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
                await DisplayAlert("Error", "Por favor ingresa un correo electrónico.", "OK");
                return;
            }

            await DisplayAlert("Recuperación", "Se ha enviado un correo con instrucciones para recuperar tu contraseña.", "OK");

            await Shell.Current.GoToAsync("..");

        }
    }
}
