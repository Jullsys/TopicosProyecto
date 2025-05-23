using SQLite;

namespace LoginFlow.Modelos
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }  
    }
}
