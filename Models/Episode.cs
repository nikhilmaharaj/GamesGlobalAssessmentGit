using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamesGlobalAssessment.Models
{
    public class Episode
    {
        public int EpisodeID { get; set; }
        public int EpisodeNo { get; set; }
        public string EpisodeName { get; set; }
        public int Season { get; set; }
        public int TVShowID { get; set; }
        public bool Watched { get; set; }
    }
}
