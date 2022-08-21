using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamesGlobalAssessment.Models
{
    public class ViewEpisodes
    {
        [Key]
        public int EpisodeID { get; set; }
        public int EpisodeNo { get; set; }
        public string EpisodeName { get; set; }
        public int Season { get; set; }
        public int TVShowID { get; set; }
        public bool? Watched { get; set; }
        public string CreatedBy { get; set; }
        public string Title { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public int Year { get; set; }
    }
}
