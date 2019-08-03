﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alertproject.Interfaces;
using Alertproject.Tables;

namespace Alertproject.Repos
{
    public class EventPropertyRepo : BaseRepo <EventProperties>, IEventPropertyRepo
    {

        private AppContext _app;
        public EventPropertyRepo(AppContext app) : base(app)
        {
            _app = app;
        }

    }
}
