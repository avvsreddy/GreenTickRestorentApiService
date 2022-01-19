using GT_BL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using GT_DL.Models;
using GT_DL.Interface;

namespace GT_BL.Implementation
{
   public class MenuManager : IMenuManager
    {
        IMenuRepository repository;
        public MenuManager(IMenuRepository _repository)
        {
            repository = _repository;
        }
        public List<FoodItem> DeleteItem(int Id)
        {
            return repository.DeleteItem(Id);
        }

        public List<FoodItem> GetAllItems()
        {
            return repository.GetAllItems();
        }

        public FoodItem GetItemById(int Id)
        {
            return repository.GetItemById(Id);
        }

        public List<FoodItem> SaveItem(FoodItem food)
        {
            return repository.SaveItem(food);
        }

        public FoodItem UpdateField(int Id, string Name)
        {
            return repository.UpdateField(Id, Name);
        }

        public List<FoodItem> UpdateItem(int Id,FoodItem food)
        {
            return repository.UpdateItem(Id, food);
        }

        
    }
}
