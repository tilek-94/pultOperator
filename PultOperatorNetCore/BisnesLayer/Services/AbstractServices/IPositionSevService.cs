using PultOperatorNetCore.EntityLayer.BaseRepository;
using PultOperatorNetCore.Model;
using PultOperatorNetCore.Model.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.BisnesLayer.Services.AbstractServices
{
    public interface IPositionSevService : IEntityBaseRepository<PositionService>
    {
        Task<IEnumerable<TurnsDto>> GetWithTableAsync(int Id, int UserId);
    }
}
