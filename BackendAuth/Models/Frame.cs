using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAuth.Models
{
    public class Frame
    {
        [Key]
        public int FrameId { get; set; }
        public DateTime DurationFrame { get; set; }
        public int Points { get; set; }
        public string Winner { get; set; }
        [ForeignKey("Match")]
        public int MatchId { get; set; }
        [JsonIgnore] //anders circular ref exception
        public Match Match { get; set; }
        public virtual ICollection<Break> Breaks { get; set; }
    }
}
