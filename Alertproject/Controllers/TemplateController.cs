using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alertproject.Interfaces;
using Alertproject.Tables;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alertproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private ITemplate itemplate;
        private IMapper _mapper;


        public TemplateController(ITemplate templaterr, IMapper mapper)
        {
            itemplate = templaterr;
            _mapper = mapper;
        }
        // GET api/templates
        [HttpGet]
        public ActionResult<IEnumerable<Template>> Get()
        {
            var x = itemplate.GetAll();
            return x;
        }

     
        // GET api/templates/5
        [HttpGet("{id}")]
        public Template Get(int id)
        {
            return itemplate.Get(id);
        }
    }
}