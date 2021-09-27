using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitventure.Models
{
    public class Planets
    {
        public string Name { get; set; }
        public string Rotation_period { get; set; }
        public string Orbital_period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string Surface_water { get; set; }
        public string Population { get; set; }
        public List<string> Residents { get; set; }
        public List<string> Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
    public class PlanetsRoot
    {
        public int count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public List<Planets> Results { get; set; }
    }
}
