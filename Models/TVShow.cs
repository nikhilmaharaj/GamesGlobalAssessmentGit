using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesGlobalAssessment.Models
{
    public class TVShow
    {
        public int TVShowID { get; set; }
        public string Title { get; set; }
        public DateTime? Year { get; set; }
        public string CreatedBy { get; set; }
    }
}
