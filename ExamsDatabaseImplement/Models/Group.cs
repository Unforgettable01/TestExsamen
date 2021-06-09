using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsDatabaseImplement.Models
{
    public class Group
    {
        public int? Id { get; set; }
        public string GroupName { get; set; }
        public int SongId { get; set; }
        public virtual Song Song { get; set; }
    }
}
