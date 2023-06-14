using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PultOperatorNetCore.BisnesLayer.Services.AbstractServices;
using PultOperatorNetCore.EntityLayer;
using PultOperatorNetCore.EntityLayer.BaseRepository;
using PultOperatorNetCore.Model;
using PultOperatorNetCore.Model.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PultOperatorNetCore.BisnesLayer.Services
{
    public class PositionSevService : EntityBaseRepository<PositionService>, IPositionSevService
    {
        AppDbContextFactory _contextFactory;
        public PositionSevService(AppDbContextFactory context) : base(context)
        {
            _contextFactory = context;
        }

        public async Task<IEnumerable<TurnsDto>> GetWithTableAsync(int Id, int UserId)
        {
            using AppDbContext _context = _contextFactory.CreateDbContext();
            var result = from p in _context.PositionService
                         join t in _context.Turns on p.ServiceId equals t.ServiceId
                         join s in _context.Services on t.ServiceId equals s.Id
                         where t.CreateDate.Date == DateTime.Now.Date
                         && t.Status != "kassa"
                         && ((t.UserId == 0 && p.PositionId == Id) || t.UserId == UserId)
                         orderby t.CreateDate
                         orderby s.Priority descending
                         select new
                         {
                             Id = t.Id,
                             Number = s.Latter + t.Number.ToString(),
                             Status = t.Status,
                             Service = s.ServiceName,
                             ServiceId = t.ServiceId,
                             UserId = t.UserId,
                             Lang = t.Lang,
                             Create = t.CreateDate,
                             Priority = s.Priority,
                             CameFrom = t.CameFrom

                         };
            
            
            var res = JsonConvert.SerializeObject(result);
            IEnumerable<TurnsDto> ServiceList = JsonConvert.DeserializeObject<IEnumerable<TurnsDto>>(res);
            IEnumerable<TurnsDto> f = ServiceList.GroupBy(t => t.Id).Select(x=>x.FirstOrDefault());
           
            return f;
        }
    }
}
