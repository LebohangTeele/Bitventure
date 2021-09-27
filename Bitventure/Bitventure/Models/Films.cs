using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitventure.Models
{
     class Films
    {
        public string Title { get; set; }
        public int Episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Release_date { get; set; }
        public List<string> Characters { get; set; }
        public List<string> Planets { get; set; }
        public List<string> Starships { get; set; }
        public List<string> Vehicles { get; set; }
        public List<string> Species { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }
    //public class FilmsRoot
    //{
    //    public int Count { get; set; }
    //    public object Next { get; set; }
    //    public object Previous { get; set; }
    //    public List<Films> Films { get; set; }
    //}
}
