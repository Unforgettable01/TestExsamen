using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace ExamsBusinessLogic.ViewModels
{
    [DataContract]
    public class SongViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("Название песни")]
        public string Name { get; set; }
    }
}
