using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennisScheduleMvc.Models
{
    public class MatchModel
    {
        public int MatchId { get; set; }
        public List<SetModel> ListOfMatches { get; set; }
    }
}