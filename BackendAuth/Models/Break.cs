using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAuth.Models
{
    public class Break
    {
        [Key]
        public int BreakId { get; set; }
        public string Player { get; set; }
        public DateTime MomentPlayed { get; set; }
        public int NumberPoints { get; set; }
        public string Opponent { get; set; }
        public string TypeBreak { get; set; }
        [ForeignKey("Frame")]
        public int? FrameId { get; set; }
        [JsonIgnore] //anders circular ref exception
        public Frame Frame { get; set; }
    }
}
