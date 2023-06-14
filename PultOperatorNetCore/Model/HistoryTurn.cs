using PultOperatorNetCore.EntityLayer.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.Model
{
    public class HistoryTurn : IEntityBase
    {
        public int Id { get; set; }
        public int TurnId { get; set; }
        public string? Number { get; set; }
        public int ServiceId { get; set; }
        public Service? service { get; set; }
        public int UserId { get; set; }
        public User? user { get; set; }
        public string? Lang { get; set; }
        public int Absence { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
