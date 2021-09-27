using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitventure.Models
{
    public class Species
    {
        public string Name { get; set; }
        public string Classification { get; set; }
        public string Designation { get; set; }
        public string Average_height { get; set; }
        public string Skin_colors { get; set; }
        public string Hair_colors { get; set; }
        public string Eye_colors { get; set; }
        public string Average_lifespan { get; set; }
        public string Homeworld { get; set; }
        public string Language { get; set; }
        public List<string> People { get; set; }
        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }

    public class SpeciesRoot
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public List<Species> Species { get; set; }
    }
}
