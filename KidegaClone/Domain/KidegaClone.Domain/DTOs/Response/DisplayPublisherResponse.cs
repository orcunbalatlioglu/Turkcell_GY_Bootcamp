using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaClone.Domain.DTOs.Response
{
    public class DisplayPublisherResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Picture { get; set; }
    }
}
