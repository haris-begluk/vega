using Microsoft.EntityFrameworkCore;

namespace Vega.Persistence {
    public class VegaDbContext :DbContext{ 

    public VegaDbContext(DbContextOptions<VegaDbContext> options) :base(options)
        {   
            
        } 

        /*       
        public VegaDbContext(string connectionString):base(connectionString)
        {   //Ovaj princip ne koristimo u dotnet core
            //System.Configuration.ConfigurationManager
        } 

        */ 


    }
}