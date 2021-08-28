using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Statdrop.Models
{
    public class Solutions
    {

        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatePlayed { get; set; }
        public string Team { get; set; }
        public decimal TeamScore { get; set; }
        public string Rival { get; set; }

        public decimal RivalScore { get; set; }
    }
}
