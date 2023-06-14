using PultOperatorNetCore.EntityLayer.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.Model
{
    public class CurrentTurn : IEntityBase
    {
        public int Id { get; set; }
        public string? TurnNumber { get; set; }
        public int WindowNumber { get; set; }
        public string? Lang { get; set; }
        public int IsSay { get; set; }

    }
}
