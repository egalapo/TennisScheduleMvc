using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennisScheduleMvc.Models
{
    public class SetModel
    {
        public int SetNumber { get; set; }
        public List<GameModel> ListOfGames { get; set; }
    }
}