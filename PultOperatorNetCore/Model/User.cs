using PultOperatorNetCore.EntityLayer.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.Model
{
    public class User : IEntityBase
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public int PositionId { get; set; }
        public int AtWork { get; set; }

    }
}
