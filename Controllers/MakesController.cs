using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vega.Models;
using Vega.Persistence;
/* 
U ASP.NET MVC-u Imali smo dva razlicita tipa kontrolera Controller  i ApiController
u ASP.NET CORE imamo samo jedan tip 
*/
namespace Vega.Controllers{
    public class MakesController : Controller{
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public MakesController(VegaDbContext context,  IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResourse>> GetMakes(){ 
            //Primjena auto mapera za objekte 
             var makes = await context.Makes.Include(m => m.Models).ToListAsync(); 
             return mapper.Map<List<Make>, List<MakeResourse>>(makes);
        }
    }
}