using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alertproject.Interfaces;
using Alertproject.Tables;

namespace Alertproject.Repos
{
    public class TemplateRepo : BaseRepo<Template>, ITemplate
    {
        private AppContext _app;
        public TemplateRepo(AppContext app) : base(app)
        {
            _app = app;
        }

    }
}
