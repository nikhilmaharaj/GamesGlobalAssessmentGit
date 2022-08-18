using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesGlobalAssessment.Models
{
    public class ViewTVShows
    {
        public int TVShowID { get; set; }
        public string Title { get; set; }
        public DateTime? Year { get; set; }
        public string CreatedBy { get; set; }
        public int EpisodeID { get; set; }
        public int EpisodeNo { get; set; }
        public string EpisodeName { get; set; }
        public int Season { get; set; }
    }
}
