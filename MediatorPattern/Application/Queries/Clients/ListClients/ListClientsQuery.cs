using Application.Queries.Clients.DataObjectTransfer;
using MediatR;
namespace Application.Queries.Clients.ListClients
{
    public record ListClientsQuery() : IRequest<IEnumerable<ClienteQueryResult>>;
}
