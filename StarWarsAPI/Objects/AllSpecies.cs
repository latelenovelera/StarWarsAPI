using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsAPI.Objects
{
    //Public class
    public class AllSpecies
    {
        //AllSpecies attributes and list results from Species
        public int count { get; set; }
        public string next { get; set; }
        public object previous { get; set; }
        public List<Species> results { get; set; }
    }
}
