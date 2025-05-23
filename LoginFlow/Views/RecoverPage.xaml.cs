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

            await DisplayAlert("Recuperaci�n", "Se ha enviado un correo con instrucciones para recuperar tu contrase�a.", "OK");

            await Shell.Current.GoToAsync("..");

        }
    }
}
