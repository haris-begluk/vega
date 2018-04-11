using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Persistence {
    public class VegaDbContext :DbContext{  
        //Ako su klase povezane vezom kao sto su 
        //Model i Make klase tada ce Entity prepoznati vezu i kreirati 
        //odgovarajuce tabele
        public DbSet<Make> Makes { get; set; }
    public VegaDbContext(DbContextOptions<VegaDbContext> options)
         :base(options)
        {   
            
        } 
    }
}