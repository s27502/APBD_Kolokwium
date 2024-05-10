using Microsoft.AspNetCore.Mvc;
using WebApplication1.Service;

namespace WebApplication1.Controller;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }
    
    [HttpDelete("{id:int}")]
    public IActionResult DeleteStudent(int id)
    {
        var affectedCount = _clientService.deleteClient(id);
        return NoContent();
    }
}