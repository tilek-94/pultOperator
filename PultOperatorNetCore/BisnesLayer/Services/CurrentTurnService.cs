using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
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
    public class CurrentTurnService : EntityBaseRepository<CurrentTurn>, ICurrentTurnService
    {
        AppDbContextFactory _context;
        public CurrentTurnService(AppDbContextFactory context) : base(context)
        {
            _context = context;
        }

        public async Task DeleteCurrentTurnAsync(int id)
        {
            using AppDbContext db = _context.CreateDbContext();
            var entity = await db.CurrentTurn.Where(n => n.WindowNumber == id).ToListAsync();
            db.CurrentTurn.RemoveRange(entity);
            await db.SaveChangesAsync();
        }
    }
}
