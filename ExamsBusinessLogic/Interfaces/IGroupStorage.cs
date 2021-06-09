using ExamsBusinessLogic.BindingModels;
using ExamsBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsBusinessLogic.Interfaces
{
    public interface IGroupStorage
    {
        List<GroupViewModel> GetFullList();
        List<GroupViewModel> GetFiltredList(GroupBindingModel model);
        GroupViewModel GetElement(GroupBindingModel model);

        void Insert(GroupBindingModel model);
        void Update(GroupBindingModel model);
        void Delete(GroupBindingModel model);

    }
}
