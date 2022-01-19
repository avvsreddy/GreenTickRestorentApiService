using GT_DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT_BL.Interface
{
   public interface IBeverageManager
    {
        List<Beverage> GetAllBeverages();
        Beverage GetBeverageById(int Id);
    }
}
