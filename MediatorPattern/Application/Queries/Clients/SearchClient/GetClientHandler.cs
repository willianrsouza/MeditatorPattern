using Application.Queries.Clients.DataObjectTransfer;
using AutoMapper;
using Core.Dto;
using Core.Interfaces.Database;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Application.Queries.Clients.SearchClient
{
    public class GetClientHandler : IRequestHandler<GetClientQuery, ClienteQueryResult>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public GetClientHandler(IClientRepository clientRepository, IMapper mapper )
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<ClienteQueryResult> Handle(GetClientQuery request, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetClientById(request.Id);

            return _mapper.Map<ClienteQueryResult>(client); 
        }
    }
}
