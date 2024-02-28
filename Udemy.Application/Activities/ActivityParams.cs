﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Application.Core;

namespace Udemy.Application.Activities
{
    public class ActivityParams : PagingParams
    {
        public bool IsGoing { get; set; }
        public bool IsHost { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
    }
}
