using System;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using LoginFlow.Modelos;

namespace LoginFlow.Datos
{
    public class UsuarioDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public UsuarioDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait();

        }

        public Task<int> RegistrarUsuarioAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }


        public Task<Usuario> ValidarCredencialesAsync(string nombreUsuario, string password)
        {
            return _database.Table<Usuario>()
                            .Where(u => u.NombreUsuario == nombreUsuario && u.Password == password)
                            .FirstOrDefaultAsync();
        }
        public Task<Usuario> ObtenerUsuarioAsync(string nombreUsuario)
        {
            return _database.Table<Usuario>()
                            .Where(u => u.NombreUsuario == nombreUsuario)
                            .FirstOrDefaultAsync();
        }
        public Task<List<Usuario>> ObtenerUsuariosAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

    }
}
