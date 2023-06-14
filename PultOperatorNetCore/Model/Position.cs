﻿using PultOperatorNetCore.EntityLayer.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PultOperatorNetCore.Model
{
    public class Position : IEntityBase
    {
        public int Id { get; set; }
        public string? NamePosition { get; set; }
    }
}
