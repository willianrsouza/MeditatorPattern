using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto
{
    public record ClientDto(
        int Id, string FirstName, string LastName, string Age);
}
