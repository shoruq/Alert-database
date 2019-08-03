using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alertproject.Interfaces;
using Alertproject.Tables;

namespace Alertproject.Repos
{
    public class TemplateFieldRepo : BaseRepo<TemplateFields>, ITemplatePropertyRepo
    {

        private AppContext _app;
        public TemplateFieldRepo(AppContext app) : base(app)
        {
            _app = app;
        }

    }
}
