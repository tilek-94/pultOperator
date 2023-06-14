using PultOperatorNetCore.BisnesLayer.Services.AbstractServices;
using PultOperatorNetCore.EntityLayer;
using PultOperatorNetCore.EntityLayer.BaseRepository;
using PultOperatorNetCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.BisnesLayer.Services
{
    public class PositionServices : EntityBaseRepository<Position>, IPositionServices
    {
        public PositionServices(AppDbContextFactory context) : base(context)
        {
        }
    }
}
