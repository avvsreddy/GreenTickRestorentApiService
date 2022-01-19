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
    public class BeverageRepository : IBeverageRepository
    {
        public List<Beverage> GetAllBeverages()
        {
            string file = HttpContext.Current.Server.MapPath("~/Resource/Beverages.txt");
            var data = File.ReadAllText(file);
            List<Beverage> Beverages = JsonConvert.DeserializeObject<List<Beverage>>(data);
            return Beverages;
        }

        public Beverage GetBeverageById(int Id)
        {
            Beverage item = this.GetAllBeverages().Where(a => a.Id == Id).FirstOrDefault();
            return item;
        }
    }
}
