using ExamsBusinessLogic.BindingModels;
using ExamsBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamsBusinessLogic.Interfaces
{
    public interface ISongStorage
    {
        List<SongViewModel> GetFullList();
        List<SongViewModel> GetFiltredList(SongBindingModel model);
        SongViewModel GetElement(SongBindingModel model);

        void Insert(SongBindingModel model);
        void Update(SongBindingModel model);
        void Delete(SongBindingModel model);
    }
}
