using GT_DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT_DL.Interface
{
    public interface IMenuRepository
    {
        List<FoodItem> GetAllItems();
        List<FoodItem> SaveItem(FoodItem food);
        FoodItem GetItemById(int Id);
        List<FoodItem> DeleteItem(int Id);
        List<FoodItem> UpdateItem(int Id, FoodItem food);
        FoodItem UpdateField(int Id, string Name);
    }
}
