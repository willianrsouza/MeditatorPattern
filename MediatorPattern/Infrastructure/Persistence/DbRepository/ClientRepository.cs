using Core.Dto;
using Core.Interfaces.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.DbRepository
{
    public class ClientRepository : IClientRepository
    {

        List<ClientDto> clientList = new List<ClientDto>
            {
                new ClientDto(1, "Fernando", "Rodrigues", "18"),
                new ClientDto(2, "Carlos", "Roberto", "19"),
                new ClientDto(3, "Lucas", "Souza", "24"),
                new ClientDto(4, "Maria", "Olivia", "22"),
                new ClientDto(5, "Susana", "Pereira", "19")
         };


        public Task<ClientDto> GetClientById(int Id)
        {
            var result = clientList.First(x => x.Id == Id);

            return Task.FromResult(result);

        }
    }
}
