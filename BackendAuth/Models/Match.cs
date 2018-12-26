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
        public double SafetySucces { get; set; }
        public DateTime DurationMatch { get; set; }
        public DateTime AverageShotTime { get; set; }
        public int NumberMatchesWon { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [JsonIgnore] //anders circular ref exception
        public User User { get; set; }
        public virtual ICollection<Frame> Frames { get; set; }
    }
}
