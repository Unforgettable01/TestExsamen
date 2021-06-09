using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamsDatabaseImplement.Models
{
    public class Song
    {
        public int? Id { get; set; }
        public string SongName { get; set; }
        [ForeignKey("SongId")]
        public virtual List<Group> Groups { get; set; }
    }
}
