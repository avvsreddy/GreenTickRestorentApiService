using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GT_BL.Interface;
using GT_BL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GT_API.Controllers
{
    [Produces("application/json")]
    [Route("api/Menu")]
    public class MenuController : Controller
    {
        IMenuManager manager;
        public MenuController(IMenuManager _manager)
        {
            manager = _manager;
        }
        [HttpGet]
        public List<FoodItem> Get()
        {
            return manager.GetAllItems();
        }

        [HttpPost]

        public List<FoodItem> Post(FoodItem Item)
        {
            var data = Item.ToString();
            FoodItem food = JsonConvert.DeserializeObject<FoodItem>(data);
            return manager.SaveItem(food);
        }
    }
}