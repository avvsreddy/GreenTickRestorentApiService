using GT_DL.Interface;
using GT_DL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GT_DL.Implementation
{
   public class MenuRepository : IMenuRepository
    {
        public List<FoodItem> DeleteItem(int Id)
        {
            List<FoodItem> food = this.GetAllItems();
            List<FoodItem> value = food.Where(a => a.Id != Id).Select(a => a).ToList();
            return value;
        }

        public List<FoodItem> GetAllItems()
        {       
            var file = HttpContext.Current.Server.MapPath("~/Resource/FoodItem.txt");
            var data = File.ReadAllText(file);
            List<FoodItem> food = JsonConvert.DeserializeObject<List<FoodItem>>(data);
            return food;
        }

        public FoodItem GetItemById(int Id)
        {
            List<FoodItem> food = this.GetAllItems();
            FoodItem value = food.Where(a => a.Id == Id).Select(a => a).FirstOrDefault();
            return value;
        }

        public List<FoodItem> SaveItem(FoodItem food)
        {
            List<FoodItem> item = GetAllItems();
            item.Add(food);
            var convertedJson = JsonConvert.SerializeObject(item, Formatting.Indented);
            item = JsonConvert.DeserializeObject<List<FoodItem>>(convertedJson);
            return item;
        }

        public FoodItem UpdateField(int Id, string Name)
        {
            FoodItem Item = this.GetAllItems().Where(a => a.Id == Id).Select(a => a).FirstOrDefault();
            Item.Name = Name;
            return Item;
        }

        public List<FoodItem> UpdateItem(int Id, FoodItem food)
        {
            FoodItem value = this.GetItemById(Id);
            List<FoodItem> Items = this.GetAllItems();
            List<FoodItem> FilterItems = Items.Where(a => a.Id != value.Id).ToList();
            FilterItems.Add(food);
            return FilterItems;
        }
    }
}
