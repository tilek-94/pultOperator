using PultOperatorNetCore.EntityLayer.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.Model
{
    public class PositionService : IEntityBase
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public Position? position { get; set; }
        public int ServiceId { get; set; }
        public Service? service { get; set; }
       
        
    }
}
