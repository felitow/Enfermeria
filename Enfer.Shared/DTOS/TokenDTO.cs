using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enfer.Shared.Entities;

namespace Enfer.Shared.DTOS
{
    public class TokenDTO
    {

        public string Token { get; set; } = null!;

        public DateTime Expiration { get; set; }

    }
}
