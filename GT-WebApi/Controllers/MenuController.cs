using GT_BL.Interface;
using GT_DL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GT_WebApi.Controllers
{
    public class MenuController : ApiController
    {
        IMenuManager manager;
        public MenuController(IMenuManager _manager)
        {
            manager = _manager;
        }

        // GET: api/Menu
        public List<FoodItem> Get()
        {
            return manager.GetAllItems();
        }

        // GET: api/Menu/5
        public FoodItem Get(int id)
        {
                return manager.GetItemById(id);
        }
        
        // POST: api/Menu
        public List<FoodItem> Post([FromBody]Object value)
        {
            var data = value.ToString();
            FoodItem food = JsonConvert.DeserializeObject<FoodItem>(data);
            return manager.SaveItem(food);
        }
        
        

    }
}
