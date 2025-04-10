using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    class GetPersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalId { get; set; }
    }
}
