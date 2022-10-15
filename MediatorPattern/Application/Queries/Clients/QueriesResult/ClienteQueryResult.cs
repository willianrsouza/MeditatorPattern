
using Swashbuckle.AspNetCore.Annotations;

namespace Application.Queries.Clients.DataObjectTransfer
{
    public record ClienteQueryResult(
        [property :SwaggerSchema("Client")]
        int Id, string FirstName, string LastName, string Age);
}
