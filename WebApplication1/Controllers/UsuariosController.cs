using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuariosController : ControllerBase
{

    private readonly ILogger<UsuariosController> _logger;
    private readonly UsuariosServices _usuariosServices;

    public UsuariosController(ILogger<UsuariosController> logger, UsuariosServices usuariosServices)
    {
        _logger = logger; 
        _usuariosServices = usuariosServices;   
    }

    [HttpGet]
    public List<Usuario> Get()
    {
        return _usuariosServices.GetAll();
    }
    
    [HttpPost]
    public void Create([FromBody] Usuario usuario)
    {
        _usuariosServices.Create(usuario);
    }
}