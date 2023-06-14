using PultOperatorNetCore.EntityLayer.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.Model
{
    public class Turns : IEntityBase
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string? Status { get; set; }
        public int ServiceId { get; set; }
        public Service? service { get; set; }
        public int UserId { get; set; }
        public string? Lang { get; set; }
        public string? CameFrom { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
