using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alertproject.Interfaces;
using Alertproject.Tables;

namespace Alertproject.Repos
{
    public class EventRepo : BaseRepo<Event>, IEventRepo
    {

        private AppContext _app;
        public EventRepo(AppContext app) : base(app)
        {
            _app = app;
        }

    }
}
