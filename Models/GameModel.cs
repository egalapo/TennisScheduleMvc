using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TennisScheduleMvc.Models
{
    public class GameModel
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int GameNumber { get; set; }
    }
}