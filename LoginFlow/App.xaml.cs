#if __ANDROID__
using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Platform;
using LoginFlow.Utils;
using LoginFlow.Datos;

namespace LoginFlow;

public partial class App : Application
{
    public static UsuarioDatabase UsuarioRepo { get; private set; }

    public App()
    {
        InitializeComponent();

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "usuarios.db");
        UsuarioRepo = new UsuarioDatabase(dbPath);

        bool esOscuro = ConfiguracionApp.ObtenerTema();
        UserAppTheme = esOscuro ? AppTheme.Dark : AppTheme.Light;

        MainPage = new AppShell(); 
    }
}
