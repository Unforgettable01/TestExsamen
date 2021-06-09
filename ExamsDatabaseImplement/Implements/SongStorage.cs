using ExamsBusinessLogic.BindingModels;
using ExamsBusinessLogic.Interfaces;
using ExamsBusinessLogic.ViewModels;
using ExamsDatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamsDatabaseImplement.Implements
{
    public class SongStorage : ISongStorage
    {
        public List<SongViewModel> GetFullList()
        {
            using (var context = new MyDbContext())
            {
                return context.Songs
                .Select(rec => new SongViewModel
                {
                    Id = (int)rec.Id,
                    Name = rec.SongName
                })
               .ToList();
            }
        }
        public List<SongViewModel> GetFiltredList(SongBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new MyDbContext())
            {
                return context.Songs
                .Where(rec => rec.SongName.Contains(model.Name))
               .Select(rec => new SongViewModel
               {
                   Id = (int)rec.Id,
                   Name = rec.SongName
               })
                .ToList();
            }
        }
        public SongViewModel GetElement(SongBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new MyDbContext())
            {
                var song = context.Songs
                .FirstOrDefault(rec => rec.SongName == model.Name ||
               rec.Id == model.Id);
                return song != null ?
                new SongViewModel
                {
                    Id = (int)song.Id,
                    Name = song.SongName
                } :
               null;
            }
        }
        public void Insert(SongBindingModel model)
        {
            using (var context = new MyDbContext())
            {
                context.Songs.Add(CreateModel(model, new Song()));
                context.SaveChanges();
            }
        }
        public void Update(SongBindingModel model)
        {
            using (var context = new MyDbContext())
            {
                var element = context.Songs.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }
        public void Delete(SongBindingModel model)
        {
            using (var context = new MyDbContext())
            {
                Song element = context.Songs.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (element != null)
                {
                    context.Songs.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        private Song CreateModel(SongBindingModel model, Song song)
        {
            song.SongName = model.Name;
            return song;
        }
    }

}
