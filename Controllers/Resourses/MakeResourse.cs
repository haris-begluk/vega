using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Vega.Models{
    public class MakeResourse {
        public  int  Id { get; set; }  
      
        public string Name { get; set; } 
        public ICollection<ModelResourse> Models { get; set; } 

        //make.Models = new Collection<Model>();
        public MakeResourse()
        {
            Models = new Collection<ModelResourse>();
        } 
    }
}