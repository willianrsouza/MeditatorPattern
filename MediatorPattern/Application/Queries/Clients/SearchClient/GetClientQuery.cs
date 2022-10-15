using Application.Queries.Clients.DataObjectTransfer;
using MediatR;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Clients.SearchClient
{
    public record GetClientQuery([property: SwaggerSchema("Client Id")] int Id) : IRequest<ClienteQueryResult>;
}
