using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.Model.DtoModels
{
    public class TurnsDto
    {
        public int Id { get; set; }
        public string? Number { get; set; }
        public string? Status { get; set; }
        public string? Service { get; set; }
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public string? Lang { get; set; }
        public DateTime Create { get; set; }
        public int Priority { get; set; }
        public string? CameFrom { get; set; }
    }
}
