using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAuth.Models
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public double PotSucces { get; set; }
        public string Player { get; set; }
        public string Opponent { get; set; }
        public double SafetySucces { get; set; }
        public DateTime DurationMatch { get; set; }
        public DateTime AverageShotTime { get; set; }
        public int NumberMatchesWonPlayer1 { get; set; }
        public int NumberMatchesWonPlayer2 { get; set; }
        public int OpslaanBreak { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<Frame> Frames { get; set; }
    }
}
