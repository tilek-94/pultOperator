using PultOperatorNetCore.EntityLayer.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.Model
{
    public class Service : IEntityBase
    {
        public int Id { get; set; }
        public string? ServiceName { get; set; }
        public int ParentId { get; set; }
        public string? Latter { get; set; }
        public int Priority { get; set; }
        public int isActive { get; set; }

    }
}
