using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamesGlobalAssessment.Models
{
    public class ViewTVShows
    {
        public int TVShowID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string CreatedBy { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
    }
}
