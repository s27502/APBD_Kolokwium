using WebApplication1.Repository;

namespace WebApplication1.Service;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public int deleteClient(int id)
    {
        return _clientRepository.deleteClient(id);;
    }
}