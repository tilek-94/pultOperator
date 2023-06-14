using PultOperatorNetCore.EntityLayer.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.Model
{
    public class Options : IEntityBase
    {
        public int Id { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }

    }
}
