using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ExamsBusinessLogic.ViewModels
{
    [DataContract]
    public class GroupViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("Название группы")]
        public string Name { get; set; }
        public Dictionary<int, (string, int)> Songs { get; set; }


    }
}
