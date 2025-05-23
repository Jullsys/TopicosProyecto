using LoginFlow.Modelos;
using LoginFlow.Datos;

namespace LoginFlow.Views;

public partial class ContactoPage : ContentPage
{
    private ContactoDatabase db = new ContactoDatabase();
    private Contacto contacto;

    public ContactoPage()
    {
        InitializeComponent();
        contacto = new Contacto();
    }

    public ContactoPage(Contacto c)
    {
        InitializeComponent();
        contacto = c;

        nombreEntry.Text = contacto.Nombre;
        telefonoEntry.Text = contacto.Telefono;
        correoEntry.Text = contacto.CorreoElectronico;

        // Mostrar botón de eliminar si el contacto ya existe
        if (contacto.Id != 0)
            eliminarBtn.IsVisible = true;
    }

    private async void OnGuardarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nombreEntry.Text) ||
            string.IsNullOrWhiteSpace(telefonoEntry.Text) ||
            string.IsNullOrWhiteSpace(correoEntry.Text))
        {
            await DisplayAlert("Campos requeridos", "Todos los campos son obligatorios.", "OK");
            return;
        }

        contacto.Nombre = nombreEntry.Text;
        contacto.Telefono = telefonoEntry.Text;
        contacto.CorreoElectronico = correoEntry.Text;

        await db.GuardarContactoAsync(contacto);
        await Navigation.PopAsync();
    }

    private async void OnEliminarClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("Confirmar", $"¿Eliminar a {contacto.Nombre}?", "Sí", "No");
        if (confirm)
        {
            await db.EliminarContactoAsync(contacto);
            await Navigation.PopAsync(); // Volver a la agenda
        }
    }
}
