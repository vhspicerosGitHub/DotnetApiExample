using System.Runtime.CompilerServices;

namespace WebApplication1.Services;

public class UsuariosServices
{
    private  List<Usuario> usuarios { get; set; }

    public UsuariosServices()
    {
        usuarios = new List<Usuario>();
    }

    public List<Usuario> GetAll()
    {
        return this.usuarios;
    }
    
    public  void   Create(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    public Usuario GetByEmail(string email)
    {
        return usuarios.First(x => x.Email == email);
    }
}