
using Core.Dto;

namespace Core.Interfaces.Database
{
    public interface IClientRepository
    {
        Task<ClientDto> GetClientById(int Id);
    }
}
