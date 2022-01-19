using GT_BL.Interface;
using GT_DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GT_WebApi.Controllers
{
    public class BeverageController : ApiController
    {
        IBeverageManager manager;
        public BeverageController(IBeverageManager _manager)
        {
            manager = _manager;
        }

        public List<Beverage> Get()
        {

            //Write your code here
            return manager.GetAllBeverages();


        }

        public Beverage Get(int Id)
        {

            //Write your code here
            return manager.GetBeverageById(Id);
            
        }
    }
}
