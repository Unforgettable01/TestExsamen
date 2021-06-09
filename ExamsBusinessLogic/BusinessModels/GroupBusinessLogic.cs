using ExamsBusinessLogic.BindingModels;
using ExamsBusinessLogic.Interfaces;
using ExamsBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsBusinessLogic.BusinessModels
{
    public class GroupBusinessLogic
    {
        public readonly IGroupStorage _groupStorage;

        public GroupBusinessLogic(IGroupStorage groupStorage)
        {
            _groupStorage = groupStorage;
        }

        public List<GroupViewModel> Read (GroupBindingModel model)
        {
            if (model ==null)
            {
               return _groupStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<GroupViewModel> { _groupStorage.GetElement(model) };
            }
            return _groupStorage.GetFiltredList(model);
        }

        public void CreateOrUpdate(GroupBindingModel model)
        {
            var element = _groupStorage.GetElement(new GroupBindingModel
            {
                Name = model.Name
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть группа с таким названием");
            }
            if (model.Id.HasValue)
            {
                _groupStorage.Update(model);
            }
            else
            {
                _groupStorage.Insert(model);
            }

        }
        public void Delete(GroupBindingModel model)
        {
            var element = _groupStorage.GetElement(new GroupBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Такой группы не существует");
            }
            else
                _groupStorage.Delete(model);
        }

    }
}
