using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsBusinessLogic.BindingModels
{
    public class GroupBindingModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int,(string, int)> Songs { get; set; }
    }
}
