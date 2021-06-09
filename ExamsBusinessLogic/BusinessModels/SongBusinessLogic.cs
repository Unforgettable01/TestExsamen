using ExamsBusinessLogic.BindingModels;
using ExamsBusinessLogic.Interfaces;
using ExamsBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;

namespace ExamsBusinessLogic.BusinessModels
{
    public class SongBusinessLogic
    {
        public readonly ISongStorage _songStorage;

        public SongBusinessLogic(ISongStorage songStorage)
        {
            _songStorage = songStorage;
        }

        public List<SongViewModel> Read(SongBindingModel model)
        {
            if (model == null)
            {
                return _songStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<SongViewModel> { _songStorage.GetElement(model) };
            }
            return _songStorage.GetFiltredList(model);
        }
        public void CreateOrUpdate(SongBindingModel model)
        {
            var element = _songStorage.GetElement(new SongBindingModel
            {
                Name = model.Name
            });
            if (element != null && element.Id != model.Id)
            {
                throw new Exception("Уже есть песня с таким названием");
            }
            if (model.Id.HasValue)
            {
                _songStorage.Update(model);
            }
            else
            {
                _songStorage.Insert(model);
            }
            
        }
        public void Delete(SongBindingModel model)
        {
            var element = _songStorage.GetElement(new SongBindingModel
            {
                Id = model.Id
            });

            if (element == null)
            {
                throw new Exception("Такой песни не существует");
            }
            else
                _songStorage.Delete(model);
        }
    }
}
