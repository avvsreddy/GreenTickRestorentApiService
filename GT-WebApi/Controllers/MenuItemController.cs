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
    public class MenuItemController : ApiController
    {
        IMenuManager manager;
        public MenuItemController(IMenuManager _manager)
        {
            manager = _manager;
        }
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, manager.GetAllItems().ToList());
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Data Found");
            }
        }
        
        public HttpResponseMessage Get(int id)
        {
            FoodItem item = manager.GetItemById(id);

            if (item != null)
            {
                return Request.CreateResponse<FoodItem>(HttpStatusCode.OK, item);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "FoodItem not found");
            }
        }

        public HttpResponseMessage Post([FromBody]Object foodItem)
        {
            try
            {
                var data = foodItem.ToString();
                FoodItem food = JsonConvert.DeserializeObject<FoodItem>(data);
                var response = Request.CreateResponse(HttpStatusCode.Created, food);
                response.Headers.Location = Request.RequestUri;

                return response;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Data not Inserted");
            }
        }
    }
}
